// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Extensions;

    /// <summary>
    /// The active state empowers the server with the ability to forcefully terminate
    /// and halt any existing processes that may be running on the server
    /// </summary>
    public partial class ForceState :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IForceState,
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Models.IForceStateInternal
    {

        /// <summary>Backing field for <see cref="ForceState1" /> property.</summary>
        private string _forceState1;

        /// <summary>Whether to force restart by shutting all processes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PropertyOrigin.Owned)]
        public string ForceState1 { get => this._forceState1; set => this._forceState1 = value; }

        /// <summary>Creates an new <see cref="ForceState" /> instance.</summary>
        public ForceState()
        {

        }
    }
    /// The active state empowers the server with the ability to forcefully terminate
    /// and halt any existing processes that may be running on the server
    public partial interface IForceState :
        Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.IJsonSerializable
    {
        /// <summary>Whether to force restart by shutting all processes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to force restart by shutting all processes.",
        SerializedName = @"forceState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("active", "inactive")]
        string ForceState1 { get; set; }

    }
    /// The active state empowers the server with the ability to forcefully terminate
    /// and halt any existing processes that may be running on the server
    internal partial interface IForceStateInternal

    {
        /// <summary>Whether to force restart by shutting all processes.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.AzureLargeInstance.PSArgumentCompleterAttribute("active", "inactive")]
        string ForceState1 { get; set; }

    }
}