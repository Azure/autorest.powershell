// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>AzureResource(IaaS VM) Specific feature support request</summary>
    public partial class AzureVMResourceFeatureSupportRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMResourceFeatureSupportRequest,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAzureVMResourceFeatureSupportRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequest"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequest __featureSupportRequest = new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.FeatureSupportRequest();

        /// <summary>backup support feature type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inherited)]
        public string FeatureType { get => "AzureVMResourceBackup"; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequestInternal)__featureSupportRequest).FeatureType = "AzureVMResourceBackup"; }

        /// <summary>Backing field for <see cref="VMSize" /> property.</summary>
        private string _vMSize;

        /// <summary>Size of the resource: VM size(A/D series etc) in case of IaasVM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string VMSize { get => this._vMSize; set => this._vMSize = value; }

        /// <summary>Backing field for <see cref="VMSku" /> property.</summary>
        private string _vMSku;

        /// <summary>SKUs (Premium/Managed etc) in case of IaasVM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string VMSku { get => this._vMSku; set => this._vMSku = value; }

        /// <summary>Creates an new <see cref="AzureVMResourceFeatureSupportRequest" /> instance.</summary>
        public AzureVMResourceFeatureSupportRequest()
        {
            this.__featureSupportRequest.FeatureType = "AzureVMResourceBackup";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__featureSupportRequest), __featureSupportRequest);
            await eventListener.AssertObjectIsValid(nameof(__featureSupportRequest), __featureSupportRequest);
        }
    }
    /// AzureResource(IaaS VM) Specific feature support request
    public partial interface IAzureVMResourceFeatureSupportRequest :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequest
    {
        /// <summary>Size of the resource: VM size(A/D series etc) in case of IaasVM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Size of the resource: VM size(A/D series etc) in case of IaasVM",
        SerializedName = @"vmSize",
        PossibleTypes = new [] { typeof(string) })]
        string VMSize { get; set; }
        /// <summary>SKUs (Premium/Managed etc) in case of IaasVM</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SKUs (Premium/Managed etc) in case of IaasVM",
        SerializedName = @"vmSku",
        PossibleTypes = new [] { typeof(string) })]
        string VMSku { get; set; }

    }
    /// AzureResource(IaaS VM) Specific feature support request
    internal partial interface IAzureVMResourceFeatureSupportRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IFeatureSupportRequestInternal
    {
        /// <summary>Size of the resource: VM size(A/D series etc) in case of IaasVM</summary>
        string VMSize { get; set; }
        /// <summary>SKUs (Premium/Managed etc) in case of IaasVM</summary>
        string VMSku { get; set; }

    }
}