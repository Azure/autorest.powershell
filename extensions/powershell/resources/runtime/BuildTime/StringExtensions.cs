using System;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class StringExtensions
    {
        public static string NullIfEmpty(this string text) => String.IsNullOrEmpty(text) ? null : text;
        public static string NullIfWhiteSpace(this string text) => String.IsNullOrWhiteSpace(text) ? null : text;
        public static string EmptyIfNull(this string text) => text ?? String.Empty;

        public static bool? ToNullableBool(this string text) => String.IsNullOrEmpty(text) ? (bool?)null : Convert.ToBoolean(text.ToLowerInvariant());

        public static string ToUpperFirstCharacter(this string text) => String.IsNullOrEmpty(text) ? text : $"{text[0].ToString().ToUpperInvariant()}{text.Remove(0, 1)}";

    }
}
