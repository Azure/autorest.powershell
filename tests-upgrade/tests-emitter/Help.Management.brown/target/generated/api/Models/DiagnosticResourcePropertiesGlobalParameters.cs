// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>
    /// Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics
    /// results
    /// </summary>
    public partial class DiagnosticResourcePropertiesGlobalParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesGlobalParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IDiagnosticResourcePropertiesGlobalParametersInternal
    {

        /// <summary>
        /// Creates an new <see cref="DiagnosticResourcePropertiesGlobalParameters" /> instance.
        /// </summary>
        public DiagnosticResourcePropertiesGlobalParameters()
        {

        }
    }
    /// Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics
    /// results
    public partial interface IDiagnosticResourcePropertiesGlobalParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IAssociativeArray<string>
    {

    }
    /// Global parameters is an optional map which can be used to add key and value to request body to improve the diagnostics
    /// results
    internal partial interface IDiagnosticResourcePropertiesGlobalParametersInternal

    {

    }
}