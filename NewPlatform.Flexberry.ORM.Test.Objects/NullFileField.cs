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
    /// Нужен для тестирования сериализации объекта данных с полем типа File.
    /// </summary>
    // *** Start programmer edit section *** (NullFileField CustomAttributes)

    // *** End programmer edit section *** (NullFileField CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class NullFileField : ICSSoft.STORMNET.DataObject
    {
        
        private ICSSoft.STORMNET.FileType.File fFileField;
        
        // *** Start programmer edit section *** (NullFileField CustomMembers)

        // *** End programmer edit section *** (NullFileField CustomMembers)

        
        /// <summary>
        /// FileField.
        /// </summary>
        // *** Start programmer edit section *** (NullFileField.FileField CustomAttributes)

        // *** End programmer edit section *** (NullFileField.FileField CustomAttributes)
        public virtual ICSSoft.STORMNET.FileType.File FileField
        {
            get
            {
                // *** Start programmer edit section *** (NullFileField.FileField Get start)

                // *** End programmer edit section *** (NullFileField.FileField Get start)
                ICSSoft.STORMNET.FileType.File result = this.fFileField;
                // *** Start programmer edit section *** (NullFileField.FileField Get end)

                // *** End programmer edit section *** (NullFileField.FileField Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (NullFileField.FileField Set start)

                // *** End programmer edit section *** (NullFileField.FileField Set start)
                this.fFileField = value;
                // *** Start programmer edit section *** (NullFileField.FileField Set end)

                // *** End programmer edit section *** (NullFileField.FileField Set end)
            }
        }
    }
}