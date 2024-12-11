// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.Extensions;

    /// <summary>Json formatted public settings for the extension.</summary>
    public partial class Settings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Models.ISettingsInternal
    {

        /// <summary>Creates an new <see cref="Settings" /> instance.</summary>
        public Settings()
        {

        }
    }
    /// Json formatted public settings for the extension.
    public partial interface ISettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeFleet.Runtime.IAssociativeArray<global::System.Object>
    {

    }
    /// Json formatted public settings for the extension.
    internal partial interface ISettingsInternal

    {

    }
}