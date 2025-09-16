// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Port range details</summary>
    public partial class EndpointRangeDescription :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescription,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IEndpointRangeDescriptionInternal
    {

        /// <summary>Backing field for <see cref="EndPort" /> property.</summary>
        private int _endPort;

        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int EndPort { get => this._endPort; set => this._endPort = value; }

        /// <summary>Backing field for <see cref="StartPort" /> property.</summary>
        private int _startPort;

        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public int StartPort { get => this._startPort; set => this._startPort = value; }

        /// <summary>Creates an new <see cref="EndpointRangeDescription" /> instance.</summary>
        public EndpointRangeDescription()
        {

        }
    }
    /// Port range details
    public partial interface IEndpointRangeDescription :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>End port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"End port of a range of ports",
        SerializedName = @"endPort",
        PossibleTypes = new [] { typeof(int) })]
        int EndPort { get; set; }
        /// <summary>Starting port of a range of ports</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Starting port of a range of ports",
        SerializedName = @"startPort",
        PossibleTypes = new [] { typeof(int) })]
        int StartPort { get; set; }

    }
    /// Port range details
    internal partial interface IEndpointRangeDescriptionInternal

    {
        /// <summary>End port of a range of ports</summary>
        int EndPort { get; set; }
        /// <summary>Starting port of a range of ports</summary>
        int StartPort { get; set; }

    }
}