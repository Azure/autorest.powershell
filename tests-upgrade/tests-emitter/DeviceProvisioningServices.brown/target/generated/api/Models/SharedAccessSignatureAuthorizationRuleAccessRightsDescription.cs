// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Extensions;

    /// <summary>Description of the shared access key.</summary>
    public partial class SharedAccessSignatureAuthorizationRuleAccessRightsDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescription,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Models.ISharedAccessSignatureAuthorizationRuleAccessRightsDescriptionInternal
    {

        /// <summary>Backing field for <see cref="KeyName" /> property.</summary>
        private string _keyName;

        /// <summary>Name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string KeyName { get => this._keyName; set => this._keyName = value; }

        /// <summary>Backing field for <see cref="PrimaryKey" /> property.</summary>
        private string _primaryKey;

        /// <summary>Primary SAS key value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string PrimaryKey { get => this._primaryKey; set => this._primaryKey = value; }

        /// <summary>Backing field for <see cref="Rights" /> property.</summary>
        private string _rights;

        /// <summary>Rights that this key has.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string Rights { get => this._rights; set => this._rights = value; }

        /// <summary>Backing field for <see cref="SecondaryKey" /> property.</summary>
        private string _secondaryKey;

        /// <summary>Secondary SAS key value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PropertyOrigin.Owned)]
        public string SecondaryKey { get => this._secondaryKey; set => this._secondaryKey = value; }

        /// <summary>
        /// Creates an new <see cref="SharedAccessSignatureAuthorizationRuleAccessRightsDescription" /> instance.
        /// </summary>
        public SharedAccessSignatureAuthorizationRuleAccessRightsDescription()
        {

        }
    }
    /// Description of the shared access key.
    public partial interface ISharedAccessSignatureAuthorizationRuleAccessRightsDescription :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.IJsonSerializable
    {
        /// <summary>Name of the key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the key.",
        SerializedName = @"keyName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyName { get; set; }
        /// <summary>Primary SAS key value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Primary SAS key value.",
        SerializedName = @"primaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string PrimaryKey { get; set; }
        /// <summary>Rights that this key has.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rights that this key has.",
        SerializedName = @"rights",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("ServiceConfig", "EnrollmentRead", "EnrollmentWrite", "DeviceConnect", "RegistrationStatusRead", "RegistrationStatusWrite")]
        string Rights { get; set; }
        /// <summary>Secondary SAS key value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Secondary SAS key value.",
        SerializedName = @"secondaryKey",
        PossibleTypes = new [] { typeof(string) })]
        string SecondaryKey { get; set; }

    }
    /// Description of the shared access key.
    internal partial interface ISharedAccessSignatureAuthorizationRuleAccessRightsDescriptionInternal

    {
        /// <summary>Name of the key.</summary>
        string KeyName { get; set; }
        /// <summary>Primary SAS key value.</summary>
        string PrimaryKey { get; set; }
        /// <summary>Rights that this key has.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DeviceProvisioningServices.PSArgumentCompleterAttribute("ServiceConfig", "EnrollmentRead", "EnrollmentWrite", "DeviceConnect", "RegistrationStatusRead", "RegistrationStatusWrite")]
        string Rights { get; set; }
        /// <summary>Secondary SAS key value.</summary>
        string SecondaryKey { get; set; }

    }
}