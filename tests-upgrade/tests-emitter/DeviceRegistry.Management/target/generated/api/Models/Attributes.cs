// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.Extensions;

    /// <summary>A set of key-value pairs that contain custom attributes set by the customer.</summary>
    public partial class Attributes :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributes,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Models.IAttributesInternal
    {

        /// <summary>Creates an new <see cref="Attributes" /> instance.</summary>
        public Attributes()
        {

        }
    }
    /// A set of key-value pairs that contain custom attributes set by the customer.
    public partial interface IAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DeviceRegistry.Runtime.IAssociativeArray<global::System.Object>
    {

    }
    /// A set of key-value pairs that contain custom attributes set by the customer.
    internal partial interface IAttributesInternal

    {

    }
}