// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>User Info of Informatica Organization resource.</summary>
    public partial class UserDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IUserDetailsInternal
    {

        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private string _emailAddress;

        /// <summary>User email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string EmailAddress { get => this._emailAddress; set => this._emailAddress = value; }

        /// <summary>Backing field for <see cref="FirstName" /> property.</summary>
        private string _firstName;

        /// <summary>User first name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string FirstName { get => this._firstName; set => this._firstName = value; }

        /// <summary>Backing field for <see cref="LastName" /> property.</summary>
        private string _lastName;

        /// <summary>User last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string LastName { get => this._lastName; set => this._lastName = value; }

        /// <summary>Backing field for <see cref="PhoneNumber" /> property.</summary>
        private string _phoneNumber;

        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string PhoneNumber { get => this._phoneNumber; set => this._phoneNumber = value; }

        /// <summary>Backing field for <see cref="Upn" /> property.</summary>
        private string _upn;

        /// <summary>UPN of user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Upn { get => this._upn; set => this._upn = value; }

        /// <summary>Creates an new <see cref="UserDetails" /> instance.</summary>
        public UserDetails()
        {

        }
    }
    /// User Info of Informatica Organization resource.
    public partial interface IUserDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>User email address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User email address.",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EmailAddress { get; set; }
        /// <summary>User first name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User first name.",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string FirstName { get; set; }
        /// <summary>User last name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User last name.",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string LastName { get; set; }
        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Phone number of the user used by for contacting them if needed",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        string PhoneNumber { get; set; }
        /// <summary>UPN of user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"UPN of user",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        string Upn { get; set; }

    }
    /// User Info of Informatica Organization resource.
    internal partial interface IUserDetailsInternal

    {
        /// <summary>User email address.</summary>
        string EmailAddress { get; set; }
        /// <summary>User first name.</summary>
        string FirstName { get; set; }
        /// <summary>User last name.</summary>
        string LastName { get; set; }
        /// <summary>Phone number of the user used by for contacting them if needed</summary>
        string PhoneNumber { get; set; }
        /// <summary>UPN of user</summary>
        string Upn { get; set; }

    }
}