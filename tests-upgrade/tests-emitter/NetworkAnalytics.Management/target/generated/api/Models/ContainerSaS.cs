// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Extensions;

    /// <summary>The details for container sas creation.</summary>
    public partial class ContainerSaS :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaS,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Models.IContainerSaSInternal
    {

        /// <summary>Backing field for <see cref="ExpiryTimeStamp" /> property.</summary>
        private global::System.DateTime _expiryTimeStamp;

        /// <summary>Sas token expiry timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public global::System.DateTime ExpiryTimeStamp { get => this._expiryTimeStamp; set => this._expiryTimeStamp = value; }

        /// <summary>Backing field for <see cref="IPAddress" /> property.</summary>
        private string _iPAddress;

        /// <summary>Ip Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public string IPAddress { get => this._iPAddress; set => this._iPAddress = value; }

        /// <summary>Backing field for <see cref="StartTimeStamp" /> property.</summary>
        private global::System.DateTime _startTimeStamp;

        /// <summary>Sas token start timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.PropertyOrigin.Owned)]
        public global::System.DateTime StartTimeStamp { get => this._startTimeStamp; set => this._startTimeStamp = value; }

        /// <summary>Creates an new <see cref="ContainerSaS" /> instance.</summary>
        public ContainerSaS()
        {

        }
    }
    /// The details for container sas creation.
    public partial interface IContainerSaS :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.IJsonSerializable
    {
        /// <summary>Sas token expiry timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sas token expiry timestamp.",
        SerializedName = @"expiryTimeStamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime ExpiryTimeStamp { get; set; }
        /// <summary>Ip Address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Ip Address",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>Sas token start timestamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAnalytics.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Sas token start timestamp.",
        SerializedName = @"startTimeStamp",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime StartTimeStamp { get; set; }

    }
    /// The details for container sas creation.
    internal partial interface IContainerSaSInternal

    {
        /// <summary>Sas token expiry timestamp.</summary>
        global::System.DateTime ExpiryTimeStamp { get; set; }
        /// <summary>Ip Address</summary>
        string IPAddress { get; set; }
        /// <summary>Sas token start timestamp.</summary>
        global::System.DateTime StartTimeStamp { get; set; }

    }
}