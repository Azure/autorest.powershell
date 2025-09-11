// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
    /// 'os'], Optional volume : ['backup'].
    /// </summary>
    public partial class SapDiskConfigurationsResultVolumeConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsResultVolumeConfigurations,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfigurationsResultVolumeConfigurationsInternal
    {

        /// <summary>
        /// Creates an new <see cref="SapDiskConfigurationsResultVolumeConfigurations" /> instance.
        /// </summary>
        public SapDiskConfigurationsResultVolumeConfigurations()
        {

        }
    }
    /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
    /// 'os'], Optional volume : ['backup'].
    public partial interface ISapDiskConfigurationsResultVolumeConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapDiskConfiguration>
    {

    }
    /// The disk configuration for the db volume. For HANA, Required volumes are: ['hana/data', 'hana/log', hana/shared', 'usr/sap',
    /// 'os'], Optional volume : ['backup'].
    internal partial interface ISapDiskConfigurationsResultVolumeConfigurationsInternal

    {

    }
}