// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Properties of the vault.</summary>
    public partial class VaultProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IVaultProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json ? new VaultProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="VaultProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="VaultProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._upgradeDetail ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._upgradeDetail.ToJson(null,serializationMode) : null, "upgradeDetails" ,container.Add );
            AddIf( null != this._encryption ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._encryption.ToJson(null,serializationMode) : null, "encryption" ,container.Add );
            AddIf( null != this._moveDetail ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._moveDetail.ToJson(null,serializationMode) : null, "moveDetails" ,container.Add );
            AddIf( null != this._monitoringSetting ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._monitoringSetting.ToJson(null,serializationMode) : null, "monitoringSettings" ,container.Add );
            AddIf( null != this._restoreSetting ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._restoreSetting.ToJson(null,serializationMode) : null, "restoreSettings" ,container.Add );
            AddIf( null != this._redundancySetting ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._redundancySetting.ToJson(null,serializationMode) : null, "redundancySettings" ,container.Add );
            AddIf( null != this._securitySetting ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) this._securitySetting.ToJson(null,serializationMode) : null, "securitySettings" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                if (null != this._privateEndpointConnection)
                {
                    var __w = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.XNodeArray();
                    foreach( var __x in this._privateEndpointConnection )
                    {
                        AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                    }
                    container.Add("privateEndpointConnections",__w);
                }
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._privateEndpointStateForBackup)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._privateEndpointStateForBackup.ToString()) : null, "privateEndpointStateForBackup" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._privateEndpointStateForSiteRecovery)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._privateEndpointStateForSiteRecovery.ToString()) : null, "privateEndpointStateForSiteRecovery" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._moveState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._moveState.ToString()) : null, "moveState" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._backupStorageVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._backupStorageVersion.ToString()) : null, "backupStorageVersion" ,container.Add );
            }
            AddIf( null != (((object)this._publicNetworkAccess)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._publicNetworkAccess.ToString()) : null, "publicNetworkAccess" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._secureScore)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._secureScore.ToString()) : null, "secureScore" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._bcdrSecurityLevel)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(this._bcdrSecurityLevel.ToString()) : null, "bcdrSecurityLevel" ,container.Add );
            }
            if (null != this._resourceGuardOperationRequest)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.XNodeArray();
                foreach( var __s in this._resourceGuardOperationRequest )
                {
                    AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                }
                container.Add("resourceGuardOperationRequests",__r);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject into a new instance of <see cref="VaultProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal VaultProperties(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_upgradeDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("upgradeDetails"), out var __jsonUpgradeDetails) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.UpgradeDetails.FromJson(__jsonUpgradeDetails) : _upgradeDetail;}
            {_encryption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("encryption"), out var __jsonEncryption) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesEncryption.FromJson(__jsonEncryption) : _encryption;}
            {_moveDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("moveDetails"), out var __jsonMoveDetails) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesMoveDetails.FromJson(__jsonMoveDetails) : _moveDetail;}
            {_monitoringSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("monitoringSettings"), out var __jsonMonitoringSettings) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.MonitoringSettings.FromJson(__jsonMonitoringSettings) : _monitoringSetting;}
            {_restoreSetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("restoreSettings"), out var __jsonRestoreSettings) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.RestoreSettings.FromJson(__jsonRestoreSettings) : _restoreSetting;}
            {_redundancySetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("redundancySettings"), out var __jsonRedundancySettings) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.VaultPropertiesRedundancySettings.FromJson(__jsonRedundancySettings) : _redundancySetting;}
            {_securitySetting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonObject>("securitySettings"), out var __jsonSecuritySettings) ? Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.SecuritySettings.FromJson(__jsonSecuritySettings) : _securitySetting;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_privateEndpointConnection = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonArray>("privateEndpointConnections"), out var __jsonPrivateEndpointConnections) ? If( __jsonPrivateEndpointConnections as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IPrivateEndpointConnectionVaultProperties) (Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.PrivateEndpointConnectionVaultProperties.FromJson(__u) )) ))() : null : _privateEndpointConnection;}
            {_privateEndpointStateForBackup = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("privateEndpointStateForBackup"), out var __jsonPrivateEndpointStateForBackup) ? (string)__jsonPrivateEndpointStateForBackup : (string)_privateEndpointStateForBackup;}
            {_privateEndpointStateForSiteRecovery = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("privateEndpointStateForSiteRecovery"), out var __jsonPrivateEndpointStateForSiteRecovery) ? (string)__jsonPrivateEndpointStateForSiteRecovery : (string)_privateEndpointStateForSiteRecovery;}
            {_moveState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("moveState"), out var __jsonMoveState) ? (string)__jsonMoveState : (string)_moveState;}
            {_backupStorageVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("backupStorageVersion"), out var __jsonBackupStorageVersion) ? (string)__jsonBackupStorageVersion : (string)_backupStorageVersion;}
            {_publicNetworkAccess = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("publicNetworkAccess"), out var __jsonPublicNetworkAccess) ? (string)__jsonPublicNetworkAccess : (string)_publicNetworkAccess;}
            {_secureScore = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("secureScore"), out var __jsonSecureScore) ? (string)__jsonSecureScore : (string)_secureScore;}
            {_bcdrSecurityLevel = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString>("bcdrSecurityLevel"), out var __jsonBcdrSecurityLevel) ? (string)__jsonBcdrSecurityLevel : (string)_bcdrSecurityLevel;}
            {_resourceGuardOperationRequest = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonArray>("resourceGuardOperationRequests"), out var __jsonResourceGuardOperationRequests) ? If( __jsonResourceGuardOperationRequests as Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : _resourceGuardOperationRequest;}
            AfterFromJson(json);
        }
    }
}