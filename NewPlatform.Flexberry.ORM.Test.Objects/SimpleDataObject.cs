﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewPlatform.Flexberry.ORM.Tests
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// SimpleDataObject.
    /// </summary>
    // *** Start programmer edit section *** (SimpleDataObject CustomAttributes)

    // *** End programmer edit section *** (SimpleDataObject CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class SimpleDataObject : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private int fAge;
        
        // *** Start programmer edit section *** (SimpleDataObject CustomMembers)

        // *** End programmer edit section *** (SimpleDataObject CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (SimpleDataObject.Name CustomAttributes)

        // *** End programmer edit section *** (SimpleDataObject.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (SimpleDataObject.Name Get start)

                // *** End programmer edit section *** (SimpleDataObject.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (SimpleDataObject.Name Get end)

                // *** End programmer edit section *** (SimpleDataObject.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SimpleDataObject.Name Set start)

                // *** End programmer edit section *** (SimpleDataObject.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (SimpleDataObject.Name Set end)

                // *** End programmer edit section *** (SimpleDataObject.Name Set end)
            }
        }
        
        /// <summary>
        /// Age.
        /// </summary>
        // *** Start programmer edit section *** (SimpleDataObject.Age CustomAttributes)

        // *** End programmer edit section *** (SimpleDataObject.Age CustomAttributes)
        public virtual int Age
        {
            get
            {
                // *** Start programmer edit section *** (SimpleDataObject.Age Get start)

                // *** End programmer edit section *** (SimpleDataObject.Age Get start)
                int result = this.fAge;
                // *** Start programmer edit section *** (SimpleDataObject.Age Get end)

                // *** End programmer edit section *** (SimpleDataObject.Age Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (SimpleDataObject.Age Set start)

                // *** End programmer edit section *** (SimpleDataObject.Age Set start)
                this.fAge = value;
                // *** Start programmer edit section *** (SimpleDataObject.Age Set end)

                // *** End programmer edit section *** (SimpleDataObject.Age Set end)
            }
        }
    }
}