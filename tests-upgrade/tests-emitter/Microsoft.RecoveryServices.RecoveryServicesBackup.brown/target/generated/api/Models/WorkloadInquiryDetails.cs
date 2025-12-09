// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Details of an inquired protectable item.</summary>
    public partial class WorkloadInquiryDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetails,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailCode; }

        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailMessage; }

        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailRecommendation; }

        /// <summary>Backing field for <see cref="InquiryValidation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidation _inquiryValidation;

        /// <summary>Inquiry validation such as permissions and other backup validations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidation InquiryValidation { get => (this._inquiryValidation = this._inquiryValidation ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InquiryValidation()); set => this._inquiryValidation = value; }

        /// <summary>Error Additional Detail in case the status is non-success.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string InquiryValidationAdditionalDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).AdditionalDetail; }

        /// <summary>Dictionary to store the count of ProtectableItems with key POType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAny InquiryValidationProtectableItemCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ProtectableItemCount; }

        /// <summary>Status for the Inquiry Validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Inlined)]
        public string InquiryValidationStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).Status = value ?? null; }

        /// <summary>Backing field for <see cref="ItemCount" /> property.</summary>
        private long? _itemCount;

        /// <summary>Contains the protectable item Count inside this Container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public long? ItemCount { get => this._itemCount; set => this._itemCount = value; }

        /// <summary>Internal Acessors for ErrorDetailCode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.ErrorDetailCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailCode = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.ErrorDetailMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailMessage = value ?? null; }

        /// <summary>Internal Acessors for ErrorDetailRecommendation</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.ErrorDetailRecommendation { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailRecommendation; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetailRecommendation = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for InquiryValidation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidation Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.InquiryValidation { get => (this._inquiryValidation = this._inquiryValidation ?? new Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.InquiryValidation()); set { {_inquiryValidation = value;} } }

        /// <summary>Internal Acessors for InquiryValidationAdditionalDetail</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.InquiryValidationAdditionalDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).AdditionalDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).AdditionalDetail = value ?? null; }

        /// <summary>Internal Acessors for InquiryValidationErrorDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.InquiryValidationErrorDetail { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetail; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ErrorDetail = value ?? null /* model class */; }

        /// <summary>Internal Acessors for InquiryValidationProtectableItemCount</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAny Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IWorkloadInquiryDetailsInternal.InquiryValidationProtectableItemCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ProtectableItemCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidationInternal)InquiryValidation).ProtectableItemCount = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of the Workload such as SQL, Oracle etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="WorkloadInquiryDetails" /> instance.</summary>
        public WorkloadInquiryDetails()
        {

        }
    }
    /// Details of an inquired protectable item.
    public partial interface IWorkloadInquiryDetails :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailCode { get;  }
        /// <summary>Error Message related to the Code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error Message related to the Code.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorDetailMessage { get;  }
        /// <summary>List of recommendation strings.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of recommendation strings.",
        SerializedName = @"recommendations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ErrorDetailRecommendation { get;  }
        /// <summary>Error Additional Detail in case the status is non-success.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Error Additional Detail in case the status is non-success.",
        SerializedName = @"additionalDetail",
        PossibleTypes = new [] { typeof(string) })]
        string InquiryValidationAdditionalDetail { get;  }
        /// <summary>Dictionary to store the count of ProtectableItems with key POType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Dictionary to store the count of ProtectableItems with key POType.",
        SerializedName = @"protectableItemCount",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAny InquiryValidationProtectableItemCount { get;  }
        /// <summary>Status for the Inquiry Validation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status for the Inquiry Validation.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string InquiryValidationStatus { get; set; }
        /// <summary>Contains the protectable item Count inside this Container.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Contains the protectable item Count inside this Container.",
        SerializedName = @"itemCount",
        PossibleTypes = new [] { typeof(long) })]
        long? ItemCount { get; set; }
        /// <summary>Type of the Workload such as SQL, Oracle etc.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the Workload such as SQL, Oracle etc.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Details of an inquired protectable item.
    internal partial interface IWorkloadInquiryDetailsInternal

    {
        /// <summary>Error code.</summary>
        string ErrorDetailCode { get; set; }
        /// <summary>Error Message related to the Code.</summary>
        string ErrorDetailMessage { get; set; }
        /// <summary>List of recommendation strings.</summary>
        System.Collections.Generic.List<string> ErrorDetailRecommendation { get; set; }
        /// <summary>Inquiry validation such as permissions and other backup validations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IInquiryValidation InquiryValidation { get; set; }
        /// <summary>Error Additional Detail in case the status is non-success.</summary>
        string InquiryValidationAdditionalDetail { get; set; }
        /// <summary>Error Detail in case the status is non-success.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IErrorDetail1 InquiryValidationErrorDetail { get; set; }
        /// <summary>Dictionary to store the count of ProtectableItems with key POType.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.IAny InquiryValidationProtectableItemCount { get; set; }
        /// <summary>Status for the Inquiry Validation.</summary>
        string InquiryValidationStatus { get; set; }
        /// <summary>Contains the protectable item Count inside this Container.</summary>
        long? ItemCount { get; set; }
        /// <summary>Type of the Workload such as SQL, Oracle etc.</summary>
        string Type { get; set; }

    }
}