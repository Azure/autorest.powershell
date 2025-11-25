// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Preferences related to the order</summary>
    public partial class Preferences :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferences,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal
    {

        /// <summary>Backing field for <see cref="EncryptionPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences _encryptionPreference;

        /// <summary>Preferences related to the Encryption.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences EncryptionPreference { get => (this._encryptionPreference = this._encryptionPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.EncryptionPreferences()); set => this._encryptionPreference = value; }

        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceDoubleEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferencesInternal)EncryptionPreference).DoubleEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferencesInternal)EncryptionPreference).DoubleEncryption = value ?? null; }

        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string EncryptionPreferenceHardwareEncryption { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferencesInternal)EncryptionPreference).HardwareEncryption; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferencesInternal)EncryptionPreference).HardwareEncryption = value ?? null; }

        /// <summary>Internal Acessors for EncryptionPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal.EncryptionPreference { get => (this._encryptionPreference = this._encryptionPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.EncryptionPreferences()); set { {_encryptionPreference = value;} } }

        /// <summary>Internal Acessors for ReverseTransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal.ReverseTransportPreference { get => (this._reverseTransportPreference = this._reverseTransportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferences()); set { {_reverseTransportPreference = value;} } }

        /// <summary>Internal Acessors for ReverseTransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal.ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)ReverseTransportPreference).IsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)ReverseTransportPreference).IsUpdated = value ?? default(bool); }

        /// <summary>Internal Acessors for TransportPreference</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal.TransportPreference { get => (this._transportPreference = this._transportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferences()); set { {_transportPreference = value;} } }

        /// <summary>Internal Acessors for TransportPreferenceIsUpdated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IPreferencesInternal.TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).IsUpdated; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).IsUpdated = value ?? default(bool); }

        /// <summary>Backing field for <see cref="PreferredDataCenterRegion" /> property.</summary>
        private System.Collections.Generic.List<string> _preferredDataCenterRegion;

        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> PreferredDataCenterRegion { get => this._preferredDataCenterRegion; set => this._preferredDataCenterRegion = value; }

        /// <summary>Backing field for <see cref="ReverseTransportPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences _reverseTransportPreference;

        /// <summary>Optional Preferences related to the reverse shipment logistics of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences ReverseTransportPreference { get => (this._reverseTransportPreference = this._reverseTransportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferences()); set => this._reverseTransportPreference = value; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? ReverseTransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)ReverseTransportPreference).IsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string ReverseTransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)ReverseTransportPreference).PreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)ReverseTransportPreference).PreferredShipmentType = value ?? null; }

        /// <summary>Backing field for <see cref="StorageAccountAccessTierPreference" /> property.</summary>
        private System.Collections.Generic.List<string> _storageAccountAccessTierPreference;

        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> StorageAccountAccessTierPreference { get => this._storageAccountAccessTierPreference; set => this._storageAccountAccessTierPreference = value; }

        /// <summary>Backing field for <see cref="TransportPreference" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences _transportPreference;

        /// <summary>Preferences related to the shipment logistics of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences TransportPreference { get => (this._transportPreference = this._transportPreference ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.TransportPreferences()); set => this._transportPreference = value; }

        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public bool? TransportPreferenceIsUpdated { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).IsUpdated; }

        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string TransportPreferencePreferredShipmentType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).PreferredShipmentType; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferencesInternal)TransportPreference).PreferredShipmentType = value ?? null; }

        /// <summary>Creates an new <see cref="Preferences" /> instance.</summary>
        public Preferences()
        {

        }
    }
    /// Preferences related to the order
    public partial interface IPreferences :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines secondary layer of software-based encryption enablement.",
        SerializedName = @"doubleEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceDoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines Hardware level encryption (Only for disk)",
        SerializedName = @"hardwareEncryption",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceHardwareEncryption { get; set; }
        /// <summary>Preferred data center region.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Preferred data center region.",
        SerializedName = @"preferredDataCenterRegion",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> PreferredDataCenterRegion { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Read only property which indicates whether transport preferences has been updated or not after device is prepared.",
        SerializedName = @"isUpdated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ReverseTransportPreferenceIsUpdated { get;  }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates Shipment Logistics type that the customer preferred.",
        SerializedName = @"preferredShipmentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ReverseTransportPreferencePreferredShipmentType { get; set; }
        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Preferences related to the Access Tier of storage accounts.",
        SerializedName = @"storageAccountAccessTierPreferences",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Archive")]
        System.Collections.Generic.List<string> StorageAccountAccessTierPreference { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Read only property which indicates whether transport preferences has been updated or not after device is prepared.",
        SerializedName = @"isUpdated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? TransportPreferenceIsUpdated { get;  }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates Shipment Logistics type that the customer preferred.",
        SerializedName = @"preferredShipmentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string TransportPreferencePreferredShipmentType { get; set; }

    }
    /// Preferences related to the order
    internal partial interface IPreferencesInternal

    {
        /// <summary>Preferences related to the Encryption.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.IEncryptionPreferences EncryptionPreference { get; set; }
        /// <summary>Defines secondary layer of software-based encryption enablement.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceDoubleEncryption { get; set; }
        /// <summary>Defines Hardware level encryption (Only for disk)</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Enabled", "Disabled")]
        string EncryptionPreferenceHardwareEncryption { get; set; }
        /// <summary>Preferred data center region.</summary>
        System.Collections.Generic.List<string> PreferredDataCenterRegion { get; set; }
        /// <summary>Optional Preferences related to the reverse shipment logistics of the sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences ReverseTransportPreference { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? ReverseTransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string ReverseTransportPreferencePreferredShipmentType { get; set; }
        /// <summary>Preferences related to the Access Tier of storage accounts.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("Archive")]
        System.Collections.Generic.List<string> StorageAccountAccessTierPreference { get; set; }
        /// <summary>Preferences related to the shipment logistics of the sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.ITransportPreferences TransportPreference { get; set; }
        /// <summary>
        /// Read only property which indicates whether transport preferences has been updated or not after device is prepared.
        /// </summary>
        bool? TransportPreferenceIsUpdated { get; set; }
        /// <summary>Indicates Shipment Logistics type that the customer preferred.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DataBox.PSArgumentCompleterAttribute("CustomerManaged", "MicrosoftManaged")]
        string TransportPreferencePreferredShipmentType { get; set; }

    }
}