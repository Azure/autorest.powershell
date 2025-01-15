// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.PowerShell;

    [System.ComponentModel.TypeConverter(typeof(AzureLargeInstanceIdentityTypeConverter))]
    public partial class AzureLargeInstanceIdentity
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AzureLargeInstanceIdentity(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("AzureLargeInstanceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeInstanceName = (string) content.GetValueForProperty("AzureLargeInstanceName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("AzureLargeStorageInstanceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeStorageInstanceName = (string) content.GetValueForProperty("AzureLargeStorageInstanceName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeStorageInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AzureLargeInstanceIdentity(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).SubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceGroupName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).ResourceGroupName, global::System.Convert.ToString);
            }
            if (content.Contains("AzureLargeInstanceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeInstanceName = (string) content.GetValueForProperty("AzureLargeInstanceName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("AzureLargeStorageInstanceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeStorageInstanceName = (string) content.GetValueForProperty("AzureLargeStorageInstanceName",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).AzureLargeStorageInstanceName, global::System.Convert.ToString);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentityInternal)this).Id, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AzureLargeInstanceIdentity(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.AzureLargeInstanceIdentity"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AzureLargeInstanceIdentity(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AzureLargeInstanceIdentity" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="AzureLargeInstanceIdentity" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IAzureLargeInstanceIdentity FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    [System.ComponentModel.TypeConverter(typeof(AzureLargeInstanceIdentityTypeConverter))]
    public partial interface IAzureLargeInstanceIdentity

    {

    }
}