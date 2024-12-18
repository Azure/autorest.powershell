// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Extensions;

    /// <summary>User details for an organization</summary>
    public partial class UserDetails :
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetails,
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IUserDetailsInternal
    {

        /// <summary>Backing field for <see cref="EmailAddress" /> property.</summary>
        private string _emailAddress;

        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public string EmailAddress { get => this._emailAddress; set => this._emailAddress = value; }

        /// <summary>Backing field for <see cref="FirstName" /> property.</summary>
        private string _firstName;

        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public string FirstName { get => this._firstName; set => this._firstName = value; }

        /// <summary>Backing field for <see cref="LastName" /> property.</summary>
        private string _lastName;

        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public string LastName { get => this._lastName; set => this._lastName = value; }

        /// <summary>Backing field for <see cref="PhoneNumber" /> property.</summary>
        private string _phoneNumber;

        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public string PhoneNumber { get => this._phoneNumber; set => this._phoneNumber = value; }

        /// <summary>Backing field for <see cref="Upn" /> property.</summary>
        private string _upn;

        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public string Upn { get => this._upn; set => this._upn = value; }

        /// <summary>Creates an new <see cref="UserDetails" /> instance.</summary>
        public UserDetails()
        {

        }
    }
    /// User details for an organization
    public partial interface IUserDetails :
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.IJsonSerializable
    {
        /// <summary>Email address of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Email address of the user",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"First name of the user",
        SerializedName = @"firstName",
        PossibleTypes = new [] { typeof(string) })]
        string FirstName { get; set; }
        /// <summary>Last name of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Last name of the user",
        SerializedName = @"lastName",
        PossibleTypes = new [] { typeof(string) })]
        string LastName { get; set; }
        /// <summary>User's phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User's phone number",
        SerializedName = @"phoneNumber",
        PossibleTypes = new [] { typeof(string) })]
        string PhoneNumber { get; set; }
        /// <summary>User's principal name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User's principal name",
        SerializedName = @"upn",
        PossibleTypes = new [] { typeof(string) })]
        string Upn { get; set; }

    }
    /// User details for an organization
    internal partial interface IUserDetailsInternal

    {
        /// <summary>Email address of the user</summary>
        string EmailAddress { get; set; }
        /// <summary>First name of the user</summary>
        string FirstName { get; set; }
        /// <summary>Last name of the user</summary>
        string LastName { get; set; }
        /// <summary>User's phone number</summary>
        string PhoneNumber { get; set; }
        /// <summary>User's principal name</summary>
        string Upn { get; set; }

    }
}