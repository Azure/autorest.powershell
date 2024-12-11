// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.PowerShell;

    /// <summary>Specifies Scheduled Event related configurations.</summary>
    [System.ComponentModel.TypeConverter(typeof(ScheduledEventsProfileTypeConverter))]
    public partial class ScheduledEventsProfile
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ScheduledEventsProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfile DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ScheduledEventsProfile(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ScheduledEventsProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfile" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfile DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ScheduledEventsProfile(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ScheduledEventsProfile" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ScheduledEventsProfile" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfile FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ScheduledEventsProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ScheduledEventsProfile(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TerminateNotificationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile) content.GetValueForProperty("TerminateNotificationProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.TerminateNotificationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSImageNotificationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile) content.GetValueForProperty("OSImageNotificationProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.OSImageNotificationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("TerminateNotificationProfileNotBeforeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileNotBeforeTimeout = (string) content.GetValueForProperty("TerminateNotificationProfileNotBeforeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileNotBeforeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("TerminateNotificationProfileEnable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileEnable = (bool?) content.GetValueForProperty("TerminateNotificationProfileEnable",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSImageNotificationProfileNotBeforeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileNotBeforeTimeout = (string) content.GetValueForProperty("OSImageNotificationProfileNotBeforeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileNotBeforeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("OSImageNotificationProfileEnable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileEnable = (bool?) content.GetValueForProperty("OSImageNotificationProfileEnable",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ScheduledEventsProfile"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ScheduledEventsProfile(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("TerminateNotificationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ITerminateNotificationProfile) content.GetValueForProperty("TerminateNotificationProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.TerminateNotificationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("OSImageNotificationProfile"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfile = (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IOSImageNotificationProfile) content.GetValueForProperty("OSImageNotificationProfile",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfile, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.OSImageNotificationProfileTypeConverter.ConvertFrom);
            }
            if (content.Contains("TerminateNotificationProfileNotBeforeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileNotBeforeTimeout = (string) content.GetValueForProperty("TerminateNotificationProfileNotBeforeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileNotBeforeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("TerminateNotificationProfileEnable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileEnable = (bool?) content.GetValueForProperty("TerminateNotificationProfileEnable",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).TerminateNotificationProfileEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("OSImageNotificationProfileNotBeforeTimeout"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileNotBeforeTimeout = (string) content.GetValueForProperty("OSImageNotificationProfileNotBeforeTimeout",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileNotBeforeTimeout, global::System.Convert.ToString);
            }
            if (content.Contains("OSImageNotificationProfileEnable"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileEnable = (bool?) content.GetValueForProperty("OSImageNotificationProfileEnable",((Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IScheduledEventsProfileInternal)this).OSImageNotificationProfileEnable, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Specifies Scheduled Event related configurations.
    [System.ComponentModel.TypeConverter(typeof(ScheduledEventsProfileTypeConverter))]
    public partial interface IScheduledEventsProfile

    {

    }
}