// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Input values for operation results call.</summary>
    public partial class OperationInputs :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInputs,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInputsInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the Provisioning Service to check.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="OperationInputs" /> instance.</summary>
        public OperationInputs()
        {

        }
    }
    /// Input values for operation results call.
    public partial interface IOperationInputs :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>The name of the Provisioning Service to check.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Provisioning Service to check.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Input values for operation results call.
    internal partial interface IOperationInputsInternal

    {
        /// <summary>The name of the Provisioning Service to check.</summary>
        string Name { get; set; }

    }
}