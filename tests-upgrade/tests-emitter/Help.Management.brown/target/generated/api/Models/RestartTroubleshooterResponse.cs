// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Help.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Extensions;

    /// <summary>Troubleshooter restart response</summary>
    public partial class RestartTroubleshooterResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponseInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for TroubleshooterResourceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponseInternal.TroubleshooterResourceName { get => this._troubleshooterResourceName; set { {_troubleshooterResourceName = value;} } }

        /// <summary>Backing field for <see cref="TroubleshooterResourceName" /> property.</summary>
        private string _troubleshooterResourceName;

        /// <summary>Updated TroubleshooterResource Name .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Origin(Microsoft.Azure.PowerShell.Cmdlets.Help.PropertyOrigin.Owned)]
        public string TroubleshooterResourceName { get => this._troubleshooterResourceName; }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("location", out var __locationHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Help.Models.IRestartTroubleshooterResponseInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader0) is string __headerLocationHeader0 ? __headerLocationHeader0 : (string)null;
            }
        }

        /// <summary>Creates an new <see cref="RestartTroubleshooterResponse" /> instance.</summary>
        public RestartTroubleshooterResponse()
        {

        }
    }
    /// Troubleshooter restart response
    public partial interface IRestartTroubleshooterResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Updated TroubleshooterResource Name .</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Help.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Updated TroubleshooterResource Name .",
        SerializedName = @"troubleshooterResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string TroubleshooterResourceName { get;  }

    }
    /// Troubleshooter restart response
    internal partial interface IRestartTroubleshooterResponseInternal

    {
        string Location { get; set; }
        /// <summary>Updated TroubleshooterResource Name .</summary>
        string TroubleshooterResourceName { get; set; }

    }
}