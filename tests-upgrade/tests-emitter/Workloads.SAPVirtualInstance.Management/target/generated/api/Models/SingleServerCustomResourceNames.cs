// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>
    /// The resource-names input to specify custom names for underlying azure resources that are part of a single server SAP system.
    /// </summary>
    public partial class SingleServerCustomResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNames,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal
    {

        /// <summary>Internal Acessors for NamingPatternType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerCustomResourceNamesInternal.NamingPatternType { get => this._namingPatternType; set { {_namingPatternType = value;} } }

        /// <summary>Backing field for <see cref="NamingPatternType" /> property.</summary>
        private string _namingPatternType= @"FullResourceName";

        /// <summary>The naming pattern type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string NamingPatternType { get => this._namingPatternType; }

        /// <summary>Creates an new <see cref="SingleServerCustomResourceNames" /> instance.</summary>
        public SingleServerCustomResourceNames()
        {

        }
    }
    /// The resource-names input to specify custom names for underlying azure resources that are part of a single server SAP system.
    public partial interface ISingleServerCustomResourceNames :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The naming pattern type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The naming pattern type.",
        SerializedName = @"namingPatternType",
        PossibleTypes = new [] { typeof(string) })]
        string NamingPatternType { get;  }

    }
    /// The resource-names input to specify custom names for underlying azure resources that are part of a single server SAP system.
    internal partial interface ISingleServerCustomResourceNamesInternal

    {
        /// <summary>The naming pattern type.</summary>
        string NamingPatternType { get; set; }

    }
}