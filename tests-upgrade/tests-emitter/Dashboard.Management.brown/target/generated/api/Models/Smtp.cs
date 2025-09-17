// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>
    /// Email server settings.
    /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
    /// </summary>
    public partial class Smtp :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="FromAddress" /> property.</summary>
        private string _fromAddress;

        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string FromAddress { get => this._fromAddress; set => this._fromAddress = value; }

        /// <summary>Backing field for <see cref="FromName" /> property.</summary>
        private string _fromName;

        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string FromName { get => this._fromName; set => this._fromName = value; }

        /// <summary>Backing field for <see cref="Host" /> property.</summary>
        private string _host;

        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string Host { get => this._host; set => this._host = value; }

        /// <summary>Backing field for <see cref="Password" /> property.</summary>
        private System.Security.SecureString _password;

        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public System.Security.SecureString Password { get => this._password; set => this._password = value; }

        /// <summary>Backing field for <see cref="SkipVerify" /> property.</summary>
        private bool? _skipVerify;

        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public bool? SkipVerify { get => this._skipVerify; set => this._skipVerify = value; }

        /// <summary>Backing field for <see cref="StartTlsPolicy" /> property.</summary>
        private string _startTlsPolicy;

        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string StartTlsPolicy { get => this._startTlsPolicy; set => this._startTlsPolicy = value; }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private string _user;

        /// <summary>User of SMTP auth</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        public string User { get => this._user; set => this._user = value; }

        /// <summary>Creates an new <see cref="Smtp" /> instance.</summary>
        public Smtp()
        {

        }
    }
    /// Email server settings.
    /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
    public partial interface ISmtp :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Enable this to allow Grafana to send email. Default is false",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Address used when sending out emails
        https://pkg.go.dev/net/mail#Address",
        SerializedName = @"fromAddress",
        PossibleTypes = new [] { typeof(string) })]
        string FromAddress { get; set; }
        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name to be used when sending out emails. Default is ""Azure Managed Grafana Notification""
        https://pkg.go.dev/net/mail#Address",
        SerializedName = @"fromName",
        PossibleTypes = new [] { typeof(string) })]
        string FromName { get; set; }
        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"SMTP server hostname with port, e.g. test.email.net:587",
        SerializedName = @"host",
        PossibleTypes = new [] { typeof(string) })]
        string Host { get; set; }
        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString Password { get; set; }
        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Verify SSL for SMTP server. Default is false
        https://pkg.go.dev/crypto/tls#Config",
        SerializedName = @"skipVerify",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SkipVerify { get; set; }
        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The StartTLSPolicy setting of the SMTP configuration
        https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy",
        SerializedName = @"startTLSPolicy",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("OpportunisticStartTLS", "MandatoryStartTLS", "NoStartTLS")]
        string StartTlsPolicy { get; set; }
        /// <summary>User of SMTP auth</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"User of SMTP auth",
        SerializedName = @"user",
        PossibleTypes = new [] { typeof(string) })]
        string User { get; set; }

    }
    /// Email server settings.
    /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
    internal partial interface ISmtpInternal

    {
        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        string FromAddress { get; set; }
        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        string FromName { get; set; }
        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        string Host { get; set; }
        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        System.Security.SecureString Password { get; set; }
        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        bool? SkipVerify { get; set; }
        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("OpportunisticStartTLS", "MandatoryStartTLS", "NoStartTLS")]
        string StartTlsPolicy { get; set; }
        /// <summary>User of SMTP auth</summary>
        string User { get; set; }

    }
}