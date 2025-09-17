// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Available operation list result</summary>
    public partial class OperationResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IOperationResult,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IOperationResultInternal
    {

        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplay _display;

        /// <summary>The object that represents the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplay Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AvailableOperationDisplay()); set => this._display = value; }

        /// <summary>Operation description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DisplayDescription { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Description = value ?? null; }

        /// <summary>The operation that can be performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DisplayOperation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Operation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Operation = value ?? null; }

        /// <summary>The name of the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DisplayProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Provider; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Provider = value ?? null; }

        /// <summary>The resource on which the operation is performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Inlined)]
        public string DisplayResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Resource; set => ((Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplayInternal)Display).Resource = value ?? null; }

        /// <summary>Backing field for <see cref="IsDataAction" /> property.</summary>
        private bool? _isDataAction;

        /// <summary>Indicates whether the operation is a data action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool? IsDataAction { get => this._isDataAction; set => this._isDataAction = value; }

        /// <summary>Internal Acessors for Display</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplay Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IOperationResultInternal.Display { get => (this._display = this._display ?? new Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.AvailableOperationDisplay()); set { {_display = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Origin" /> property.</summary>
        private string _origin;

        /// <summary>Origin result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Origin { get => this._origin; set => this._origin = value; }

        /// <summary>Creates an new <see cref="OperationResult" /> instance.</summary>
        public OperationResult()
        {

        }
    }
    /// Available operation list result
    public partial interface IOperationResult :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Operation description</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Operation description",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>The operation that can be performed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The operation that can be performed.",
        SerializedName = @"operation",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayOperation { get; set; }
        /// <summary>The name of the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the provider.",
        SerializedName = @"provider",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayProvider { get; set; }
        /// <summary>The resource on which the operation is performed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource on which the operation is performed",
        SerializedName = @"resource",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayResource { get; set; }
        /// <summary>Indicates whether the operation is a data action</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates whether the operation is a data action",
        SerializedName = @"isDataAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDataAction { get; set; }
        /// <summary>The name of the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The URL to use for getting the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The URL to use for getting the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Origin result</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Origin result",
        SerializedName = @"origin",
        PossibleTypes = new [] { typeof(string) })]
        string Origin { get; set; }

    }
    /// Available operation list result
    internal partial interface IOperationResultInternal

    {
        /// <summary>The object that represents the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IAvailableOperationDisplay Display { get; set; }
        /// <summary>Operation description</summary>
        string DisplayDescription { get; set; }
        /// <summary>The operation that can be performed.</summary>
        string DisplayOperation { get; set; }
        /// <summary>The name of the provider.</summary>
        string DisplayProvider { get; set; }
        /// <summary>The resource on which the operation is performed</summary>
        string DisplayResource { get; set; }
        /// <summary>Indicates whether the operation is a data action</summary>
        bool? IsDataAction { get; set; }
        /// <summary>The name of the operation.</summary>
        string Name { get; set; }
        /// <summary>The URL to use for getting the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>Origin result</summary>
        string Origin { get; set; }

    }
}