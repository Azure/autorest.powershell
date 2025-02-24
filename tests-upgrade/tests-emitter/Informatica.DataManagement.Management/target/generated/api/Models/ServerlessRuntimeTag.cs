// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Extensions;

    /// <summary>Serverless Runtime Tags</summary>
    public partial class ServerlessRuntimeTag :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTag,
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Models.IServerlessRuntimeTagInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name (also known as the key) of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Origin(Microsoft.Azure.PowerShell.Cmdlets.Informatica.PropertyOrigin.Owned)]
        public string Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ServerlessRuntimeTag" /> instance.</summary>
        public ServerlessRuntimeTag()
        {

        }
    }
    /// Serverless Runtime Tags
    public partial interface IServerlessRuntimeTag :
        Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.IJsonSerializable
    {
        /// <summary>The name (also known as the key) of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name (also known as the key) of the tag.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The value of the tag.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Informatica.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of the tag.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(string) })]
        string Value { get; set; }

    }
    /// Serverless Runtime Tags
    internal partial interface IServerlessRuntimeTagInternal

    {
        /// <summary>The name (also known as the key) of the tag.</summary>
        string Name { get; set; }
        /// <summary>The value of the tag.</summary>
        string Value { get; set; }

    }
}