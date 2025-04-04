// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Describes a virtual machine scale set OS profile.</summary>
    public partial class VirtualMachineScaleSetOSProfile
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
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVirtualMachineScaleSetOSProfile FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json ? new VirtualMachineScaleSetOSProfile(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VirtualMachineScaleSetOSProfile" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VirtualMachineScaleSetOSProfile" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._windowsConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._windowsConfiguration.ToJson(null,serializationMode) : null, "windowsConfiguration" ,container.Add );
            AddIf( null != this._linuxConfiguration ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) this._linuxConfiguration.ToJson(null,serializationMode) : null, "linuxConfiguration" ,container.Add );
            AddIf( null != (((object)this._computerNamePrefix)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._computerNamePrefix.ToString()) : null, "computerNamePrefix" ,container.Add );
            AddIf( null != (((object)this._adminUsername)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(this._adminUsername.ToString()) : null, "adminUsername" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeUpdate)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._adminPassword)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this._adminPassword))) : null, "adminPassword" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeUpdate)||serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.SerializationMode.IncludeCreate))
            {
                AddIf( null != (((object)this._customData)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString(System.Runtime.InteropServices.Marshal.PtrToStringBSTR(System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this._customData))) : null, "customData" ,container.Add );
            }
            if (null != this._secret)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.XNodeArray();
                foreach( var __x in this._secret )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("secrets",__w);
            }
            AddIf( null != this._allowExtensionOperation ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean((bool)this._allowExtensionOperation) : null, "allowExtensionOperations" ,container.Add );
            AddIf( null != this._requireGuestProvisionSignal ? (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean((bool)this._requireGuestProvisionSignal) : null, "requireGuestProvisionSignal" ,container.Add );
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject into a new instance of <see cref="VirtualMachineScaleSetOSProfile" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VirtualMachineScaleSetOSProfile(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_windowsConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("windowsConfiguration"), out var __jsonWindowsConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.WindowsConfiguration.FromJson(__jsonWindowsConfiguration) : _windowsConfiguration;}
            {_linuxConfiguration = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonObject>("linuxConfiguration"), out var __jsonLinuxConfiguration) ? Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.LinuxConfiguration.FromJson(__jsonLinuxConfiguration) : _linuxConfiguration;}
            {_computerNamePrefix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("computerNamePrefix"), out var __jsonComputerNamePrefix) ? (string)__jsonComputerNamePrefix : (string)_computerNamePrefix;}
            {_adminUsername = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonString>("adminUsername"), out var __jsonAdminUsername) ? (string)__jsonAdminUsername : (string)_adminUsername;}
            {_secret = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray>("secrets"), out var __jsonSecrets) ? If( __jsonSecrets as Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVaultSecretGroup) (Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.VaultSecretGroup.FromJson(__u) )) ))() : null : _secret;}
            {_allowExtensionOperation = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean>("allowExtensionOperations"), out var __jsonAllowExtensionOperations) ? (bool?)__jsonAllowExtensionOperations : _allowExtensionOperation;}
            {_requireGuestProvisionSignal = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Json.JsonBoolean>("requireGuestProvisionSignal"), out var __jsonRequireGuestProvisionSignal) ? (bool?)__jsonRequireGuestProvisionSignal : _requireGuestProvisionSignal;}
            AfterFromJson(json);
        }
    }
}