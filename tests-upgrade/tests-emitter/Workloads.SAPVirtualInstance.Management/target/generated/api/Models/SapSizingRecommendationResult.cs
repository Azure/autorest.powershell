// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The SAP sizing recommendation result.</summary>
    public partial class SapSizingRecommendationResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal
    {

        /// <summary>Backing field for <see cref="DeploymentType" /> property.</summary>
        private string _deploymentType;

        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string DeploymentType { get => this._deploymentType; set => this._deploymentType = value; }

        /// <summary>Creates an new <see cref="SapSizingRecommendationResult" /> instance.</summary>
        public SapSizingRecommendationResult()
        {

        }
    }
    /// The SAP sizing recommendation result.
    public partial interface ISapSizingRecommendationResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable
    {
        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The deployment type. Eg: SingleServer/ThreeTier",
        SerializedName = @"deploymentType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string DeploymentType { get; set; }

    }
    /// The SAP sizing recommendation result.
    internal partial interface ISapSizingRecommendationResultInternal

    {
        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PSArgumentCompleterAttribute("SingleServer", "ThreeTier")]
        string DeploymentType { get; set; }

    }
}