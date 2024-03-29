// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{

    /// <summary>
    /// Defines values for SkuName.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SkuName
    {
        [System.Runtime.Serialization.EnumMember(Value = "S1")]
        S1,
        [System.Runtime.Serialization.EnumMember(Value = "S2")]
        S2,
        [System.Runtime.Serialization.EnumMember(Value = "P1")]
        P1,
        [System.Runtime.Serialization.EnumMember(Value = "L1")]
        L1
    }
    internal static class SkuNameEnumExtension
    {
        internal static string ToSerializedValue(this SkuName? value)
        {
            return value == null ? null : ((SkuName)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuName value)
        {
            switch( value )
            {
                case SkuName.S1:
                    return "S1";
                case SkuName.S2:
                    return "S2";
                case SkuName.P1:
                    return "P1";
                case SkuName.L1:
                    return "L1";
            }
            return null;
        }

        internal static SkuName? ParseSkuName(this string value)
        {
            switch( value )
            {
                case "S1":
                    return SkuName.S1;
                case "S2":
                    return SkuName.S2;
                case "P1":
                    return SkuName.P1;
                case "L1":
                    return SkuName.L1;
            }
            return null;
        }
    }
}
