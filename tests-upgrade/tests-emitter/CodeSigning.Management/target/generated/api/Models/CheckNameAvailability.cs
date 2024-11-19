// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Extensions;

    /// <summary>
    /// The parameters used to check the availability of the trusted signing account name.
    /// </summary>
    public partial class CheckNameAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailability,
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Models.ICheckNameAvailabilityInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Trusted signing account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Origin(Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailability" /> instance.</summary>
        public CheckNameAvailability()
        {

        }
    }
    /// The parameters used to check the availability of the trusted signing account name.
    public partial interface ICheckNameAvailability :
        Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.IJsonSerializable
    {
        /// <summary>Trusted signing account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CodeSigning.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Trusted signing account name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// The parameters used to check the availability of the trusted signing account name.
    internal partial interface ICheckNameAvailabilityInternal

    {
        /// <summary>Trusted signing account name.</summary>
        string Name { get; set; }

    }
}