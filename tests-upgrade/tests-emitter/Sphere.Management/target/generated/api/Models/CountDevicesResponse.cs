// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.Extensions;

    /// <summary>Response to the action call for count devices in a catalog.</summary>
    public partial class CountDevicesResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountDevicesResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountDevicesResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponse"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponse __countElementsResponse = new Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.CountElementsResponse();

        /// <summary>Number of children resources in parent resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Sphere.Origin(Microsoft.Azure.PowerShell.Cmdlets.Sphere.PropertyOrigin.Inherited)]
        public int Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponseInternal)__countElementsResponse).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponseInternal)__countElementsResponse).Value = value ; }

        /// <summary>Creates an new <see cref="CountDevicesResponse" /> instance.</summary>
        public CountDevicesResponse()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__countElementsResponse), __countElementsResponse);
            await eventListener.AssertObjectIsValid(nameof(__countElementsResponse), __countElementsResponse);
        }
    }
    /// Response to the action call for count devices in a catalog.
    public partial interface ICountDevicesResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponse
    {

    }
    /// Response to the action call for count devices in a catalog.
    internal partial interface ICountDevicesResponseInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Sphere.Models.ICountElementsResponseInternal
    {

    }
}