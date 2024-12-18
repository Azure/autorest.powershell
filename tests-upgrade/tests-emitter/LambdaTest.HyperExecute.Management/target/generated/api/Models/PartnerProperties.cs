// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Extensions;

    /// <summary>Partner's specific Properties</summary>
    public partial class PartnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Models.IPartnerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LicensesSubscribed" /> property.</summary>
        private int _licensesSubscribed;

        /// <summary>The number of licenses subscribed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Origin(Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.PropertyOrigin.Owned)]
        public int LicensesSubscribed { get => this._licensesSubscribed; set => this._licensesSubscribed = value; }

        /// <summary>Creates an new <see cref="PartnerProperties" /> instance.</summary>
        public PartnerProperties()
        {

        }
    }
    /// Partner's specific Properties
    public partial interface IPartnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.IJsonSerializable
    {
        /// <summary>The number of licenses subscribed</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LambdaTest.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The number of licenses subscribed",
        SerializedName = @"licensesSubscribed",
        PossibleTypes = new [] { typeof(int) })]
        int LicensesSubscribed { get; set; }

    }
    /// Partner's specific Properties
    internal partial interface IPartnerPropertiesInternal

    {
        /// <summary>The number of licenses subscribed</summary>
        int LicensesSubscribed { get; set; }

    }
}