// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>Start SAP instance(s) request body.</summary>
    public partial class StartRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStartRequest,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IStartRequestInternal
    {

        /// <summary>Backing field for <see cref="StartVM" /> property.</summary>
        private bool? _startVM;

        /// <summary>
        /// The boolean value indicates whether to start the virtual machines before starting the SAP instances.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public bool? StartVM { get => this._startVM; set => this._startVM = value; }

        /// <summary>Creates an new <see cref="StartRequest" /> instance.</summary>
        public StartRequest()
        {

        }
    }
    /// Start SAP instance(s) request body.
    public partial interface IStartRequest :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The boolean value indicates whether to start the virtual machines before starting the SAP instances.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The boolean value indicates whether to start the virtual machines before starting the SAP instances.",
        SerializedName = @"startVm",
        PossibleTypes = new [] { typeof(bool) })]
        bool? StartVM { get; set; }

    }
    /// Start SAP instance(s) request body.
    internal partial interface IStartRequestInternal

    {
        /// <summary>
        /// The boolean value indicates whether to start the virtual machines before starting the SAP instances.
        /// </summary>
        bool? StartVM { get; set; }

    }
}