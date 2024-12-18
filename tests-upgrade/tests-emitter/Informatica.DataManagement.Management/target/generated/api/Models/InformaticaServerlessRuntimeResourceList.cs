// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>A list of serverless runtime resources as fetched using the informatica APIs</summary>
    public partial class InformaticaServerlessRuntimeResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceList,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInformaticaServerlessRuntimeResourceListInternal
    {

        /// <summary>Backing field for <see cref="InformaticaRuntimeResource" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData> _informaticaRuntimeResource;

        /// <summary>List of runtime resources for the fetch all API</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData> InformaticaRuntimeResource { get => this._informaticaRuntimeResource; set => this._informaticaRuntimeResource = value; }

        /// <summary>
        /// Creates an new <see cref="InformaticaServerlessRuntimeResourceList" /> instance.
        /// </summary>
        public InformaticaServerlessRuntimeResourceList()
        {

        }
    }
    /// A list of serverless runtime resources as fetched using the informatica APIs
    public partial interface IInformaticaServerlessRuntimeResourceList :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>List of runtime resources for the fetch all API</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of runtime resources for the fetch all API",
        SerializedName = @"informaticaRuntimeResources",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData> InformaticaRuntimeResource { get; set; }

    }
    /// A list of serverless runtime resources as fetched using the informatica APIs
    internal partial interface IInformaticaServerlessRuntimeResourceListInternal

    {
        /// <summary>List of runtime resources for the fetch all API</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IInfaRuntimeResourceFetchMetaData> InformaticaRuntimeResource { get; set; }

    }
}