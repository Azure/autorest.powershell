// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    public partial class DiskVolumeConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>
    {
        protected global::System.Collections.Generic.Dictionary<global::System.String,Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration> __additionalProperties = new global::System.Collections.Generic.Dictionary<global::System.String,Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>();

        global::System.Collections.Generic.IDictionary<global::System.String,Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>.AdditionalProperties { get => __additionalProperties; }

        int Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>.Count { get => __additionalProperties.Count; }

        global::System.Collections.Generic.IEnumerable<global::System.String> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>.Keys { get => __additionalProperties.Keys; }

        global::System.Collections.Generic.IEnumerable<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration> Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>.Values { get => __additionalProperties.Values; }

        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration this[global::System.String index] { get => __additionalProperties[index]; set => __additionalProperties[index] = value; }

        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(global::System.String key, Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration value) => __additionalProperties.Add( key, value);

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
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>( property.Value));
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
                        this.__additionalProperties.Add(property.Key.ToString(), global::System.Management.Automation.LanguagePrimitives.ConvertTo<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>( property.Value));
                    }
                }
            }
        }

        /// <param name="key"></param>
        public bool Remove(global::System.String key) => __additionalProperties.Remove( key);

        /// <param name="key"></param>
        /// <param name="value"></param>
        public bool TryGetValue(global::System.String key, out Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration value) => __additionalProperties.TryGetValue( key, out value);

        /// <param name="source"></param>

        public static implicit operator global::System.Collections.Generic.Dictionary<global::System.String,Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDiskVolumeConfiguration>(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.DiskVolumeConfigurations source) => source.__additionalProperties;
    }
}