// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    public partial class DataDiskNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>
    {
        protected global::System.Collections.Generic.Dictionary<global::System.String,System.Collections.Generic.List<string>> __additionalProperties = new global::System.Collections.Generic.Dictionary<global::System.String,System.Collections.Generic.List<string>>();

        global::System.Collections.Generic.IDictionary<global::System.String,System.Collections.Generic.List<string>> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>.AdditionalProperties { get => __additionalProperties; }

        int Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>.Count { get => __additionalProperties.Count; }

        global::System.Collections.Generic.IEnumerable<global::System.String> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>.Keys { get => __additionalProperties.Keys; }

        global::System.Collections.Generic.IEnumerable<System.Collections.Generic.List<string>> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>.Values { get => __additionalProperties.Values; }

        public System.Collections.Generic.List<string> this[global::System.String index] { get => __additionalProperties[index]; set => __additionalProperties[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, System.Collections.Generic.List<string> value) => __additionalProperties.Add( key, value);

        public void Clear() => __additionalProperties.Clear();

        /// <param name="key"></param>
        public bool ContainsKey(global::System.String key) => __additionalProperties.ContainsKey( key);

        /// <param name="source"></param>
        public void CopyFrom(global::System.Collections.IDictionary source)
        {
            if (null != source)
            {
                foreach( var property in  Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<System.Collections.Generic.List<string>>( property.Value));
                    }
                }
            }
        }

        /// <param name="source"></param>
        public void CopyFrom(global::System.Management.Automation.PSObject source)
        {
            if (null != source)
            {
                foreach( var property in  Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.PowerShell.TypeConverterExtensions.GetFilteredProperties(source, new global::System.Collections.Generic.HashSet<global::System.String>() {  } ) )
                {
                    if ((null != property.Key && null != property.Value))
                    {
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<System.Collections.Generic.List<string>>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __additionalProperties.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out System.Collections.Generic.List<string> value) => __additionalProperties.TryGetValue( key, out value);

        /// <param name="source"></param>

        public static implicit operator global::System.Collections.Generic.Dictionary<global::System.String,System.Collections.Generic.List<string>>(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DataDiskNames source) => source.__additionalProperties;
    }
}