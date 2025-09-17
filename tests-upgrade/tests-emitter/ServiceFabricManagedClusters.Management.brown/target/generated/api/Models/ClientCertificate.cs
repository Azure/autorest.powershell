// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Extensions;

    /// <summary>Client certificate definition.</summary>
    public partial class ClientCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificate,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Models.IClientCertificateInternal
    {

        /// <summary>Backing field for <see cref="CommonName" /> property.</summary>
        private string _commonName;

        /// <summary>Certificate common name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string CommonName { get => this._commonName; set => this._commonName = value; }

        /// <summary>Backing field for <see cref="IsAdmin" /> property.</summary>
        private bool _isAdmin;

        /// <summary>
        /// Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations
        /// on the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public bool IsAdmin { get => this._isAdmin; set => this._isAdmin = value; }

        /// <summary>Backing field for <see cref="IssuerThumbprint" /> property.</summary>
        private string _issuerThumbprint;

        /// <summary>Issuer thumbprint for the certificate. Only used together with CommonName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string IssuerThumbprint { get => this._issuerThumbprint; set => this._issuerThumbprint = value; }

        /// <summary>Backing field for <see cref="Thumbprint" /> property.</summary>
        private string _thumbprint;

        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.PropertyOrigin.Owned)]
        public string Thumbprint { get => this._thumbprint; set => this._thumbprint = value; }

        /// <summary>Creates an new <see cref="ClientCertificate" /> instance.</summary>
        public ClientCertificate()
        {

        }
    }
    /// Client certificate definition.
    public partial interface IClientCertificate :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.IJsonSerializable
    {
        /// <summary>Certificate common name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate common name.",
        SerializedName = @"commonName",
        PossibleTypes = new [] { typeof(string) })]
        string CommonName { get; set; }
        /// <summary>
        /// Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations
        /// on the cluster.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster.",
        SerializedName = @"isAdmin",
        PossibleTypes = new [] { typeof(bool) })]
        bool IsAdmin { get; set; }
        /// <summary>Issuer thumbprint for the certificate. Only used together with CommonName.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Issuer thumbprint for the certificate. Only used together with CommonName.",
        SerializedName = @"issuerThumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string IssuerThumbprint { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceFabricManagedClusters.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Certificate thumbprint.",
        SerializedName = @"thumbprint",
        PossibleTypes = new [] { typeof(string) })]
        string Thumbprint { get; set; }

    }
    /// Client certificate definition.
    internal partial interface IClientCertificateInternal

    {
        /// <summary>Certificate common name.</summary>
        string CommonName { get; set; }
        /// <summary>
        /// Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations
        /// on the cluster.
        /// </summary>
        bool IsAdmin { get; set; }
        /// <summary>Issuer thumbprint for the certificate. Only used together with CommonName.</summary>
        string IssuerThumbprint { get; set; }
        /// <summary>Certificate thumbprint.</summary>
        string Thumbprint { get; set; }

    }
}