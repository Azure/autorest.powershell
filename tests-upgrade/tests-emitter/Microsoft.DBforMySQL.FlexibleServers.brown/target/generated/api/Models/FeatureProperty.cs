// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;

    /// <summary>Server version capabilities.</summary>
    public partial class FeatureProperty :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeatureProperty,
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeaturePropertyInternal
    {

        /// <summary>Backing field for <see cref="FeatureName" /> property.</summary>
        private string _featureName;

        /// <summary>feature name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string FeatureName { get => this._featureName; }

        /// <summary>Backing field for <see cref="FeatureValue" /> property.</summary>
        private string _featureValue;

        /// <summary>feature value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Owned)]
        public string FeatureValue { get => this._featureValue; }

        /// <summary>Internal Acessors for FeatureName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeaturePropertyInternal.FeatureName { get => this._featureName; set { {_featureName = value;} } }

        /// <summary>Internal Acessors for FeatureValue</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.IFeaturePropertyInternal.FeatureValue { get => this._featureValue; set { {_featureValue = value;} } }

        /// <summary>Creates an new <see cref="FeatureProperty" /> instance.</summary>
        public FeatureProperty()
        {

        }
    }
    /// Server version capabilities.
    public partial interface IFeatureProperty :
        Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.IJsonSerializable
    {
        /// <summary>feature name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"feature name",
        SerializedName = @"featureName",
        PossibleTypes = new [] { typeof(string) })]
        string FeatureName { get;  }
        /// <summary>feature value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"feature value",
        SerializedName = @"featureValue",
        PossibleTypes = new [] { typeof(string) })]
        string FeatureValue { get;  }

    }
    /// Server version capabilities.
    internal partial interface IFeaturePropertyInternal

    {
        /// <summary>feature name</summary>
        string FeatureName { get; set; }
        /// <summary>feature value</summary>
        string FeatureValue { get; set; }

    }
}