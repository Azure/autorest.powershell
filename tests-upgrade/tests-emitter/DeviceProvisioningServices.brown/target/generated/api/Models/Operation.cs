// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Represents an operation.</summary>
    public partial class Operation :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperation,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplay _display;

        /// <summary>The display information for the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.OperationDisplay()); set => this._display = value; }

        /// <summary>Name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Operation; }

        /// <summary>Service provider: Microsoft Devices.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Provider; }

        /// <summary>Resource Type: ProvisioningServices.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Resource; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.OperationDisplay()); set { {_display = value;} } }

        /// <summary>Internal Acessors for DisplayOperation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInternal.DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>Internal Acessors for DisplayProvider</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInternal.DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>Internal Acessors for DisplayResource</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInternal.DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Creates an new <see cref="Operation" /> instance.</summary>
        public Operation()
        {

        }
    }
    /// Represents an operation.
    public partial interface IOperation :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>Name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Name of the operation.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get;  }
        /// <summary>Service provider: Microsoft Devices.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Service provider: Microsoft Devices.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get;  }
        /// <summary>Resource Type: ProvisioningServices.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Resource Type: ProvisioningServices.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get;  }
        /// <summary>The name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }

    }
    /// Represents an operation.
    internal partial interface IOperationInternal

    {
        /// <summary>The display information for the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.IOperationDisplay Display { get; set; }
        /// <summary>Name of the operation.</summary>
        string DisplayOperation { get; set; }
        /// <summary>Service provider: Microsoft Devices.</summary>
        string DisplayProvider { get; set; }
        /// <summary>Resource Type: ProvisioningServices.</summary>
        string DisplayResource { get; set; }
        /// <summary>The name of the operation.</summary>
        string Name { get; set; }

    }
}