// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. For a
    /// list of supported Linux distributions, see [Linux on Azure-Endorsed
    /// Distributions](https://docs.microsoft.com/azure/virtual-machines/linux/endorsed-distros).
    /// </summary>
    public partial class LinuxConfiguration
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ILinuxConfiguration FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json ? new LinuxConfiguration(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject into a new instance of <see cref="LinuxConfiguration" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LinuxConfiguration(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_ssh = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("ssh"), out var __jsonSsh) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.SshConfiguration.FromJson(__jsonSsh) : _ssh;}
            {_patchSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("patchSettings"), out var __jsonPatchSettings) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxPatchSettings.FromJson(__jsonPatchSettings) : _patchSetting;}
            {_disablePasswordAuthentication = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean>("disablePasswordAuthentication"), out var __jsonDisablePasswordAuthentication) ? (bool?)__jsonDisablePasswordAuthentication : _disablePasswordAuthentication;}
            {_provisionVMAgent = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean>("provisionVMAgent"), out var __jsonProvisionVMAgent) ? (bool?)__jsonProvisionVMAgent : _provisionVMAgent;}
            {_enableVMAgentPlatformUpdate = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean>("enableVMAgentPlatformUpdates"), out var __jsonEnableVMAgentPlatformUpdates) ? (bool?)__jsonEnableVMAgentPlatformUpdates : _enableVMAgentPlatformUpdate;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LinuxConfiguration" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LinuxConfiguration" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._ssh ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._ssh.ToJson(null,serializationMode) : null, "ssh" ,container.Add );
            AddIf( null != this._patchSetting ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._patchSetting.ToJson(null,serializationMode) : null, "patchSettings" ,container.Add );
            AddIf( null != this._disablePasswordAuthentication ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean((bool)this._disablePasswordAuthentication) : null, "disablePasswordAuthentication" ,container.Add );
            AddIf( null != this._provisionVMAgent ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean((bool)this._provisionVMAgent) : null, "provisionVMAgent" ,container.Add );
            AddIf( null != this._enableVMAgentPlatformUpdate ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean((bool)this._enableVMAgentPlatformUpdate) : null, "enableVMAgentPlatformUpdates" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}