// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Details of the ImageVersionProperties.</summary>
    public partial class ImageVersionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IImageVersionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ImageVersionProperties" /> instance.</summary>
        public ImageVersionProperties()
        {

        }
    }
    /// Details of the ImageVersionProperties.
    public partial interface IImageVersionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>Version of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Version of the image.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Details of the ImageVersionProperties.
    internal partial interface IImageVersionPropertiesInternal

    {
        /// <summary>Version of the image.</summary>
        string Version { get; set; }

    }
}