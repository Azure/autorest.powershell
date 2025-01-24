// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
    /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
    /// For application and cs layers, only 'default' volume is supported
    /// </summary>
    public partial class DataDiskNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.IDataDiskNamesInternal
    {

        /// <summary>Creates an new <see cref="DataDiskNames" /> instance.</summary>
        public DataDiskNames()
        {

        }
    }
    /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
    /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
    /// For application and cs layers, only 'default' volume is supported
    public partial interface IDataDiskNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IAssociativeArray<System.Collections.Generic.List<string>>
    {

    }
    /// The full resource names for virtual machine data disks. This is a dictionary containing list of names of data disks per
    /// volume. Currently supported volumes for database layer are ['hana/data', 'hana/log', hana/shared', 'usr/sap', 'os', 'backup'].
    /// For application and cs layers, only 'default' volume is supported
    internal partial interface IDataDiskNamesInternal

    {

    }
}