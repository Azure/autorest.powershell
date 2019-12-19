/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
namespace Carbon.Json
{
    using System;

    public partial class JsonNumber
    {
        public static readonly DateTime EpochDate = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static long ToUnixTime(DateTime dateTime)
        {
            return (long)dateTime.Subtract(EpochDate).TotalSeconds;
        }
        private static DateTime FromUnixTime(long totalSeconds)
        {
            return EpochDate.AddSeconds(totalSeconds);
        }
        public byte ToByte() => this;
        public int ToInt() => this;
        public long ToLong() => this;
        public short ToShort() => this;
        public UInt16 ToUInt16() => this;
        public UInt32 ToUInt32() => this;
        public UInt64 ToUInt64() => this;
        public decimal ToDecimal() => this;
        public double ToDouble() => this;
        public float ToFloat() => this;

        public static JsonNumber Create(int? value) => value is int n ? new JsonNumber(n) : null;
        public static JsonNumber Create(long? value) => value is long n ? new JsonNumber(n) : null;
        public static JsonNumber Create(float? value) => value is float n ? new JsonNumber(n) : null;
        public static JsonNumber Create(double? value) => value is double n ? new JsonNumber(n) : null;
        public static JsonNumber Create(decimal? value) => value is decimal n ? new JsonNumber(n) : null;
        public static JsonNumber Create(DateTime? value) => value is DateTime date ? new JsonNumber(ToUnixTime(date)) : null;

        public static implicit operator DateTime(JsonNumber number) => FromUnixTime(number);
        public DateTime ToDateTime() => this;

        public JsonNumber(decimal value)
        {
            this.value = value.ToString();
        }
        internal override object ToValue()
        {
            if (IsInteger)
            {
                if (int.TryParse(this.value, out int iValue))
                {
                    return iValue;
                }
                if (long.TryParse(this.value, out long lValue))
                {
                    return lValue;
                }
            }
            else
            {
                if (float.TryParse(this.value, out float fValue))
                {
                    return fValue;
                }
                if (double.TryParse(this.value, out double dValue))
                {
                    return dValue;
                }
                if (decimal.TryParse(this.value, out decimal dcValue))
                {
                    return dcValue;
                }
            }
            return null;
        }
    }


}