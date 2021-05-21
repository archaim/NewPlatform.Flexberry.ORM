# Exit with nonzero exit code if anything fails.
set -e

if [ -n "$GITHUB_REF" ] 
then
  ifs=$IFS
  IFS=/
  set -- $GITHUB_REF
  IFS=$ifs
  while [ $# -gt 1 ]; do shift; done
  TRAVIS_BRANCH=$1
fi

# Define repository relative GitHub address.
repositoryRelativeGitHubAddress="Flexberry/NewPlatform.Flexberry.ORM"

mkdir autodoc

# Get version from nuspec.
versionTag=$(grep -Eo "<version>.*</version>" ./NewPlatform.Flexberry.ORM.nuspec)
version=$(echo $versionTag | sed 's/\(<version>\|<\/version>\)//g')

sed -i "s/PROJECT_NAME_VERSION/${version}/" ./Doxygen/DoxyConfig

doxygen ./Doxygen/DoxyConfig

# Clone project into 'repository' subdirectory && move to it.
echo "Prepare for deploy to gh-pages."

echo "Clone ${repositoryRelativeGitHubAddress} repository & checkout latest version of gh-pages branch."
git clone --recursive "https://github.com/${repositoryRelativeGitHubAddress}.git" newPlatformFlexberryORMRepositoryGhPages
cd newPlatformFlexberryORMRepositoryGhPages

# Checkout and pull same branch.
git checkout gh-pages
git pull

echo "Navigate to target directory for autodoc in gh-pages."
cd ..
cd "newPlatformFlexberryORMRepositoryGhPages/autodoc"

# Remove results of previous deploy (for current branch) & recreate directory.
rm -rf "${TRAVIS_BRANCH}"
mkdir "${TRAVIS_BRANCH}"

echo "Copy autodoc result into ${TRAVIS_BRANCH} directory."
cp -r ../../autodoc/html/* ${TRAVIS_BRANCH}

cd ..

# Configure git.
git config user.name "Flexberry-man"
git config user.email "mail@flexberry.net"

echo "Commit & push changes."
git add --all
git commit -q -m "Update gh-pages for ${TRAVIS_BRANCH} branch"

# Redirect any output to /dev/null to hide any sensitive credential data that might otherwise be exposed.
SSH_AUTH_SOCK=/tmp/ssh_agent.sock
export SSH_AUTH_SOCK;
# Redirect any output to /dev/null to hide any sensitive credential data that might otherwise be exposed.
git push --force --quiet "git@github.com:${repositoryRelativeGitHubAddress}.git" > /dev/null 2>&1

echo "Deploy to gh-pages finished."
