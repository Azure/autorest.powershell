// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>
    /// Specifies the gallery application that should be made available to the underlying VMSS.
    /// </summary>
    public partial class VMApplication :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplication,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IVMApplicationInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationReference" /> property.</summary>
        private string _configurationReference;

        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string ConfigurationReference { get => this._configurationReference; set => this._configurationReference = value; }

        /// <summary>Backing field for <see cref="EnableAutomaticUpgrade" /> property.</summary>
        private bool? _enableAutomaticUpgrade;

        /// <summary>
        /// If set to true, when a new Gallery Application version is available in PIR/SIG, it will be automatically updated for the
        /// underlying VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? EnableAutomaticUpgrade { get => this._enableAutomaticUpgrade; set => this._enableAutomaticUpgrade = value; }

        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private int? _order;

        /// <summary>Optional, Specifies the order in which the packages have to be installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int? Order { get => this._order; set => this._order = value; }

        /// <summary>Backing field for <see cref="PackageReferenceId" /> property.</summary>
        private string _packageReferenceId;

        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string PackageReferenceId { get => this._packageReferenceId; set => this._packageReferenceId = value; }

        /// <summary>Backing field for <see cref="TreatFailureAsDeploymentFailure" /> property.</summary>
        private bool? _treatFailureAsDeploymentFailure;

        /// <summary>
        /// Optional, If true, any failure for any operation in the VmApplication will fail the deployment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? TreatFailureAsDeploymentFailure { get => this._treatFailureAsDeploymentFailure; set => this._treatFailureAsDeploymentFailure = value; }

        /// <summary>Backing field for <see cref="VMGalleryTag" /> property.</summary>
        private string _vMGalleryTag;

        /// <summary>
        /// Optional, Specifies a passthrough value for more generic context. Accepts a JSON-formatted string e.g. '{"Tag1":"Value1","Tag2":"Value2"}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string VMGalleryTag { get => this._vMGalleryTag; set => this._vMGalleryTag = value; }

        /// <summary>Creates an new <see cref="VMApplication" /> instance.</summary>
        public VMApplication()
        {

        }
    }
    /// Specifies the gallery application that should be made available to the underlying VMSS.
    public partial interface IVMApplication :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided.",
        SerializedName = @"configurationReference",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationReference { get; set; }
        /// <summary>
        /// If set to true, when a new Gallery Application version is available in PIR/SIG, it will be automatically updated for the
        /// underlying VMSS.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If set to true, when a new Gallery Application version is available in PIR/SIG, it will be automatically updated for the underlying VMSS.",
        SerializedName = @"enableAutomaticUpgrade",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>Optional, Specifies the order in which the packages have to be installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, Specifies the order in which the packages have to be installed.",
        SerializedName = @"order",
        PossibleTypes = new [] { typeof(int) })]
        int? Order { get; set; }
        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}.",
        SerializedName = @"packageReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string PackageReferenceId { get; set; }
        /// <summary>
        /// Optional, If true, any failure for any operation in the VmApplication will fail the deployment.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, If true, any failure for any operation in the VmApplication will fail the deployment.",
        SerializedName = @"treatFailureAsDeploymentFailure",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TreatFailureAsDeploymentFailure { get; set; }
        /// <summary>
        /// Optional, Specifies a passthrough value for more generic context. Accepts a JSON-formatted string e.g. '{"Tag1":"Value1","Tag2":"Value2"}'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, Specifies a passthrough value for more generic context. Accepts a JSON-formatted string e.g. '{""Tag1"":""Value1"",""Tag2"":""Value2""}'.",
        SerializedName = @"vmGalleryTags",
        PossibleTypes = new [] { typeof(string) })]
        string VMGalleryTag { get; set; }

    }
    /// Specifies the gallery application that should be made available to the underlying VMSS.
    internal partial interface IVMApplicationInternal

    {
        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default configuration for the package if provided.
        /// </summary>
        string ConfigurationReference { get; set; }
        /// <summary>
        /// If set to true, when a new Gallery Application version is available in PIR/SIG, it will be automatically updated for the
        /// underlying VMSS.
        /// </summary>
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>Optional, Specifies the order in which the packages have to be installed.</summary>
        int? Order { get; set; }
        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}.
        /// </summary>
        string PackageReferenceId { get; set; }
        /// <summary>
        /// Optional, If true, any failure for any operation in the VmApplication will fail the deployment.
        /// </summary>
        bool? TreatFailureAsDeploymentFailure { get; set; }
        /// <summary>
        /// Optional, Specifies a passthrough value for more generic context. Accepts a JSON-formatted string e.g. '{"Tag1":"Value1","Tag2":"Value2"}'.
        /// </summary>
        string VMGalleryTag { get; set; }

    }
}