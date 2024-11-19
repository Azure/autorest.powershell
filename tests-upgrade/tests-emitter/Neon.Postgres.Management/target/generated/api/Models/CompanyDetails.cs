// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Company details for an organization</summary>
    public partial class CompanyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetails,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.ICompanyDetailsInternal
    {

        /// <summary>Backing field for <see cref="BusinessPhone" /> property.</summary>
        private string _businessPhone;

        /// <summary>Business phone number of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string BusinessPhone { get => this._businessPhone; set => this._businessPhone = value; }

        /// <summary>Backing field for <see cref="CompanyName" /> property.</summary>
        private string _companyName;

        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string CompanyName { get => this._companyName; set => this._companyName = value; }

        /// <summary>Backing field for <see cref="Country" /> property.</summary>
        private string _country;

        /// <summary>Country name of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string Country { get => this._country; set => this._country = value; }

        /// <summary>Backing field for <see cref="Domain" /> property.</summary>
        private string _domain;

        /// <summary>Domain of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string Domain { get => this._domain; set => this._domain = value; }

        /// <summary>Backing field for <see cref="NumberOfEmployee" /> property.</summary>
        private long? _numberOfEmployee;

        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public long? NumberOfEmployee { get => this._numberOfEmployee; set => this._numberOfEmployee = value; }

        /// <summary>Backing field for <see cref="OfficeAddress" /> property.</summary>
        private string _officeAddress;

        /// <summary>Office address of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string OfficeAddress { get => this._officeAddress; set => this._officeAddress = value; }

        /// <summary>Creates an new <see cref="CompanyDetails" /> instance.</summary>
        public CompanyDetails()
        {

        }
    }
    /// Company details for an organization
    public partial interface ICompanyDetails :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
        /// <summary>Business phone number of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Business phone number of the company",
        SerializedName = @"businessPhone",
        PossibleTypes = new [] { typeof(string) })]
        string BusinessPhone { get; set; }
        /// <summary>Company name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Company name",
        SerializedName = @"companyName",
        PossibleTypes = new [] { typeof(string) })]
        string CompanyName { get; set; }
        /// <summary>Country name of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Country name of the company",
        SerializedName = @"country",
        PossibleTypes = new [] { typeof(string) })]
        string Country { get; set; }
        /// <summary>Domain of the user</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Domain of the user",
        SerializedName = @"domain",
        PossibleTypes = new [] { typeof(string) })]
        string Domain { get; set; }
        /// <summary>Number of employees in the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Number of employees in the company",
        SerializedName = @"numberOfEmployees",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfEmployee { get; set; }
        /// <summary>Office address of the company</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Office address of the company",
        SerializedName = @"officeAddress",
        PossibleTypes = new [] { typeof(string) })]
        string OfficeAddress { get; set; }

    }
    /// Company details for an organization
    internal partial interface ICompanyDetailsInternal

    {
        /// <summary>Business phone number of the company</summary>
        string BusinessPhone { get; set; }
        /// <summary>Company name</summary>
        string CompanyName { get; set; }
        /// <summary>Country name of the company</summary>
        string Country { get; set; }
        /// <summary>Domain of the user</summary>
        string Domain { get; set; }
        /// <summary>Number of employees in the company</summary>
        long? NumberOfEmployee { get; set; }
        /// <summary>Office address of the company</summary>
        string OfficeAddress { get; set; }

    }
}