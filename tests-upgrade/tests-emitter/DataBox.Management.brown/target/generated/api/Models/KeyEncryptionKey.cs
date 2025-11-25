// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Encryption key containing details about key to encrypt different keys.</summary>
    public partial class KeyEncryptionKey :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKey,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal
    {

        /// <summary>Backing field for <see cref="IdentityProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties _identityProperty;

        /// <summary>Managed identity properties used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties IdentityProperty { get => (this._identityProperty = this._identityProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IdentityProperties()); set => this._identityProperty = value; }

        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPropertyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal)IdentityProperty).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal)IdentityProperty).Type = value ?? null; }

        /// <summary>Backing field for <see cref="KekType" /> property.</summary>
        private string _kekType;

        /// <summary>Type of encryption key used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string KekType { get => this._kekType; set => this._kekType = value; }

        /// <summary>Backing field for <see cref="KekUrl" /> property.</summary>
        private string _kekUrl;

        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string KekUrl { get => this._kekUrl; set => this._kekUrl = value; }

        /// <summary>Backing field for <see cref="KekVaultResourceId" /> property.</summary>
        private string _kekVaultResourceId;

        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string KekVaultResourceId { get => this._kekVaultResourceId; set => this._kekVaultResourceId = value; }

        /// <summary>Internal Acessors for IdentityProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal.IdentityProperty { get => (this._identityProperty = this._identityProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IdentityProperties()); set { {_identityProperty = value;} } }

        /// <summary>Internal Acessors for IdentityPropertyUserAssigned</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IKeyEncryptionKeyInternal.IdentityPropertyUserAssigned { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal)IdentityProperty).UserAssigned; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal)IdentityProperty).UserAssigned = value ?? null /* model class */; }

        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string UserAssignedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal)IdentityProperty).UserAssignedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityPropertiesInternal)IdentityProperty).UserAssignedResourceId = value ?? null; }

        /// <summary>Creates an new <see cref="KeyEncryptionKey" /> instance.</summary>
        public KeyEncryptionKey()
        {

        }
    }
    /// Encryption key containing details about key to encrypt different keys.
    public partial interface IKeyEncryptionKey :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Managed service identity type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Managed service identity type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPropertyType { get; set; }
        /// <summary>Type of encryption key used for key encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of encryption key used for key encryption.",
        SerializedName = @"kekType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("MicrosoftManaged", "CustomerManaged")]
        string KekType { get; set; }
        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Key encryption key. It is required in case of Customer managed KekType.",
        SerializedName = @"kekUrl",
        PossibleTypes = new [] { typeof(string) })]
        string KekUrl { get; set; }
        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Kek vault resource id. It is required in case of Customer managed KekType.",
        SerializedName = @"kekVaultResourceID",
        PossibleTypes = new [] { typeof(string) })]
        string KekVaultResourceId { get; set; }
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Arm resource id for user assigned identity to be used to fetch MSI token.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UserAssignedResourceId { get; set; }

    }
    /// Encryption key containing details about key to encrypt different keys.
    internal partial interface IKeyEncryptionKeyInternal

    {
        /// <summary>Managed identity properties used for key encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IIdentityProperties IdentityProperty { get; set; }
        /// <summary>Managed service identity type.</summary>
        string IdentityPropertyType { get; set; }
        /// <summary>User assigned identity properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IUserAssignedProperties IdentityPropertyUserAssigned { get; set; }
        /// <summary>Type of encryption key used for key encryption.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("MicrosoftManaged", "CustomerManaged")]
        string KekType { get; set; }
        /// <summary>Key encryption key. It is required in case of Customer managed KekType.</summary>
        string KekUrl { get; set; }
        /// <summary>Kek vault resource id. It is required in case of Customer managed KekType.</summary>
        string KekVaultResourceId { get; set; }
        /// <summary>Arm resource id for user assigned identity to be used to fetch MSI token.</summary>
        string UserAssignedResourceId { get; set; }

    }
}