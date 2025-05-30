// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Extensions;

    /// <summary>Displays StandbyPool status.</summary>
    public partial class PoolStatus :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatus,
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string Code { get => this._code; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Displays the StandbyPool health state details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PropertyOrigin.Owned)]
        public string Message { get => this._message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal.Code { get => this._code; set { {_code = value;} } }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Models.IPoolStatusInternal.Message { get => this._message; set { {_message = value;} } }

        /// <summary>Creates an new <see cref="PoolStatus" /> instance.</summary>
        public PoolStatus()
        {

        }
    }
    /// Displays StandbyPool status.
    public partial interface IPoolStatus :
        Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.IJsonSerializable
    {
        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the healthy state of the StandbyPool.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("HealthState/healthy", "HealthState/degraded")]
        string Code { get;  }
        /// <summary>Displays the StandbyPool health state details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Displays the StandbyPool health state details.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }

    }
    /// Displays StandbyPool status.
    internal partial interface IPoolStatusInternal

    {
        /// <summary>Displays the healthy state of the StandbyPool.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StandbyPool.PSArgumentCompleterAttribute("HealthState/healthy", "HealthState/degraded")]
        string Code { get; set; }
        /// <summary>Displays the StandbyPool health state details.</summary>
        string Message { get; set; }

    }
}