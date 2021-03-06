﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NextGenEMS.Backend.HelperClasses;

namespace NextGenEMS.Demographics
{
    public static class DemographicEnums
    {
        public enum Gender
        {
            Male, 
            Female,
            Refused,
            NonBinary
        }

        public enum Race
        {
            White, 
            Hispanic,
            AsianPacificIslander,
            Black,
            AmericanIndian,
            Other
        }
/*
        /// <summary>
        /// Return the StringValue atribute from the enum
        /// </summary>
        /// <param name="enumValue">The current enum</param>
        /// <returns>the string value for the current enum</returns>
        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        public static string GetStringValue(this Enum enumValue)
        {
            //Fetch the type and field info
            Type type = enumValue.GetType();
            FieldInfo fieldInfo = type.GetField(enumValue.ToString());

            //Fetch the string value attributes 
            EnumGetStringValue.StringValueAttribute[] attributes = fieldInfo.GetCustomAttributes(
                typeof(EnumGetStringValue.StringValueAttribute), false) as EnumGetStringValue.StringValueAttribute[];

            //Return the StringValue attribute
            return attributes.Length > 0 ? attributes[0].StringValue : fieldInfo.Name;
        }

        /// <summary>
        /// Define a StringValue attribute for the Enum class
        /// </summary>
        internal class StringValueAttribute : Attribute
        {
            public string StringValue { get; }

            public StringValueAttribute(string value)
            {
                StringValue = value;
            }
        }*/
    }
}
