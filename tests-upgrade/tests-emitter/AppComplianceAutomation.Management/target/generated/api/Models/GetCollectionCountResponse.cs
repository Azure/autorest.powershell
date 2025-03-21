// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Extensions;

    /// <summary>The get collection count response.</summary>
    public partial class GetCollectionCountResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IGetCollectionCountResponse,
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Models.IGetCollectionCountResponseInternal
    {

        /// <summary>Backing field for <see cref="Count" /> property.</summary>
        private int? _count;

        /// <summary>The count of the specified resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Origin(Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.PropertyOrigin.Owned)]
        public int? Count { get => this._count; set => this._count = value; }

        /// <summary>Creates an new <see cref="GetCollectionCountResponse" /> instance.</summary>
        public GetCollectionCountResponse()
        {

        }
    }
    /// The get collection count response.
    public partial interface IGetCollectionCountResponse :
        Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.IJsonSerializable
    {
        /// <summary>The count of the specified resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.AppComplianceAutomation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The count of the specified resource.",
        SerializedName = @"count",
        PossibleTypes = new [] { typeof(int) })]
        int? Count { get; set; }

    }
    /// The get collection count response.
    internal partial interface IGetCollectionCountResponseInternal

    {
        /// <summary>The count of the specified resource.</summary>
        int? Count { get; set; }

    }
}