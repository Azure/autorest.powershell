namespace Carbon.Json
{
    using System;
    using System.Globalization;
    using System.Linq;

    public partial class JsonString
    {
        public static string DateFormat = "yyyy-MM-dd";
        public static string DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
        public static string DateTimeRfc1123Format = "R";

        public static JsonString Create(string value) => value == null ? null : new JsonString(value);
        public static JsonString Create(char? value) => value is char c ? new JsonString(c.ToString()) : null;

        public static JsonString CreateDate(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateFormat, CultureInfo.CurrentCulture)) : null;
        public static JsonString CreateDateTime(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeFormat, CultureInfo.CurrentCulture)) : null;
        public static JsonString CreateDateTimeRfc1123(DateTime? value) => value is DateTime date ? new JsonString(date.ToString(DateTimeRfc1123Format, CultureInfo.CurrentCulture)) : null;

        public char ToChar() => this.Value?.ToString()?.FirstOrDefault() ?? default(char);
        public static implicit operator char(JsonString value) => value?.ToString()?.FirstOrDefault() ?? default(char);
        public static implicit operator char? (JsonString value) => value?.ToString()?.FirstOrDefault();

        public static implicit operator DateTime(JsonString value) => DateTime.TryParse(value, out var output) ? output : default(DateTime);
        public static implicit operator DateTime? (JsonString value) => DateTime.TryParse(value, out var output) ? output : default(DateTime?);

    }


}