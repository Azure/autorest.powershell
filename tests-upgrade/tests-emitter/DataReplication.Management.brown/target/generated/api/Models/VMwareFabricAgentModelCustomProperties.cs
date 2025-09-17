// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>VMware fabric agent model custom properties.</summary>
    public partial class VMwareFabricAgentModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareFabricAgentModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareFabricAgentModelCustomPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomProperties __fabricAgentModelCustomProperties = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.FabricAgentModelCustomProperties();

        /// <summary>Backing field for <see cref="BiosId" /> property.</summary>
        private string _biosId;

        /// <summary>Gets or sets the BIOS Id of the fabric agent machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string BiosId { get => this._biosId; set => this._biosId = value; }

        /// <summary>Discriminator property for FabricAgentModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inherited)]
        public string InstanceType { get => "VMware"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomPropertiesInternal)__fabricAgentModelCustomProperties).InstanceType = "VMware"; }

        /// <summary>
        /// Gets or sets the authority of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityAadAuthority { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).AadAuthority; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).AadAuthority = value ; }

        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).ApplicationId = value ; }

        /// <summary>
        /// Gets or sets the audience of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityAudience { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).Audience; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).Audience = value ; }

        /// <summary>
        /// Gets or sets the object Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).ObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).ObjectId = value ; }

        /// <summary>
        /// Gets or sets the tenant Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Inlined)]
        public string MarAuthenticationIdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModelInternal)MarsAuthenticationIdentity).TenantId = value ; }

        /// <summary>Backing field for <see cref="MarsAuthenticationIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModel _marsAuthenticationIdentity;

        /// <summary>Identity model.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModel MarsAuthenticationIdentity { get => (this._marsAuthenticationIdentity = this._marsAuthenticationIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IdentityModel()); set => this._marsAuthenticationIdentity = value; }

        /// <summary>Internal Acessors for MarsAuthenticationIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModel Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IVMwareFabricAgentModelCustomPropertiesInternal.MarsAuthenticationIdentity { get => (this._marsAuthenticationIdentity = this._marsAuthenticationIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IdentityModel()); set { {_marsAuthenticationIdentity = value;} } }

        /// <summary>Creates an new <see cref="VMwareFabricAgentModelCustomProperties" /> instance.</summary>
        public VMwareFabricAgentModelCustomProperties()
        {
            this.__fabricAgentModelCustomProperties.InstanceType = "VMware";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__fabricAgentModelCustomProperties), __fabricAgentModelCustomProperties);
            await eventListener.AssertObjectIsValid(nameof(__fabricAgentModelCustomProperties), __fabricAgentModelCustomProperties);
        }
    }
    /// VMware fabric agent model custom properties.
    public partial interface IVMwareFabricAgentModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomProperties
    {
        /// <summary>Gets or sets the BIOS Id of the fabric agent machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the BIOS Id of the fabric agent machine.",
        SerializedName = @"biosId",
        PossibleTypes = new [] { typeof(string) })]
        string BiosId { get; set; }
        /// <summary>
        /// Gets or sets the authority of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the authority of the SPN with which fabric agent communicates to service.",
        SerializedName = @"aadAuthority",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityAadAuthority { get; set; }
        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the client/application Id of the SPN with which fabric agent communicates to service.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityApplicationId { get; set; }
        /// <summary>
        /// Gets or sets the audience of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the audience of the SPN with which fabric agent communicates to service.",
        SerializedName = @"audience",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityAudience { get; set; }
        /// <summary>
        /// Gets or sets the object Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the object Id of the SPN with which fabric agent communicates to service.",
        SerializedName = @"objectId",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityObjectId { get; set; }
        /// <summary>
        /// Gets or sets the tenant Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the tenant Id of the SPN with which fabric agent communicates to service.",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string MarAuthenticationIdentityTenantId { get; set; }

    }
    /// VMware fabric agent model custom properties.
    internal partial interface IVMwareFabricAgentModelCustomPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IFabricAgentModelCustomPropertiesInternal
    {
        /// <summary>Gets or sets the BIOS Id of the fabric agent machine.</summary>
        string BiosId { get; set; }
        /// <summary>
        /// Gets or sets the authority of the SPN with which fabric agent communicates to service.
        /// </summary>
        string MarAuthenticationIdentityAadAuthority { get; set; }
        /// <summary>
        /// Gets or sets the client/application Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        string MarAuthenticationIdentityApplicationId { get; set; }
        /// <summary>
        /// Gets or sets the audience of the SPN with which fabric agent communicates to service.
        /// </summary>
        string MarAuthenticationIdentityAudience { get; set; }
        /// <summary>
        /// Gets or sets the object Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        string MarAuthenticationIdentityObjectId { get; set; }
        /// <summary>
        /// Gets or sets the tenant Id of the SPN with which fabric agent communicates to service.
        /// </summary>
        string MarAuthenticationIdentityTenantId { get; set; }
        /// <summary>Identity model.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.IIdentityModel MarsAuthenticationIdentity { get; set; }

    }
}