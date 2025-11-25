// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Datacenter instruction for given storage location.</summary>
    public partial class DatacenterAddressInstructionResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressInstructionResponse,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressInstructionResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse __datacenterAddressResponse = new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.DatacenterAddressResponse();

        /// <summary>Backing field for <see cref="CommunicationInstruction" /> property.</summary>
        private string _communicationInstruction;

        /// <summary>Data center communication instruction</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string CommunicationInstruction { get => this._communicationInstruction; }

        /// <summary>Azure Location where the Data Center serves primarily.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DataCenterAzureLocation; }

        /// <summary>Data center address type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public string DatacenterAddressType { get => "DatacenterAddressInstruction"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DatacenterAddressType = "DatacenterAddressInstruction"; }

        /// <summary>Internal Acessors for CommunicationInstruction</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressInstructionResponseInternal.CommunicationInstruction { get => this._communicationInstruction; set { {_communicationInstruction = value;} } }

        /// <summary>Internal Acessors for DataCenterAzureLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal.DataCenterAzureLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DataCenterAzureLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).DataCenterAzureLocation = value ?? null; }

        /// <summary>Internal Acessors for SupportedCarriersForReturnShipment</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal.SupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).SupportedCarriersForReturnShipment; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).SupportedCarriersForReturnShipment = value ?? null /* arrayOf */; }

        /// <summary>List of supported carriers for return shipment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> SupportedCarriersForReturnShipment { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal)__datacenterAddressResponse).SupportedCarriersForReturnShipment; }

        /// <summary>Creates an new <see cref="DatacenterAddressInstructionResponse" /> instance.</summary>
        public DatacenterAddressInstructionResponse()
        {
            this.__datacenterAddressResponse.DatacenterAddressType = "DatacenterAddressInstruction";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__datacenterAddressResponse), __datacenterAddressResponse);
            await eventListener.AssertObjectIsValid(nameof(__datacenterAddressResponse), __datacenterAddressResponse);
        }
    }
    /// Datacenter instruction for given storage location.
    public partial interface IDatacenterAddressInstructionResponse :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponse
    {
        /// <summary>Data center communication instruction</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Data center communication instruction",
        SerializedName = @"communicationInstruction",
        PossibleTypes = new [] { typeof(string) })]
        string CommunicationInstruction { get;  }

    }
    /// Datacenter instruction for given storage location.
    internal partial interface IDatacenterAddressInstructionResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IDatacenterAddressResponseInternal
    {
        /// <summary>Data center communication instruction</summary>
        string CommunicationInstruction { get; set; }

    }
}