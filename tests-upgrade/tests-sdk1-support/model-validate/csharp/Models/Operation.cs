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
    using System.Linq;

    /// <summary>
    /// Information about workspace.
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="typeString">This is string</param>
        /// <param name="typeInteger">This is integer</param>
        /// <param name="typeArray">This is array</param>
        /// <param name="typeAny">This is any.</param>
        /// <param name="typeDictionary">This is dictionary.</param>
        /// <param name="typeObject">This is object</param>
        /// <param name="typeTime">This is string</param>
        /// <param name="typeCredential">This is password</param>
        /// <param name="typeBinary">This is binary</param>
        /// <param name="typeDuration">This is duration</param>
        /// <param name="typeUri">This is uri</param>
        /// <param name="typeUuid">This is uuid</param>
        /// <param name="typeDateTime">This is date-time</param>
        /// <param name="typeDate">This is date</param>
        /// <param name="typeByteArray">This is byte array</param>
        /// <param name="typeBoolean">This is boolean</param>
        /// <param name="typeNumber">This is number</param>
        /// <param name="typeNumber32">This is number</param>
        /// <param name="typeNumber64">This is number</param>
        /// <param name="typeNumber128">This is number</param>
        /// <param name="typeConstant">This is constant. Possible values
        /// include: 'const'</param>
        /// <param name="typeChoice">This is choice. Possible values include:
        /// 'choice1', 'choice2'</param>
        /// <param name="typeSealedChoice">This is sealed choice. Possible
        /// values include: 'sealedchoice1', 'sealedchoice2'</param>
        public Operation(string typeString, int typeInteger, System.Collections.Generic.IList<string> typeArray, object typeAny = default(object), System.Collections.Generic.IDictionary<string, string> typeDictionary = default(System.Collections.Generic.IDictionary<string, string>), OperationTypeObject typeObject = default(OperationTypeObject), System.DateTime? typeTime = default(System.DateTime?), string typeCredential = default(string), byte[] typeBinary = default(byte[]), System.TimeSpan? typeDuration = default(System.TimeSpan?), string typeUri = default(string), System.Guid? typeUuid = default(System.Guid?), System.DateTime? typeDateTime = default(System.DateTime?), System.DateTime? typeDate = default(System.DateTime?), byte[] typeByteArray = default(byte[]), bool? typeBoolean = default(bool?), double? typeNumber = default(double?), double? typeNumber32 = default(double?), double? typeNumber64 = default(double?), decimal? typeNumber128 = default(decimal?), string typeConstant = default(string), string typeChoice = default(string), string typeSealedChoice = default(string))
        {
            this.TypeAny = typeAny;
            this.TypeDictionary = typeDictionary;
            this.TypeObject = typeObject;
            this.TypeTime = typeTime;
            this.TypeString = typeString;
            this.TypeCredential = typeCredential;
            this.TypeBinary = typeBinary;
            this.TypeDuration = typeDuration;
            this.TypeUri = typeUri;
            this.TypeUuid = typeUuid;
            this.TypeDateTime = typeDateTime;
            this.TypeDate = typeDate;
            this.TypeByteArray = typeByteArray;
            this.TypeBoolean = typeBoolean;
            this.TypeInteger = typeInteger;
            this.TypeNumber = typeNumber;
            this.TypeNumber32 = typeNumber32;
            this.TypeNumber64 = typeNumber64;
            this.TypeNumber128 = typeNumber128;
            this.TypeConstant = typeConstant;
            this.TypeChoice = typeChoice;
            this.TypeSealedChoice = typeSealedChoice;
            this.TypeArray = typeArray;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this is any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeAny")]
        public object TypeAny { get; set; }

        /// <summary>
        /// Gets or sets this is dictionary.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeDictionary")]
        public System.Collections.Generic.IDictionary<string, string> TypeDictionary { get; set; }

        /// <summary>
        /// Gets or sets this is object
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeObject")]
        public OperationTypeObject TypeObject { get; set; }

        /// <summary>
        /// Gets or sets this is string
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.UnixTimeJsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeTime")]
        public System.DateTime? TypeTime { get; set; }

        /// <summary>
        /// Gets or sets this is string
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeString")]
        public string TypeString { get; set; }

        /// <summary>
        /// Gets or sets this is password
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeCredential")]
        public string TypeCredential { get; set; }

        /// <summary>
        /// Gets or sets this is binary
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeBinary")]
        public byte[] TypeBinary { get; set; }

        /// <summary>
        /// Gets or sets this is duration
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeDuration")]
        public System.TimeSpan? TypeDuration { get; set; }

        /// <summary>
        /// Gets or sets this is uri
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeUri")]
        public string TypeUri { get; set; }

        /// <summary>
        /// Gets or sets this is uuid
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeUuid")]
        public System.Guid? TypeUuid { get; set; }

        /// <summary>
        /// Gets or sets this is date-time
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeDateTime")]
        public System.DateTime? TypeDateTime { get; set; }

        /// <summary>
        /// Gets or sets this is date
        /// </summary>
        [Newtonsoft.Json.JsonConverter(typeof(Microsoft.Rest.Serialization.DateJsonConverter))]
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeDate")]
        public System.DateTime? TypeDate { get; set; }

        /// <summary>
        /// Gets or sets this is byte array
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeByteArray")]
        public byte[] TypeByteArray { get; set; }

        /// <summary>
        /// Gets or sets this is boolean
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeBoolean")]
        public bool? TypeBoolean { get; set; }

        /// <summary>
        /// Gets or sets this is integer
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeInteger")]
        public int TypeInteger { get; set; }

        /// <summary>
        /// Gets or sets this is number
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeNumber")]
        public double? TypeNumber { get; set; }

        /// <summary>
        /// Gets or sets this is number
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeNumber32")]
        public double? TypeNumber32 { get; set; }

        /// <summary>
        /// Gets or sets this is number
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeNumber64")]
        public double? TypeNumber64 { get; set; }

        /// <summary>
        /// Gets or sets this is number
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeNumber128")]
        public decimal? TypeNumber128 { get; set; }

        /// <summary>
        /// Gets or sets this is constant. Possible values include: 'const'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeConstant")]
        public string TypeConstant { get; set; }

        /// <summary>
        /// Gets or sets this is choice. Possible values include: 'choice1',
        /// 'choice2'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeChoice")]
        public string TypeChoice { get; set; }

        /// <summary>
        /// Gets or sets this is sealed choice. Possible values include:
        /// 'sealedchoice1', 'sealedchoice2'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeSealedChoice")]
        public string TypeSealedChoice { get; set; }

        /// <summary>
        /// Gets or sets this is array
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeArray")]
        public System.Collections.Generic.IList<string> TypeArray { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.TypeString == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TypeString");
            }
            if (this.TypeArray == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TypeArray");
            }
            if (this.TypeInteger >= 100)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.ExclusiveMaximum, "TypeInteger", 100);
            }
            if (this.TypeInteger < 10)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "TypeInteger", 10);
            }
            if (this.TypeArray != null)
            {
                if (this.TypeArray.Count > 10)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.MaxItems, "TypeArray", 10);
                }
            }
        }
    }
}
