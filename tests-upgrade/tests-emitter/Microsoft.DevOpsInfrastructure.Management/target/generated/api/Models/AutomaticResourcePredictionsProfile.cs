// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>The stand-by agent scheme is determined based on historical demand.</summary>
    public partial class AutomaticResourcePredictionsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAutomaticResourcePredictionsProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IAutomaticResourcePredictionsProfileInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile __resourcePredictionsProfile = new Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.ResourcePredictionsProfile();

        /// <summary>Determines how the stand-by scheme should be provided.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Inherited)]
        public string Kind { get => "Automatic"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfileInternal)__resourcePredictionsProfile).Kind = "Automatic"; }

        /// <summary>Backing field for <see cref="PredictionPreference" /> property.</summary>
        private string _predictionPreference;

        /// <summary>Determines the balance between cost and performance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PropertyOrigin.Owned)]
        public string PredictionPreference { get => this._predictionPreference; set => this._predictionPreference = value; }

        /// <summary>Creates an new <see cref="AutomaticResourcePredictionsProfile" /> instance.</summary>
        public AutomaticResourcePredictionsProfile()
        {
            this.__resourcePredictionsProfile.Kind = "Automatic";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resourcePredictionsProfile), __resourcePredictionsProfile);
            await eventListener.AssertObjectIsValid(nameof(__resourcePredictionsProfile), __resourcePredictionsProfile);
        }
    }
    /// The stand-by agent scheme is determined based on historical demand.
    public partial interface IAutomaticResourcePredictionsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile
    {
        /// <summary>Determines the balance between cost and performance.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Determines the balance between cost and performance.",
        SerializedName = @"predictionPreference",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Balanced", "MostCostEffective", "MoreCostEffective", "MorePerformance", "BestPerformance")]
        string PredictionPreference { get; set; }

    }
    /// The stand-by agent scheme is determined based on historical demand.
    internal partial interface IAutomaticResourcePredictionsProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfileInternal
    {
        /// <summary>Determines the balance between cost and performance.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.PSArgumentCompleterAttribute("Balanced", "MostCostEffective", "MoreCostEffective", "MorePerformance", "BestPerformance")]
        string PredictionPreference { get; set; }

    }
}