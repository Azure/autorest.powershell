/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "Psd1")]
    [DoNotExport]
    public class ExportPsd1 : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ExportsFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string CustomFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string Psd1Path { get; set; }

        [Parameter(Mandatory = true)]
        public Guid ModuleGuid { get; set; }

        private static readonly bool IsAzure = Convert.ToBoolean(@"${$project.azure}");
        private const string CustomFolderRelative = "${$project.customFolder}";
        private const string Indent = Psd1Indent;
        private const string Undefined = "undefined";
        private bool IsUndefined(string value) => string.Equals(Undefined, value, StringComparison.OrdinalIgnoreCase);

        protected override void ProcessRecord()
        {
            try
            {
                if (!Directory.Exists(ExportsFolder))
                {
                    throw new ArgumentException($"Exports folder '{ExportsFolder}' does not exist");
                }

                if (!Directory.Exists(CustomFolder))
                {
                    throw new ArgumentException($"Custom folder '{CustomFolder}' does not exist");
                }

                string version = Convert.ToString(@"${$project.moduleVersion}");
                // Validate the module version should be semantic version
                // Following regex is official from https://semver.org/
                Regex rx = new Regex(@"^(0|[1-9]\d*)\.(0|[1-9]\d*)\.(0|[1-9]\d*)(?:-((?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*)(?:\.(?:0|[1-9]\d*|\d*[a-zA-Z-][0-9a-zA-Z-]*))*))?(?:\+([0-9a-zA-Z-]+(?:\.[0-9a-zA-Z-]+)*))?$", RegexOptions.Compiled);
                if (rx.Matches(version).Count != 1)
                {
                    throw new ArgumentException("Module-version is not a valid Semantic Version");
                }

                string previewVersion = null;
                if (version.Contains('-'))
                {
                    string[] versions = version.Split("-".ToCharArray(), 2);
                    version = versions[0];
                    previewVersion = versions[1];
                }

                var sb = new StringBuilder();
                sb.AppendLine("@{");
                sb.AppendLine($@"{GuidStart} = '{ModuleGuid}'");
                sb.AppendLine($@"{Indent}RootModule = '{"${$project.psm1}"}'");
                sb.AppendLine($@"{Indent}ModuleVersion = '{version}'");
                sb.AppendLine($@"{Indent}CompatiblePSEditions = 'Core', 'Desktop'");
                sb.AppendLine($@"{Indent}Author = '{"${$project.metadata.authors}"}'");
                sb.AppendLine($@"{Indent}CompanyName = '{"${$project.metadata.companyName}"}'");
                sb.AppendLine($@"{Indent}Copyright = '{"${$project.metadata.copyright}"}'");
                sb.AppendLine($@"{Indent}Description = '{"${$project.metadata.description}"}'");
                sb.AppendLine($@"{Indent}PowerShellVersion = '5.1'");
                sb.AppendLine($@"{Indent}DotNetFrameworkVersion = '4.7.2'");

                // RequiredModules
                if (!IsUndefined("${$project.metadata.requiredModulesAsString}"))
                {
                    sb.AppendLine($@"{Indent}RequiredModules = @({"${$project.metadata.requiredModulesAsString}"})");
                }

                // RequiredAssemblies
                if (!IsUndefined("${$project.metadata.requiredAssembliesAsString}"))
                {
                    sb.AppendLine($@"{Indent}RequiredAssemblies = @({"${$project.metadata.requiredAssembliesAsString}"})");
                }
                else
                {
                    sb.AppendLine($@"{Indent}RequiredAssemblies = '{"${$project.dll}"}'");
                }

                // NestedModules
                if (!IsUndefined("${$project.metadata.nestedModulesAsString}"))
                {
                    sb.AppendLine($@"{Indent}NestedModules = @({"${$project.metadata.nestedModulesAsString}"})");
                }

                // FormatsToProcess
                if (!IsUndefined("${$project.metadata.formatsToProcessAsString}"))
                {
                    sb.AppendLine($@"{Indent}FormatsToProcess = @({"${$project.metadata.formatsToProcessAsString}"})");
                }
                else
                {
                    var customFormatPs1xmlFiles = Directory.GetFiles(CustomFolder)
                        .Where(f => f.EndsWith(".format.ps1xml"))
                        .Select(f => $"{CustomFolderRelative}/{Path.GetFileName(f)}");
                    var formatList = customFormatPs1xmlFiles.Prepend("${$project.formatPs1xml}").ToPsList();
                    sb.AppendLine($@"{Indent}FormatsToProcess = {formatList}");
                }

                // TypesToProcess
                if (!IsUndefined("${$project.metadata.typesToProcessAsString}"))
                {
                    sb.AppendLine($@"{Indent}TypesToProcess = @({"${$project.metadata.typesToProcessAsString}"})");
                }

                // ScriptsToProcess
                if (!IsUndefined("${$project.metadata.scriptsToProcessAsString}"))
                {
                    sb.AppendLine($@"{Indent}ScriptsToProcess = @({"${$project.metadata.scriptsToProcessAsString}"})");
                }

                var functionInfos = GetScriptCmdlets(ExportsFolder).ToArray();
                // FunctionsToExport
                if (!IsUndefined("${$project.metadata.functionsToExportAsString}"))
                {
                    sb.AppendLine($@"{Indent}FunctionsToExport = @({"${$project.metadata.functionsToExportAsString}"})");
                }
                else
                {
                    var cmdletsList = functionInfos.Select(fi => fi.Name).Distinct().Append("*").ToPsList();
                    sb.AppendLine($@"{Indent}FunctionsToExport = {cmdletsList}");
                }

                // AliasesToExport
                if (!IsUndefined("${$project.metadata.aliasesToExportAsString}"))
                {
                    sb.AppendLine($@"{Indent}AliasesToExport = @({"${$project.metadata.aliasesToExportAsString}"})");
                }
                else
                {
                    var aliasesList = functionInfos.SelectMany(fi => fi.ScriptBlock.Attributes).ToAliasNames().Append("*").ToPsList();
                    sb.AppendLine($@"{Indent}AliasesToExport = {aliasesList}");
                }

                // CmdletsToExport
                if (!IsUndefined("${$project.metadata.cmdletsToExportAsString}"))
                {
                    sb.AppendLine($@"{Indent}CmdletsToExport = @({"${$project.metadata.cmdletsToExportAsString}"})");
                }

                sb.AppendLine($@"{Indent}PrivateData = @{{");
                sb.AppendLine($@"{Indent}{Indent}PSData = @{{");

                if (previewVersion != null)
                {
                    sb.AppendLine($@"{Indent}{Indent}{Indent}Prerelease = {previewVersion}");
                }
                sb.AppendLine($@"{Indent}{Indent}{Indent}Tags = {"${$project.metadata.tags}".Split(' ').ToPsList().NullIfEmpty() ?? "''"}");
                sb.AppendLine($@"{Indent}{Indent}{Indent}LicenseUri = '{"${$project.metadata.licenseUri}"}'");
                sb.AppendLine($@"{Indent}{Indent}{Indent}ProjectUri = '{"${$project.metadata.projectUri}"}'");
                sb.AppendLine($@"{Indent}{Indent}{Indent}ReleaseNotes = ''");
                var profilesList = "${$project.profiles.map(each => `'` + each + `'`).join(', ')}";
                if (IsAzure && !String.IsNullOrEmpty(profilesList))
                {
                    sb.AppendLine($@"{Indent}{Indent}{Indent}Profiles = {profilesList}");
                }

                sb.AppendLine($@"{Indent}{Indent}}}");
                sb.AppendLine($@"{Indent}}}");
                sb.AppendLine(@"}");

                File.WriteAllText(Psd1Path, sb.ToString());
            }
            catch (Exception ee)
            {
                Console.WriteLine($"${ee.GetType().Name}/{ee.StackTrace}");
                throw ee;
            }
        }
    }
}
