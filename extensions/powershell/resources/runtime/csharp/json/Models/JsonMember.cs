using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Carbon.Json
{
    using Converters;

    public sealed class JsonMember
    {
        private readonly TypeDetails type;

        private readonly Func<object, object> getter;
        private readonly Action<object, object> setter;

        public JsonMember(PropertyInfo property, int defaultOrder)
        {
            getter = property.GetValue;
            setter = property.SetValue;

            var dataMember = property.GetCustomAttribute<DataMemberAttribute>();

            Name = dataMember?.Name ?? property.Name;
            Order = dataMember?.Order ?? defaultOrder;
            EmitDefaultValue = dataMember?.EmitDefaultValue ?? true;

            this.type = TypeDetails.Get(property.PropertyType);

            CanRead = property.CanRead;
        }

        public JsonMember(FieldInfo field, int defaultOrder)
        {
            getter = field.GetValue;
            setter = field.SetValue;

            var dataMember = field.GetCustomAttribute<DataMemberAttribute>();

            Name = dataMember?.Name ?? field.Name;
            Order = dataMember?.Order ?? defaultOrder;
            EmitDefaultValue = dataMember?.EmitDefaultValue ?? true;

            this.type = TypeDetails.Get(field.FieldType);

            CanRead = true;
        }

        public string Name { get; }

        public int Order { get; }

        internal TypeDetails TypeDetails => type;

        public Type Type => type.NonNullType;

        public bool IsList => type.IsList;

        // Arrays, Sets, ...
        public Type ElementType => type.ElementType;

        internal IJsonConverter Converter => type.JsonConverter;

        public bool EmitDefaultValue { get; }

        public bool IsStringLike => type.IsStringLike;

        public object DefaultValue => type.DefaultValue;

        public bool CanRead { get; }

        #region Helpers

        public object GetValue(object instance) => getter(instance);

        public void SetValue(object instance, object value) => setter(instance, value);

        #endregion
    }
}