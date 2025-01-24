// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The list of supported SKUs for different resources which are part of SAP deployment.
    /// </summary>
    public partial class SapSupportedResourceSkusResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedResourceSkusResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedResourceSkusResultInternal
    {

        /// <summary>Backing field for <see cref="SupportedSku" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSku> _supportedSku;

        /// <summary>Gets the list of SAP supported SKUs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSku> SupportedSku { get => this._supportedSku; set => this._supportedSku = value; }

        /// <summary>Creates an new <see cref="SapSupportedResourceSkusResult" /> instance.</summary>
        public SapSupportedResourceSkusResult()
        {

        }
    }
    /// The list of supported SKUs for different resources which are part of SAP deployment.
    public partial interface ISapSupportedResourceSkusResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>Gets the list of SAP supported SKUs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets the list of SAP supported SKUs.",
        SerializedName = @"supportedSkus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSku) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSku> SupportedSku { get; set; }

    }
    /// The list of supported SKUs for different resources which are part of SAP deployment.
    internal partial interface ISapSupportedResourceSkusResultInternal

    {
        /// <summary>Gets the list of SAP supported SKUs.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSupportedSku> SupportedSku { get; set; }

    }
}