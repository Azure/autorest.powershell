// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Extensions;

    /// <summary>Available operation details.</summary>
    public partial class ClientDiscoveryValueForSingleApi :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApi,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApiInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplay _display;

        /// <summary>Contains the localized display information for this particular operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClientDiscoveryDisplay()); set => this._display = value; }

        /// <summary>Description of the operation having details of what operation is about.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Description = value ?? null; }

        /// <summary>Operations Name itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>Name of the provider for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>ResourceType for which this Operation can be performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplay Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApiInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClientDiscoveryDisplay()); set { {_display = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForProperties Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApiInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClientDiscoveryForProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ServiceSpecification</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecification Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryValueForSingleApiInternal.ServiceSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForPropertiesInternal)Property).ServiceSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForPropertiesInternal)Property).ServiceSpecification = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the Operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>
        /// The intended executor of the operation;governs the display of the operation in the RBAC UX and the audit logs UX
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForProperties _property;

        /// <summary>ShoeBox properties for the given operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.ClientDiscoveryForProperties()); set => this._property = value; }

        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification> ServiceSpecificationLogSpecification { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForPropertiesInternal)Property).ServiceSpecificationLogSpecification; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForPropertiesInternal)Property).ServiceSpecificationLogSpecification = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="ClientDiscoveryValueForSingleApi" /> instance.</summary>
        public ClientDiscoveryValueForSingleApi()
        {

        }
    }
    /// Available operation details.
    public partial interface IClientDiscoveryValueForSingleApi :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.IJsonSerializable
    {
        /// <summary>Description of the operation having details of what operation is about.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the operation having details of what operation is about.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>Operations Name itself.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operations Name itself.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>Name of the provider for display purposes</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the provider for display purposes",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>ResourceType for which this Operation can be performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ResourceType for which this Operation can be performed.",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Name of the Operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the Operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The intended executor of the operation;governs the display of the operation in the RBAC UX and the audit logs UX
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The intended executor of the operation;governs the display of the operation in the RBAC UX and the audit logs UX",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        string Origin { get; set; }
        /// <summary>List of log specifications of this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of log specifications of this operation.",
        SerializedName = @"logSpecifications",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification> ServiceSpecificationLogSpecification { get; set; }

    }
    /// Available operation details.
    internal partial interface IClientDiscoveryValueForSingleApiInternal

    {
        /// <summary>Contains the localized display information for this particular operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryDisplay Display { get; set; }
        /// <summary>Description of the operation having details of what operation is about.</summary>
        string DisplayDescription { get; set; }
        /// <summary>Operations Name itself.</summary>
        string DisplayOperation { get; set; }
        /// <summary>Name of the provider for display purposes</summary>
        string DisplayProvider { get; set; }
        /// <summary>ResourceType for which this Operation can be performed.</summary>
        string DisplayResource { get; set; }
        /// <summary>Name of the Operation.</summary>
        string Name { get; set; }
        /// <summary>
        /// The intended executor of the operation;governs the display of the operation in the RBAC UX and the audit logs UX
        /// </summary>
        string Origin { get; set; }
        /// <summary>ShoeBox properties for the given operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForProperties Property { get; set; }
        /// <summary>Operation properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForServiceSpecification ServiceSpecification { get; set; }
        /// <summary>List of log specifications of this operation.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.RecoveryServices.Models.IClientDiscoveryForLogSpecification> ServiceSpecificationLogSpecification { get; set; }

    }
}