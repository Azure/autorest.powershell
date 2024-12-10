// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.Extensions;

    /// <summary>Customer provides the stand-by agent scheme.</summary>
    public partial class ManualResourcePredictionsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManualResourcePredictionsProfile,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IManualResourcePredictionsProfileInternal,
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
        public string Kind { get => "Manual"; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfileInternal)__resourcePredictionsProfile).Kind = "Manual"; }

        /// <summary>Creates an new <see cref="ManualResourcePredictionsProfile" /> instance.</summary>
        public ManualResourcePredictionsProfile()
        {
            this.__resourcePredictionsProfile.Kind = "Manual";
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
    /// Customer provides the stand-by agent scheme.
    public partial interface IManualResourcePredictionsProfile :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfile
    {

    }
    /// Customer provides the stand-by agent scheme.
    internal partial interface IManualResourcePredictionsProfileInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevOpsInfrastructure.Models.IResourcePredictionsProfileInternal
    {

    }
}