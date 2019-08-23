using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
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

        protected override void ProcessRecord()
        {
            if (!Directory.Exists(ExportsFolder))
            {
                throw new ArgumentException($"Exports folder '{ExportsFolder}' does not exist");
            }

            if (!Directory.Exists(CustomFolder))
            {
                throw new ArgumentException($"Custom folder '{CustomFolder}' does not exist");
            }

            var sb = new StringBuilder();
            sb.AppendLine("@{");
            sb.AppendLine($@"{GuidStart} = '{ModuleGuid}'");
            sb.AppendLine($@"{Indent}RootModule = '{"${$project.psm1}"}'");
            sb.AppendLine($@"{Indent}ModuleVersion = '{"${$project.moduleVersion}"}'");
            sb.AppendLine($@"{Indent}CompatiblePSEditions = 'Core', 'Desktop'");
            sb.AppendLine($@"{Indent}Author = '{"${$project.metadata.authors}"}'");
            sb.AppendLine($@"{Indent}CompanyName = '{"${$project.metadata.companyName}"}'");
            sb.AppendLine($@"{Indent}Copyright = '{"${$project.metadata.copyright}"}'");
            sb.AppendLine($@"{Indent}Description = '{"${$project.metadata.description}"}'");
            sb.AppendLine($@"{Indent}PowerShellVersion = '5.1'");
            sb.AppendLine($@"{Indent}DotNetFrameworkVersion = '4.7.2'");
            sb.AppendLine($@"{Indent}RequiredAssemblies = '{"${$project.dll}"}'");

            var customFormatPs1xmlFiles = Directory.GetFiles(CustomFolder)
                .Where(f => f.EndsWith(".format.ps1xml"))
                .Select(f => $"{CustomFolderRelative}/{Path.GetFileName(f)}");
            var formatList = customFormatPs1xmlFiles.Prepend("${$project.formatPs1xml}").ToPsList();
            sb.AppendLine($@"{Indent}FormatsToProcess = {formatList}");

            var functionInfos = GetScriptCmdlets(ExportsFolder).ToArray();
            var cmdletsList = functionInfos.Select(fi => fi.Name).Distinct().Append("*").ToPsList();
            sb.AppendLine($@"{Indent}CmdletsToExport = {cmdletsList}");
            var aliasesList = functionInfos.SelectMany(fi => fi.ScriptBlock.Attributes).ToAliasNames().Append("*").ToPsList();
            sb.AppendLine($@"{Indent}AliasesToExport = {aliasesList}");

            sb.AppendLine($@"{Indent}PrivateData = @{{");
            sb.AppendLine($@"{Indent}{Indent}PSData = @{{");

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
    }
}
