// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Extensions;

    public partial class QumuloIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IQumuloIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Models.IQumuloIdentityInternal
    {

        /// <summary>Backing field for <see cref="FileSystemName" /> property.</summary>
        private string _fileSystemName;

        /// <summary>Name of the File System resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string FileSystemName { get => this._fileSystemName; set => this._fileSystemName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Origin(Microsoft.Azure.PowerShell.Cmdlets.Qumulo.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="QumuloIdentity" /> instance.</summary>
        public QumuloIdentity()
        {

        }
    }
    public partial interface IQumuloIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.IJsonSerializable
    {
        /// <summary>Name of the File System resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the File System resource",
        SerializedName = @"fileSystemName",
        PossibleTypes = new [] { typeof(string) })]
        string FileSystemName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Qumulo.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IQumuloIdentityInternal

    {
        /// <summary>Name of the File System resource</summary>
        string FileSystemName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}