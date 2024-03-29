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
    /// The structure of the property that a time series id can have. An
    /// environment can have multiple such properties.
    /// </summary>
    public partial class TimeSeriesIdProperty
    {
        /// <summary>
        /// Initializes a new instance of the TimeSeriesIdProperty class.
        /// </summary>
        public TimeSeriesIdProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSeriesIdProperty class.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        /// <param name="type">The type of the property. Possible values
        /// include: 'String', '123'</param>
        public TimeSeriesIdProperty(string name = default(string), PropertyType? type = default(PropertyType?))
        {
            this.Name = name;
            this.Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type of the property. Possible values include:
        /// 'String', '123'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public PropertyType? Type { get; set; }

    }
}
