// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>Resource Id.</summary>
    public partial class ResourceItem :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItem,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItemInternal
    {

        /// <summary>Internal Acessors for ResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItemInternal.ResourceGroup { get => this._resourceGroup; set { {_resourceGroup = value;} } }

        /// <summary>Internal Acessors for ResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItemInternal.ResourceId { get => this._resourceId; set { {_resourceId = value;} } }

        /// <summary>Internal Acessors for ResourceType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItemInternal.ResourceType { get => this._resourceType; set { {_resourceType = value;} } }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IResourceItemInternal.SubscriptionId { get => this._subscriptionId; set { {_subscriptionId = value;} } }

        /// <summary>Backing field for <see cref="ResourceGroup" /> property.</summary>
        private string _resourceGroup;

        /// <summary>The resource group name of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceGroup { get => this._resourceGroup; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private string _resourceId;

        /// <summary>
        /// The resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceId { get => this._resourceId; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>The resource type of this resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription Id of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; }

        /// <summary>Creates an new <see cref="ResourceItem" /> instance.</summary>
        public ResourceItem()
        {

        }
    }
    /// Resource Id.
    public partial interface IResourceItem :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The resource group name of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource group name of this resource.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroup { get;  }
        /// <summary>
        /// The resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1".
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource Id - e.g. ""/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1"".",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceId { get;  }
        /// <summary>The resource type of this resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource type of this resource. e.g. ""Microsoft.SignalRService/SignalR""",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get;  }
        /// <summary>The subscription Id of this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The subscription Id of this resource.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get;  }

    }
    /// Resource Id.
    internal partial interface IResourceItemInternal

    {
        /// <summary>The resource group name of this resource.</summary>
        string ResourceGroup { get; set; }
        /// <summary>
        /// The resource Id - e.g. "/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/rg1/providers/Microsoft.Compute/virtualMachines/vm1".
        /// </summary>
        string ResourceId { get; set; }
        /// <summary>The resource type of this resource. e.g. "Microsoft.SignalRService/SignalR"</summary>
        string ResourceType { get; set; }
        /// <summary>The subscription Id of this resource.</summary>
        string SubscriptionId { get; set; }

    }
}