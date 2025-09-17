// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Extensions;

    /// <summary>Server configurations of a Grafana instance</summary>
    public partial class GrafanaConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurations,
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal
    {

        /// <summary>Internal Acessors for Security</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal.Security { get => (this._security = this._security ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Security()); set { {_security = value;} } }

        /// <summary>Internal Acessors for Smtp</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal.Smtp { get => (this._smtp = this._smtp ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Smtp()); set { {_smtp = value;} } }

        /// <summary>Internal Acessors for Snapshot</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal.Snapshot { get => (this._snapshot = this._snapshot ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Snapshots()); set { {_snapshot = value;} } }

        /// <summary>Internal Acessors for UnifiedAlertingScreenshot</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal.UnifiedAlertingScreenshot { get => (this._unifiedAlertingScreenshot = this._unifiedAlertingScreenshot ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshots()); set { {_unifiedAlertingScreenshot = value;} } }

        /// <summary>Internal Acessors for User</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IGrafanaConfigurationsInternal.User { get => (this._user = this._user ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Users()); set { {_user = value;} } }

        /// <summary>Backing field for <see cref="Security" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity _security;

        /// <summary>Grafana security settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity Security { get => (this._security = this._security ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Security()); set => this._security = value; }

        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SecurityCsrfAlwaysCheck { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurityInternal)Security).CsrfAlwaysCheck; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurityInternal)Security).CsrfAlwaysCheck = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Smtp" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp _smtp;

        /// <summary>
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp Smtp { get => (this._smtp = this._smtp ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Smtp()); set => this._smtp = value; }

        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SmtpEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).Enabled = value ?? default(bool); }

        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpFromAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).FromAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).FromAddress = value ?? null; }

        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpFromName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).FromName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).FromName = value ?? null; }

        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpHost { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).Host; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).Host = value ?? null; }

        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public System.Security.SecureString SmtpPassword { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).Password = value ?? null; }

        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SmtpSkipVerify { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).SkipVerify; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).SkipVerify = value ?? default(bool); }

        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpStartTlsPolicy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).StartTlsPolicy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).StartTlsPolicy = value ?? null; }

        /// <summary>User of SMTP auth</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public string SmtpUser { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).User; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtpInternal)Smtp).User = value ?? null; }

        /// <summary>Backing field for <see cref="Snapshot" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots _snapshot;

        /// <summary>Grafana Snapshots settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots Snapshot { get => (this._snapshot = this._snapshot ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Snapshots()); set => this._snapshot = value; }

        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? SnapshotExternalEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshotsInternal)Snapshot).ExternalEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshotsInternal)Snapshot).ExternalEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="UnifiedAlertingScreenshot" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots _unifiedAlertingScreenshot;

        /// <summary>Grafana Unified Alerting Screenshots settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots UnifiedAlertingScreenshot { get => (this._unifiedAlertingScreenshot = this._unifiedAlertingScreenshot ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.UnifiedAlertingScreenshots()); set => this._unifiedAlertingScreenshot = value; }

        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? UnifiedAlertingScreenshotCaptureEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshotsInternal)UnifiedAlertingScreenshot).CaptureEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshotsInternal)UnifiedAlertingScreenshot).CaptureEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="User" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers _user;

        /// <summary>Grafana users settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers User { get => (this._user = this._user ?? new Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.Users()); set => this._user = value; }

        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? UserEditorsCanAdmin { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsersInternal)User).EditorsCanAdmin; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsersInternal)User).EditorsCanAdmin = value ?? default(bool); }

        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Origin(Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PropertyOrigin.Inlined)]
        public bool? UserViewersCanEdit { get => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsersInternal)User).ViewersCanEdit; set => ((Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsersInternal)User).ViewersCanEdit = value ?? default(bool); }

        /// <summary>Creates an new <see cref="GrafanaConfigurations" /> instance.</summary>
        public GrafanaConfigurations()
        {

        }
    }
    /// Server configurations of a Grafana instance
    public partial interface IGrafanaConfigurations :
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true to execute the CSRF check even if the login cookie is not in a request (default false).",
        SerializedName = @"csrfAlwaysCheck",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SecurityCsrfAlwaysCheck { get; set; }
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
        bool? SmtpEnabled { get; set; }
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
        string SmtpFromAddress { get; set; }
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
        string SmtpFromName { get; set; }
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
        string SmtpHost { get; set; }
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
        System.Security.SecureString SmtpPassword { get; set; }
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
        bool? SmtpSkipVerify { get; set; }
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
        string SmtpStartTlsPolicy { get; set; }
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
        string SmtpUser { get; set; }
        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to false to disable external snapshot publish endpoint",
        SerializedName = @"externalEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SnapshotExternalEnabled { get; set; }
        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to false to disable capture screenshot in Unified Alert due to performance issue.",
        SerializedName = @"captureEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UnifiedAlertingScreenshotCaptureEnabled { get; set; }
        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true so editors can administrate dashboards, folders and teams they create.",
        SerializedName = @"editorsCanAdmin",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UserEditorsCanAdmin { get; set; }
        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access to. They cannot save their changes.",
        SerializedName = @"viewersCanEdit",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UserViewersCanEdit { get; set; }

    }
    /// Server configurations of a Grafana instance
    internal partial interface IGrafanaConfigurationsInternal

    {
        /// <summary>Grafana security settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISecurity Security { get; set; }
        /// <summary>
        /// Set to true to execute the CSRF check even if the login cookie is not in a request (default false).
        /// </summary>
        bool? SecurityCsrfAlwaysCheck { get; set; }
        /// <summary>
        /// Email server settings.
        /// https://grafana.com/docs/grafana/v9.0/setup-grafana/configure-grafana/#smtp
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISmtp Smtp { get; set; }
        /// <summary>Enable this to allow Grafana to send email. Default is false</summary>
        bool? SmtpEnabled { get; set; }
        /// <summary>
        /// Address used when sending out emails
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        string SmtpFromAddress { get; set; }
        /// <summary>
        /// Name to be used when sending out emails. Default is "Azure Managed Grafana Notification"
        /// https://pkg.go.dev/net/mail#Address
        /// </summary>
        string SmtpFromName { get; set; }
        /// <summary>SMTP server hostname with port, e.g. test.email.net:587</summary>
        string SmtpHost { get; set; }
        /// <summary>
        /// Password of SMTP auth. If the password contains # or ;, then you have to wrap it with triple quotes
        /// </summary>
        System.Security.SecureString SmtpPassword { get; set; }
        /// <summary>
        /// Verify SSL for SMTP server. Default is false
        /// https://pkg.go.dev/crypto/tls#Config
        /// </summary>
        bool? SmtpSkipVerify { get; set; }
        /// <summary>
        /// The StartTLSPolicy setting of the SMTP configuration
        /// https://pkg.go.dev/github.com/go-mail/mail#StartTLSPolicy
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Dashboard.PSArgumentCompleterAttribute("OpportunisticStartTLS", "MandatoryStartTLS", "NoStartTLS")]
        string SmtpStartTlsPolicy { get; set; }
        /// <summary>User of SMTP auth</summary>
        string SmtpUser { get; set; }
        /// <summary>Grafana Snapshots settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.ISnapshots Snapshot { get; set; }
        /// <summary>Set to false to disable external snapshot publish endpoint</summary>
        bool? SnapshotExternalEnabled { get; set; }
        /// <summary>Grafana Unified Alerting Screenshots settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUnifiedAlertingScreenshots UnifiedAlertingScreenshot { get; set; }
        /// <summary>
        /// Set to false to disable capture screenshot in Unified Alert due to performance issue.
        /// </summary>
        bool? UnifiedAlertingScreenshotCaptureEnabled { get; set; }
        /// <summary>Grafana users settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Dashboard.Models.IUsers User { get; set; }
        /// <summary>
        /// Set to true so editors can administrate dashboards, folders and teams they create.
        /// </summary>
        bool? UserEditorsCanAdmin { get; set; }
        /// <summary>
        /// Set to true so viewers can access and use explore and perform temporary edits on panels in dashboards they have access
        /// to. They cannot save their changes.
        /// </summary>
        bool? UserViewersCanEdit { get; set; }

    }
}