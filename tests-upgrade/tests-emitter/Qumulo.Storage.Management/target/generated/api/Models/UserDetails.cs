// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    /// <summary>User Details of Qumulo FileSystem resource</summary>
    public partial class UserDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IUserDetailsInternal
    {

        /// <summary>Backing field for <see cref="Email" /> property.</summary>
        private string _email;

        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string Email { get => this._email; set => this._email = value; }

        /// <summary>Creates an new <see cref="UserDetails" /> instance.</summary>
        public UserDetails()
        {

        }
    }
    /// User Details of Qumulo FileSystem resource
    public partial interface IUserDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IJsonSerializable
    {
        /// <summary>User Email</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User Email",
        SerializedName = @"email",
        PossibleTypes = new [] { typeof(string) })]
        string Email { get; set; }

    }
    /// User Details of Qumulo FileSystem resource
    internal partial interface IUserDetailsInternal

    {
        /// <summary>User Email</summary>
        string Email { get; set; }

    }
}