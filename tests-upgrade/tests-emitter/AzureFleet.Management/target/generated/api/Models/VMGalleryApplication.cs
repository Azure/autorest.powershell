// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the required information to reference a compute gallery application
    /// version
    /// </summary>
    public partial class VMGalleryApplication :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplication,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.IVMGalleryApplicationInternal
    {

        /// <summary>Backing field for <see cref="ConfigurationReference" /> property.</summary>
        private string _configurationReference;

        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default
        /// configuration for the package if provided
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string ConfigurationReference { get => this._configurationReference; set => this._configurationReference = value; }

        /// <summary>Backing field for <see cref="EnableAutomaticUpgrade" /> property.</summary>
        private bool? _enableAutomaticUpgrade;

        /// <summary>
        /// If set to true, when a new Gallery Application version is available in PIR/SIG,
        /// it will be automatically updated for the VM/VMSS
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? EnableAutomaticUpgrade { get => this._enableAutomaticUpgrade; set => this._enableAutomaticUpgrade = value; }

        /// <summary>Backing field for <see cref="Order" /> property.</summary>
        private int? _order;

        /// <summary>Optional, Specifies the order in which the packages have to be installed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public int? Order { get => this._order; set => this._order = value; }

        /// <summary>Backing field for <see cref="PackageReferenceId" /> property.</summary>
        private string _packageReferenceId;

        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string PackageReferenceId { get => this._packageReferenceId; set => this._packageReferenceId = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string _tag;

        /// <summary>Optional, Specifies a passthrough value for more generic context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Backing field for <see cref="TreatFailureAsDeploymentFailure" /> property.</summary>
        private bool? _treatFailureAsDeploymentFailure;

        /// <summary>
        /// Optional, If true, any failure for any operation in the VmApplication will fail
        /// the deployment
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? TreatFailureAsDeploymentFailure { get => this._treatFailureAsDeploymentFailure; set => this._treatFailureAsDeploymentFailure = value; }

        /// <summary>Creates an new <see cref="VMGalleryApplication" /> instance.</summary>
        public VMGalleryApplication()
        {

        }
    }
    /// Specifies the required information to reference a compute gallery application
    /// version
    public partial interface IVMGalleryApplication :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default
        /// configuration for the package if provided
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, Specifies the uri to an azure blob that will replace the default
        configuration for the package if provided",
        SerializedName = @"configurationReference",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationReference { get; set; }
        /// <summary>
        /// If set to true, when a new Gallery Application version is available in PIR/SIG,
        /// it will be automatically updated for the VM/VMSS
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If set to true, when a new Gallery Application version is available in PIR/SIG,
        it will be automatically updated for the VM/VMSS",
        SerializedName = @"enableAutomaticUpgrade",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>Optional, Specifies the order in which the packages have to be installed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, Specifies the order in which the packages have to be installed",
        SerializedName = @"order",
        PossibleTypes = new [] { typeof(int) })]
        int? Order { get; set; }
        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the GalleryApplicationVersion resource id on the form of
        /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}",
        SerializedName = @"packageReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string PackageReferenceId { get; set; }
        /// <summary>Optional, Specifies a passthrough value for more generic context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, Specifies a passthrough value for more generic context.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string Tag { get; set; }
        /// <summary>
        /// Optional, If true, any failure for any operation in the VmApplication will fail
        /// the deployment
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Optional, If true, any failure for any operation in the VmApplication will fail
        the deployment",
        SerializedName = @"treatFailureAsDeploymentFailure",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TreatFailureAsDeploymentFailure { get; set; }

    }
    /// Specifies the required information to reference a compute gallery application
    /// version
    internal partial interface IVMGalleryApplicationInternal

    {
        /// <summary>
        /// Optional, Specifies the uri to an azure blob that will replace the default
        /// configuration for the package if provided
        /// </summary>
        string ConfigurationReference { get; set; }
        /// <summary>
        /// If set to true, when a new Gallery Application version is available in PIR/SIG,
        /// it will be automatically updated for the VM/VMSS
        /// </summary>
        bool? EnableAutomaticUpgrade { get; set; }
        /// <summary>Optional, Specifies the order in which the packages have to be installed</summary>
        int? Order { get; set; }
        /// <summary>
        /// Specifies the GalleryApplicationVersion resource id on the form of
        /// /subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Compute/galleries/{galleryName}/applications/{application}/versions/{version}
        /// </summary>
        string PackageReferenceId { get; set; }
        /// <summary>Optional, Specifies a passthrough value for more generic context.</summary>
        string Tag { get; set; }
        /// <summary>
        /// Optional, If true, any failure for any operation in the VmApplication will fail
        /// the deployment
        /// </summary>
        bool? TreatFailureAsDeploymentFailure { get; set; }

    }
}