// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes the base virtual machine profile for fleet</summary>
    public partial class BaseVirtualMachineProfile
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject into a new instance of <see cref="BaseVirtualMachineProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BaseVirtualMachineProfile(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_networkProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("networkProfile"), out var __jsonNetworkProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetNetworkProfile.FromJson(__jsonNetworkProfile) : _networkProfile;}
            {_securityProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("securityProfile"), out var __jsonSecurityProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SecurityProfile.FromJson(__jsonSecurityProfile) : _securityProfile;}
            {_diagnosticsProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("diagnosticsProfile"), out var __jsonDiagnosticsProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.DiagnosticsProfile.FromJson(__jsonDiagnosticsProfile) : _diagnosticsProfile;}
            {_extensionProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("extensionProfile"), out var __jsonExtensionProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetExtensionProfile.FromJson(__jsonExtensionProfile) : _extensionProfile;}
            {_scheduledEventsProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("scheduledEventsProfile"), out var __jsonScheduledEventsProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ScheduledEventsProfile.FromJson(__jsonScheduledEventsProfile) : _scheduledEventsProfile;}
            {_capacityReservation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("capacityReservation"), out var __jsonCapacityReservation) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.CapacityReservationProfile.FromJson(__jsonCapacityReservation) : _capacityReservation;}
            {_applicationProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("applicationProfile"), out var __jsonApplicationProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ApplicationProfile.FromJson(__jsonApplicationProfile) : _applicationProfile;}
            {_hardwareProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("hardwareProfile"), out var __jsonHardwareProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetHardwareProfile.FromJson(__jsonHardwareProfile) : _hardwareProfile;}
            {_serviceArtifactReference = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("serviceArtifactReference"), out var __jsonServiceArtifactReference) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ServiceArtifactReference.FromJson(__jsonServiceArtifactReference) : _serviceArtifactReference;}
            {_securityPostureReference = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("securityPostureReference"), out var __jsonSecurityPostureReference) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SecurityPostureReference.FromJson(__jsonSecurityPostureReference) : _securityPostureReference;}
            {_licenseType = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("licenseType"), out var __jsonLicenseType) ? (string)__jsonLicenseType : (string)_licenseType;}
            {_userData = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("userData"), out var __jsonUserData) ? (string)__jsonUserData : (string)_userData;}
            {_timeCreated = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("timeCreated"), out var __jsonTimeCreated) ? global::System.DateTime.TryParse((string)__jsonTimeCreated, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonTimeCreatedValue) ? __jsonTimeCreatedValue : _timeCreated : _timeCreated;}
            {_oSProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("osProfile"), out var __jsonOSProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetOSProfile.FromJson(__jsonOSProfile) : _oSProfile;}
            {_storageProfile = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("storageProfile"), out var __jsonStorageProfile) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VirtualMachineScaleSetStorageProfile.FromJson(__jsonStorageProfile) : _storageProfile;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IBaseVirtualMachineProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json ? new BaseVirtualMachineProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BaseVirtualMachineProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BaseVirtualMachineProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._networkProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._networkProfile.ToJson(null,serializationMode) : null, "networkProfile" ,container.Add );
            AddIf( null != this._securityProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._securityProfile.ToJson(null,serializationMode) : null, "securityProfile" ,container.Add );
            AddIf( null != this._diagnosticsProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._diagnosticsProfile.ToJson(null,serializationMode) : null, "diagnosticsProfile" ,container.Add );
            AddIf( null != this._extensionProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._extensionProfile.ToJson(null,serializationMode) : null, "extensionProfile" ,container.Add );
            AddIf( null != this._scheduledEventsProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._scheduledEventsProfile.ToJson(null,serializationMode) : null, "scheduledEventsProfile" ,container.Add );
            AddIf( null != this._capacityReservation ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._capacityReservation.ToJson(null,serializationMode) : null, "capacityReservation" ,container.Add );
            AddIf( null != this._applicationProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._applicationProfile.ToJson(null,serializationMode) : null, "applicationProfile" ,container.Add );
            AddIf( null != this._hardwareProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._hardwareProfile.ToJson(null,serializationMode) : null, "hardwareProfile" ,container.Add );
            AddIf( null != this._serviceArtifactReference ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._serviceArtifactReference.ToJson(null,serializationMode) : null, "serviceArtifactReference" ,container.Add );
            AddIf( null != this._securityPostureReference ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._securityPostureReference.ToJson(null,serializationMode) : null, "securityPostureReference" ,container.Add );
            AddIf( null != (((object)this._licenseType)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._licenseType.ToString()) : null, "licenseType" ,container.Add );
            AddIf( null != (((object)this._userData)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._userData.ToString()) : null, "userData" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._timeCreated ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._timeCreated?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "timeCreated" ,container.Add );
            }
            AddIf( null != this._oSProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._oSProfile.ToJson(null,serializationMode) : null, "osProfile" ,container.Add );
            AddIf( null != this._storageProfile ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._storageProfile.ToJson(null,serializationMode) : null, "storageProfile" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}