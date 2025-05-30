// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Describes Resource Quota</summary>
    public partial class Quota :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuota,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaInternal
    {

        /// <summary>Backing field for <see cref="CurrentValue" /> property.</summary>
        private long _currentValue;

        /// <summary>The current usage of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public long CurrentValue { get => this._currentValue; set => this._currentValue = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Fully qualified ARM resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Limit" /> property.</summary>
        private long _limit;

        /// <summary>The maximum permitted usage of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public long Limit { get => this._limit; set => this._limit = value; }

        /// <summary>Internal Acessors for Name</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaName Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaInternal.Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.QuotaName()); set { {_name = value;} } }

        /// <summary>Internal Acessors for NameLocalizedValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaInternal.NameLocalizedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaNameInternal)Name).LocalizedValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaNameInternal)Name).LocalizedValue = value ?? null; }

        /// <summary>Internal Acessors for NameValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaInternal.NameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaNameInternal)Name).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaNameInternal)Name).Value = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaName _name;

        /// <summary>The name of the quota.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaName Name { get => (this._name = this._name ?? new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.QuotaName()); }

        /// <summary>The localized name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string NameLocalizedValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaNameInternal)Name).LocalizedValue; }

        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inlined)]
        public string NameValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaNameInternal)Name).Value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>The unit of usage measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="Quota" /> instance.</summary>
        public Quota()
        {

        }
    }
    /// Describes Resource Quota
    public partial interface IQuota :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable
    {
        /// <summary>The current usage of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The current usage of the resource.",
        SerializedName = @"currentValue",
        PossibleTypes = new [] { typeof(long) })]
        long CurrentValue { get; set; }
        /// <summary>Fully qualified ARM resource id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Fully qualified ARM resource id",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The maximum permitted usage of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The maximum permitted usage of the resource.",
        SerializedName = @"limit",
        PossibleTypes = new [] { typeof(long) })]
        long Limit { get; set; }
        /// <summary>The localized name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The localized name of the resource.",
        SerializedName = @"localizedValue",
        PossibleTypes = new [] { typeof(string) })]
        string NameLocalizedValue { get;  }
        /// <summary>The name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the resource.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string NameValue { get;  }
        /// <summary>The unit of usage measurement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The unit of usage measurement.",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// Describes Resource Quota
    internal partial interface IQuotaInternal

    {
        /// <summary>The current usage of the resource.</summary>
        long CurrentValue { get; set; }
        /// <summary>Fully qualified ARM resource id</summary>
        string Id { get; set; }
        /// <summary>The maximum permitted usage of the resource.</summary>
        long Limit { get; set; }
        /// <summary>The name of the quota.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IQuotaName Name { get; set; }
        /// <summary>The localized name of the resource.</summary>
        string NameLocalizedValue { get; set; }
        /// <summary>The name of the resource.</summary>
        string NameValue { get; set; }
        /// <summary>The unit of usage measurement.</summary>
        string Unit { get; set; }

    }
}