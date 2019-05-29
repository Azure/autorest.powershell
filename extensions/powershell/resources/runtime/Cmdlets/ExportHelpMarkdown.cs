using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static Microsoft.Rest.ClientRuntime.PowerShell.MarkdownTypesExtensions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "HelpMarkdown")]
    [DoNotExport]
    public class ExportHelpMarkdown : PSCmdlet
    {
        //[Parameter(Mandatory = true)]
        //[ValidateNotNullOrEmpty]
        //public string ModuleName { get; set; }

        //[Parameter(Mandatory = true)]
        //[ValidateNotNullOrEmpty]
        //public string ModuleDescription { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public PSModuleInfo ModuleInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public PSObject[] FunctionInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public PSObject[] HelpInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string DocsFolder { get; set; }

        protected override void ProcessRecord()
        {
            Directory.CreateDirectory(DocsFolder);
            var variantGroups = FunctionInfo.Select(fi => fi.BaseObject).Cast<FunctionInfo>()
                .Select(fi => fi.ToVariants())
                .Select(va => new VariantGroup(va.First().CmdletName, va, String.Empty))
                .ToArray();
            var helpInfos = HelpInfo.Select(hi => hi.ToPsHelpInfo()).ToArray();
            var markdownInfos = variantGroups.Join(helpInfos, vg => vg.CmdletName, phi => phi.CmdletName, (vg, phi) => new MarkdownHelpInfo(vg, phi)).ToArray();

            foreach (var markdownInfo in markdownInfos)
            {
                var sb = new StringBuilder();
                sb.Append(markdownInfo.ToHelpMetadataOutput());
                sb.Append($"# {markdownInfo.CmdletName}{Environment.NewLine}{Environment.NewLine}");
                sb.Append($"## SYNOPSIS{Environment.NewLine}{markdownInfo.Synopsis.ReplaceSentenceEndWithNewline()}{Environment.NewLine}{Environment.NewLine}");

                sb.Append($"## SYNTAX{Environment.NewLine}{Environment.NewLine}");
                var hasMultipleParameterSets = markdownInfo.SyntaxInfos.Length > 1;
                foreach (var syntaxInfo in markdownInfo.SyntaxInfos)
                {
                    sb.Append(syntaxInfo.ToHelpSyntaxOutput(hasMultipleParameterSets));
                }

                sb.Append($"## DESCRIPTION{Environment.NewLine}{markdownInfo.Description.ReplaceSentenceEndWithNewline()}{Environment.NewLine}{Environment.NewLine}");

                sb.Append($"## EXAMPLES{Environment.NewLine}{Environment.NewLine}");
                foreach(var exampleInfo in markdownInfo.Examples)
                {
                    sb.Append(exampleInfo.ToHelpExampleOutput());
                }

                sb.Append($"## PARAMETERS{Environment.NewLine}{Environment.NewLine}");
                foreach (var parameter in markdownInfo.Parameters)
                {
                    sb.Append(parameter.ToHelpParameterOutput());
                }
                if (markdownInfo.SupportsShouldProcess)
                {
                    foreach (var parameter in SupportsShouldProcessParameters)
                    {
                        sb.Append(parameter.ToHelpParameterOutput());
                    }
                }
                if (markdownInfo.SupportsPaging)
                {
                    foreach (var parameter in SupportsPagingParameters)
                    {
                        sb.Append(parameter.ToHelpParameterOutput());
                    }
                }

                sb.Append($"### CommonParameters{Environment.NewLine}This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).{Environment.NewLine}{Environment.NewLine}");

                sb.Append($"## INPUTS{Environment.NewLine}{Environment.NewLine}");
                foreach (var input in markdownInfo.Inputs)
                {
                    sb.Append($"### {input}{Environment.NewLine}{Environment.NewLine}");
                }

                sb.Append($"## OUTPUTS{Environment.NewLine}{Environment.NewLine}");
                foreach (var output in markdownInfo.Outputs)
                {
                    sb.Append($"### {output}{Environment.NewLine}{Environment.NewLine}");
                }

                sb.Append($"## ALIASES{Environment.NewLine}{Environment.NewLine}");
                foreach (var alias in markdownInfo.Aliases)
                {
                    sb.Append($"### {alias}{Environment.NewLine}{Environment.NewLine}");
                }

                // Removed NOTES since we don't have support for it.
                //sb.Append($"## NOTES{Environment.NewLine}{Environment.NewLine}");

                sb.Append($"## RELATED LINKS{Environment.NewLine}{Environment.NewLine}");
                foreach (var relatedLink in markdownInfo.RelatedLinks)
                {
                    sb.Append($"{relatedLink}{Environment.NewLine}{Environment.NewLine}");
                }

                File.WriteAllText(Path.Combine(DocsFolder, $"{markdownInfo.CmdletName}.md"), sb.ToString());
            }

            WriteModulePage(markdownInfos);
        }

        private void WriteModulePage(MarkdownHelpInfo[] markdownInfos)
        {
            var sb = new StringBuilder();
            sb.Append(ModuleInfo.ToModulePageMetadataOutput());
            sb.Append($"# {ModuleInfo.Name} Module{Environment.NewLine}");
            sb.Append($"## Description{Environment.NewLine}{ModuleInfo.Description.ReplaceSentenceEndWithNewline()}{Environment.NewLine}{Environment.NewLine}");

            sb.Append($"## {ModuleInfo.Name} Cmdlets{Environment.NewLine}");
            foreach (var markdownInfo in markdownInfos)
            {
                sb.Append(markdownInfo.ToModulePageCmdletOutput());
            }

            File.WriteAllText(Path.Combine(DocsFolder, $"{ModuleInfo.Name}.md"), sb.ToString());
        }
    }
}
