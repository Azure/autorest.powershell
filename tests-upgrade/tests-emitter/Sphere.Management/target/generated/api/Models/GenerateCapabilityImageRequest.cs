// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Request of the action to create a signed device capability image</summary>
    public partial class GenerateCapabilityImageRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IGenerateCapabilityImageRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.IGenerateCapabilityImageRequestInternal
    {

        /// <summary>Backing field for <see cref="Capability" /> property.</summary>
        private System.Collections.Generic.List<string> _capability;

        /// <summary>List of capabilities to create</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Capability { get => this._capability; set => this._capability = value; }

        /// <summary>Creates an new <see cref="GenerateCapabilityImageRequest" /> instance.</summary>
        public GenerateCapabilityImageRequest()
        {

        }
    }
    /// Request of the action to create a signed device capability image
    public partial interface IGenerateCapabilityImageRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable
    {
        /// <summary>List of capabilities to create</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of capabilities to create",
        SerializedName = @"capabilities",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("ApplicationDevelopment", "FieldServicing")]
        System.Collections.Generic.List<string> Capability { get; set; }

    }
    /// Request of the action to create a signed device capability image
    internal partial interface IGenerateCapabilityImageRequestInternal

    {
        /// <summary>List of capabilities to create</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Sphere.PSArgumentCompleterAttribute("ApplicationDevelopment", "FieldServicing")]
        System.Collections.Generic.List<string> Capability { get; set; }

    }
}