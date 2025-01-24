// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Defines the request body for updating SAP Central Instance.</summary>
    public partial class UpdateSapCentralInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapCentralInstanceRequest,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IUpdateSapCentralInstanceRequestInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags _tag;

        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.Tags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="UpdateSapCentralInstanceRequest" /> instance.</summary>
        public UpdateSapCentralInstanceRequest()
        {

        }
    }
    /// Defines the request body for updating SAP Central Instance.
    public partial interface IUpdateSapCentralInstanceRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the Resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags) })]
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags Tag { get; set; }

    }
    /// Defines the request body for updating SAP Central Instance.
    internal partial interface IUpdateSapCentralInstanceRequestInternal

    {
        /// <summary>Gets or sets the Resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ITags Tag { get; set; }

    }
}