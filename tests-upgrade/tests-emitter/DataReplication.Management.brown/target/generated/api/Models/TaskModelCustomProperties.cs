// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Extensions;

    /// <summary>Task model custom properties.</summary>
    public partial class TaskModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Models.ITaskModelCustomPropertiesInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Gets or sets the instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="TaskModelCustomProperties" /> instance.</summary>
        public TaskModelCustomProperties()
        {

        }
    }
    /// Task model custom properties.
    public partial interface ITaskModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the instance type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesDataReplication.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the instance type.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Task model custom properties.
    internal partial interface ITaskModelCustomPropertiesInternal

    {
        /// <summary>Gets or sets the instance type.</summary>
        string InstanceType { get; set; }

    }
}