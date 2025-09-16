// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Extensions;

    /// <summary>ExascaleDbNode action response</summary>
    public partial class DbActionResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbActionResponse,
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Models.IDbActionResponseInternal
    {

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>ExascaleDbNode provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Origin(Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Creates an new <see cref="DbActionResponse" /> instance.</summary>
        public DbActionResponse()
        {

        }
    }
    /// ExascaleDbNode action response
    public partial interface IDbActionResponse :
        Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.IJsonSerializable
    {
        /// <summary>ExascaleDbNode provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ExascaleDbNode provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning")]
        string ProvisioningState { get; set; }

    }
    /// ExascaleDbNode action response
    internal partial interface IDbActionResponseInternal

    {
        /// <summary>ExascaleDbNode provisioning state</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.OracleDatabase.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning")]
        string ProvisioningState { get; set; }

    }
}