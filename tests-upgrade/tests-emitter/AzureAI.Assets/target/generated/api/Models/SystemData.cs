// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Metadata pertaining to creation and last modification of the resource.</summary>
    public partial class SystemData :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemData,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal
    {

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private global::System.DateTime? _createdAt;

        /// <summary>The timestamp the resource was created at.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.DateTime? CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="CreatedBy" /> property.</summary>
        private string _createdBy;

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string CreatedBy { get => this._createdBy; }

        /// <summary>Backing field for <see cref="CreatedByType" /> property.</summary>
        private string _createdByType;

        /// <summary>The identity type that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string CreatedByType { get => this._createdByType; }

        /// <summary>Backing field for <see cref="LastModifiedAt" /> property.</summary>
        private global::System.DateTime? _lastModifiedAt;

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.DateTime? LastModifiedAt { get => this._lastModifiedAt; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for CreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal.CreatedBy { get => this._createdBy; set { {_createdBy = value;} } }

        /// <summary>Internal Acessors for CreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal.CreatedByType { get => this._createdByType; set { {_createdByType = value;} } }

        /// <summary>Internal Acessors for LastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.ISystemDataInternal.LastModifiedAt { get => this._lastModifiedAt; set { {_lastModifiedAt = value;} } }

        /// <summary>Creates an new <see cref="SystemData" /> instance.</summary>
        public SystemData()
        {

        }
    }
    /// Metadata pertaining to creation and last modification of the resource.
    public partial interface ISystemData :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>The timestamp the resource was created at.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp the resource was created at.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get;  }
        /// <summary>The identity type that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity type that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastModifiedAt { get;  }

    }
    /// Metadata pertaining to creation and last modification of the resource.
    internal partial interface ISystemDataInternal

    {
        /// <summary>The timestamp the resource was created at.</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string CreatedBy { get; set; }
        /// <summary>The identity type that created the resource.</summary>
        string CreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? LastModifiedAt { get; set; }

    }
}