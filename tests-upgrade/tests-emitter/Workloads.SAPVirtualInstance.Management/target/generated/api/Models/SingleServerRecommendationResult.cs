// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Extensions;

    /// <summary>The recommended configuration for a single server SAP system.</summary>
    public partial class SingleServerRecommendationResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerRecommendationResult,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISingleServerRecommendationResultInternal,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult __sapSizingRecommendationResult = new Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.SapSizingRecommendationResult();

        /// <summary>The deployment type. Eg: SingleServer/ThreeTier</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Inherited)]
        public string DeploymentType { get => "SingleServer"; set => ((Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal)__sapSizingRecommendationResult).DeploymentType = "SingleServer"; }

        /// <summary>Backing field for <see cref="VMSku" /> property.</summary>
        private string _vMSku;

        /// <summary>The recommended VM SKU for single server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Origin(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.PropertyOrigin.Owned)]
        public string VMSku { get => this._vMSku; set => this._vMSku = value; }

        /// <summary>Creates an new <see cref="SingleServerRecommendationResult" /> instance.</summary>
        public SingleServerRecommendationResult()
        {
            this.__sapSizingRecommendationResult.DeploymentType = "SingleServer";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__sapSizingRecommendationResult), __sapSizingRecommendationResult);
            await eventListener.AssertObjectIsValid(nameof(__sapSizingRecommendationResult), __sapSizingRecommendationResult);
        }
    }
    /// The recommended configuration for a single server SAP system.
    public partial interface ISingleServerRecommendationResult :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResult
    {
        /// <summary>The recommended VM SKU for single server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The recommended VM SKU for single server.",
        SerializedName = @"vmSku",
        PossibleTypes = new [] { typeof(string) })]
        string VMSku { get; set; }

    }
    /// The recommended configuration for a single server SAP system.
    internal partial interface ISingleServerRecommendationResultInternal :
        Microsoft.Azure.PowerShell.Cmdlets.SAPVirtualInstance.Models.ISapSizingRecommendationResultInternal
    {
        /// <summary>The recommended VM SKU for single server.</summary>
        string VMSku { get; set; }

    }
}