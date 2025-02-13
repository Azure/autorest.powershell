// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Company Details.</summary>
    public partial class CompanyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.ICompanyDetailsInternal
    {

        /// <summary>Backing field for <see cref="Business" /> property.</summary>
        private string _business;

        /// <summary>Business phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Business { get => this._business; set => this._business = value; }

        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        /// <summary>company Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string CompanyName { get => this._companyName; set => this._companyName = value; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Country name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Domain name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Backing field for <see cref="NumberOfEmployee" /> property.</summary>
        private int? _numberOfEmployee;

        /// <summary>Number Of Employees</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public int? NumberOfEmployee { get => this._numberOfEmployee; set => this._numberOfEmployee = value; }

        /// <summary>Backing field for <see cref="OfficeAddress" /> property.</summary>
        private string _officeAddress;

        /// <summary>Office Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string OfficeAddress { get => this._officeAddress; set => this._officeAddress = value; }

        /// <summary>Creates an new <see cref="CompanyDetails" /> instance.</summary>
        public CompanyDetails()
        {

        }
    }
    /// Company Details.
    public partial interface ICompanyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>Business phone number</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Business phone number",
        SerializedName = @"business",
        PossibleTypes = new [] { typeof(string) })]
        string Business { get; set; }
        /// <summary>company Name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"company Name",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>Country name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Country name",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }
        /// <summary>Domain name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Domain name",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get; set; }
        /// <summary>Number Of Employees</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number Of Employees",
        SerializedName = @"numberOfEmployees",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfEmployee { get; set; }
        /// <summary>Office Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Office Address",
        SerializedName = @"officeAddress",
        PossibleTypes = new [] { typeof(string) })]
        string OfficeAddress { get; set; }

    }
    /// Company Details.
    internal partial interface ICompanyDetailsInternal

    {
        /// <summary>Business phone number</summary>
        string Business { get; set; }
        /// <summary>company Name</summary>
        string CompanyName { get; set; }
        /// <summary>Country name</summary>
        string Country { get; set; }
        /// <summary>Domain name</summary>
        string Domain { get; set; }
        /// <summary>Number Of Employees</summary>
        int? NumberOfEmployee { get; set; }
        /// <summary>Office Address</summary>
        string OfficeAddress { get; set; }

    }
}