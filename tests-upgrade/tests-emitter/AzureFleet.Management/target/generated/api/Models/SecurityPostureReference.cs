// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>
    /// Specifies the security posture to be used for all virtual machines in the scale
    /// set. Minimum api-version: 2023-03-01
    /// </summary>
    public partial class SecurityPostureReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityPostureReference,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISecurityPostureReferenceInternal
    {

        /// <summary>Backing field for <see cref="ExcludeExtension" /> property.</summary>
        private System.Collections.Generic.List<string> _excludeExtension;

        /// <summary>
        /// List of virtual machine extension names to exclude when applying the security
        /// posture.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ExcludeExtension { get => this._excludeExtension; set => this._excludeExtension = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>
        /// The security posture reference id in the form of
        /// /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="IsOverridable" /> property.</summary>
        private bool? _isOverridable;

        /// <summary>Whether the security posture can be overridden by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.PropertyOrigin.Owned)]
        public bool? IsOverridable { get => this._isOverridable; set => this._isOverridable = value; }

        /// <summary>Creates an new <see cref="SecurityPostureReference" /> instance.</summary>
        public SecurityPostureReference()
        {

        }
    }
    /// Specifies the security posture to be used for all virtual machines in the scale
    /// set. Minimum api-version: 2023-03-01
    public partial interface ISecurityPostureReference :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable
    {
        /// <summary>
        /// List of virtual machine extension names to exclude when applying the security
        /// posture.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of virtual machine extension names to exclude when applying the security
        posture.",
        SerializedName = @"excludeExtensions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ExcludeExtension { get; set; }
        /// <summary>
        /// The security posture reference id in the form of
        /// /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The security posture reference id in the form of
        /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Whether the security posture can be overridden by the user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether the security posture can be overridden by the user.",
        SerializedName = @"isOverridable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsOverridable { get; set; }

    }
    /// Specifies the security posture to be used for all virtual machines in the scale
    /// set. Minimum api-version: 2023-03-01
    internal partial interface ISecurityPostureReferenceInternal

    {
        /// <summary>
        /// List of virtual machine extension names to exclude when applying the security
        /// posture.
        /// </summary>
        System.Collections.Generic.List<string> ExcludeExtension { get; set; }
        /// <summary>
        /// The security posture reference id in the form of
        /// /CommunityGalleries/{communityGalleryName}/securityPostures/{securityPostureName}/versions/{major.minor.patch}|{major.*}|latest
        /// </summary>
        string Id { get; set; }
        /// <summary>Whether the security posture can be overridden by the user.</summary>
        bool? IsOverridable { get; set; }

    }
}