// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Job Properties for update</summary>
    public partial class UpdateJobProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobProperties,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Detail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails _detail;

        /// <summary>Details of a job to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails Detail { get => (this._detail = this._detail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.UpdateJobDetails()); set => this._detail = value; }

        /// <summary>Creates an new <see cref="UpdateJobProperties" /> instance.</summary>
        public UpdateJobProperties()
        {

        }
    }
    /// Job Properties for update
    public partial interface IUpdateJobProperties :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Details of a job to be updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details of a job to be updated.",
        SerializedName = @"details",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails Detail { get; set; }

    }
    /// Job Properties for update
    internal partial interface IUpdateJobPropertiesInternal

    {
        /// <summary>Details of a job to be updated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUpdateJobDetails Detail { get; set; }

    }
}