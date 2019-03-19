using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace Carbon.Json
{
    using Converters;
    using Internal.Extensions;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal class TypeDetails
    {
        private readonly Type info;

        public TypeDetails(Type info)
        {
            this.info = info ?? throw new ArgumentNullException(nameof(info));
        }

        public Type NonNullType { get; set; }

        public object DefaultValue { get; set; }

        public bool IsNullable { get; set; }

        public bool IsList { get; set; }

        public bool IsStringLike { get; set; }

        public bool IsEnum => info.IsEnum;

        public bool IsArray => info.IsArray;

        public bool IsValueType => info.IsValueType;

        public Type ElementType { get; set; }

        public IJsonConverter JsonConverter { get; set; }

        #region Creation

        private static readonly ConcurrentDictionary<Type, TypeDetails> cache = new ConcurrentDictionary<Type, TypeDetails>();

        public static TypeDetails Get<T>() => Get(typeof(T));

        public static TypeDetails Get(Type type) => cache.GetOrAdd(type, Create);

        private static TypeDetails Create(Type type)
        {
            var isGenericList = !type.IsPrimitive && type.ImplementsOpenGenericInterface(typeof(IList<>));
            var isList = !type.IsPrimitive && (isGenericList || typeof(IList).IsAssignableFrom(type));

            var isNullable = type.IsNullable();

            Type elementType;

            if (type.IsArray)
            {
                elementType = type.GetElementType();
            }
            else if (isGenericList)
            {
                var iList = type.GetOpenGenericInterface(typeof(IList<>));

                elementType = iList.GetGenericArguments()[0];
            }
            else
            {
                elementType = null;
            }

            var nonNullType = isNullable ? type.GetGenericArguments()[0] : type;

            var isStringLike = false;

            IJsonConverter converter;

            var jsonConverterAttribute = type.GetCustomAttribute<JsonConverterAttribute>();

            if (jsonConverterAttribute != null)
            {
                converter = jsonConverterAttribute.Converter;
            }
            else if (nonNullType.IsEnum)
            {
                converter = new EnumConverter(nonNullType);
            }
            else if (JsonConverterFactory.Instances.TryGetValue(nonNullType, out converter))
            {
            }
            else if (StringLikeHelper.IsStringLike(nonNullType))
            {
                isStringLike = true;

                converter = new StringLikeConverter(nonNullType);
            }

            return new TypeDetails(nonNullType)
            {
                NonNullType = nonNullType,
                DefaultValue = type.IsValueType ? Activator.CreateInstance(type) : null,
                IsNullable = isNullable,
                IsList = isList,
                IsStringLike = isStringLike,
                ElementType = elementType,
                JsonConverter = converter
            };
        }

        #endregion
    }
}