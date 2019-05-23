using System;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class StringExtensions
    {
        public static string EmptyAsNull(this string text) => String.IsNullOrEmpty(text) ? null : text;
        public static string WhiteSpaceAsNull(this string text) => String.IsNullOrWhiteSpace(text) ? null : text;
    }
}
