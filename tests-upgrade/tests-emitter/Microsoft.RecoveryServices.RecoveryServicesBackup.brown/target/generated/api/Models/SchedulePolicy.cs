// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Extensions;

    /// <summary>Base class for backup schedule.</summary>
    public partial class SchedulePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicy,
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Models.ISchedulePolicyInternal
    {

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Origin(Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="SchedulePolicy" /> instance.</summary>
        public SchedulePolicy()
        {

        }
    }
    /// Base class for backup schedule.
    public partial interface ISchedulePolicy :
        Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.IJsonSerializable
    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.RecoveryServicesBackup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.",
        SerializedName = @"schedulePolicyType",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Base class for backup schedule.
    internal partial interface ISchedulePolicyInternal

    {
        /// <summary>
        /// This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types.
        /// </summary>
        string Type { get; set; }

    }
}