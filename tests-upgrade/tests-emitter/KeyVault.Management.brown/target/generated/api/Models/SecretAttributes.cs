// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.Extensions;

    /// <summary>The secret management attributes.</summary>
    public partial class SecretAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributes,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.ISecretAttributesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributes" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributes __attributes = new Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.Attributes();

        /// <summary>Creation time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public global::System.DateTime? Created { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Created; }

        /// <summary>Determines whether the object is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public bool? Enabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Enabled = value ?? default(bool); }

        /// <summary>Expiry date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public global::System.DateTime? Expire { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Expire; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Expire = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Created</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal.Created { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Created; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Created = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for Updated</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal.Updated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Updated; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Updated = value ?? default(global::System.DateTime); }

        /// <summary>Not before date in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public global::System.DateTime? NotBefore { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).NotBefore; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).NotBefore = value ?? default(global::System.DateTime); }

        /// <summary>Last updated time in seconds since 1970-01-01T00:00:00Z.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.PropertyOrigin.Inherited)]
        public global::System.DateTime? Updated { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal)__attributes).Updated; }

        /// <summary>Creates an new <see cref="SecretAttributes" /> instance.</summary>
        public SecretAttributes()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__attributes), __attributes);
            await eventListener.AssertObjectIsValid(nameof(__attributes), __attributes);
        }
    }
    /// The secret management attributes.
    public partial interface ISecretAttributes :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributes
    {

    }
    /// The secret management attributes.
    internal partial interface ISecretAttributesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IAttributesInternal
    {

    }
}