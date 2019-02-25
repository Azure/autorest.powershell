using System;
using System.Collections;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class PsExtensions
    {
        public static string ToPsBool(this bool value) => $"${value.ToString().ToLowerInvariant()}";

        public static string ToPsType(this Type type)
        {
            var regex = new Regex(@"^(.*)`{1}\d+(.*)$");
            var match = regex.Match(type.ToString());
            return match.Success ? $"{match.Groups[1]}{match.Groups[2]}" : type.ToString();
        }

        public static string ToPsStringLiteral(this string value) => value?.Replace("'", "''");

        // https://stackoverflow.com/a/863944/294804
        private static bool IsSimple(this Type type)
        {
            var typeInfo = type.GetTypeInfo();
            if (typeInfo.IsGenericType && typeInfo.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                // nullable type, check if the nested type is simple.
                return typeInfo.GetGenericArguments()[0].IsSimple();
            }

            return typeInfo.IsPrimitive
                   || typeInfo.IsEnum
                   || type == typeof(string)
                   || type == typeof(decimal);
        }

        // https://stackoverflow.com/a/32025393/294804
        private static bool HasImplicitConversion(this Type baseType, Type targetType) =>
            baseType.GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(mi => mi.Name == "op_Implicit" && mi.ReturnType == targetType)
                .Any(mi => mi.GetParameters().FirstOrDefault()?.ParameterType == baseType);

        public static bool IsPsSimple(this Type type) =>
            type.IsSimple()
            || type == typeof(SwitchParameter)
            || type == typeof(Hashtable)
            || type == typeof(PSCredential)
            || type.HasImplicitConversion(typeof(string))
            || (type.IsArray && type.GetElementType().IsPsSimple());
    }
}
