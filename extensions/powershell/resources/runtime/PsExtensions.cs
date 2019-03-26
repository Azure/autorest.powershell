using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal static class PsExtensions
    {
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

        public static string ToPsList(this IEnumerable<string> items) => String.Join(", ", items.Select(i => $"'{i}'"));

        public static IEnumerable<T> RunScript<T>(this PSCmdlet cmdlet, string script) where T : class
            => PsHelpers.RunScript<T>(cmdlet.InvokeCommand, script);

        public static void RunScript(this PSCmdlet cmdlet, string script)
            => cmdlet.RunScript<PSObject>(script);

        public static IEnumerable<T> RunScript<T>(this EngineIntrinsics engineIntrinsics, string script) where T : class
            => PsHelpers.RunScript<T>(engineIntrinsics.InvokeCommand, script);

        public static void RunScript(this EngineIntrinsics engineIntrinsics, string script)
            => engineIntrinsics.RunScript<PSObject>(script);
    }
}
