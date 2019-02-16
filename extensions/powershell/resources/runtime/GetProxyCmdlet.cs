using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Text.RegularExpressions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.Get, "ProxyCmdlet")]
    [OutputType(typeof(string))]
    public class GetProxyCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public CommandInfo[] CommandInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        private const string Indent = "    ";

        protected override void ProcessRecord()
        {
            var cmdletGroups = CommandInfo.Select(ci =>
            {
                var metadata = new CommandMetadata(ci);
                var parts = metadata.Name.Split('_');
                return (name: parts[0], variant: parts.Length > 1 ? parts[1] : "default", info: ci, metadata: metadata);
            }).GroupBy(cg => cg.name);
            foreach (var cmdletGroup in cmdletGroups)
            {
                var cmdletName = cmdletGroup.Key;
                var sb = new StringBuilder();
                sb.AppendLine($"function {cmdletName} {{");

                var outputType = cmdletGroup.SelectMany(cg => cg.info.OutputType).FirstOrDefault();
                var outputTypeText = outputType != null ? $"[OutputType('{outputType}')]{Environment.NewLine}" : String.Empty;
                sb.Append(outputTypeText);

                var variantParameterCounts = cmdletGroup.Select(cg => (variant: cg.variant, paramCount: cg.metadata.Parameters.Count)).ToArray();
                var smallestParameterCount = variantParameterCounts.Min(vpc => vpc.paramCount);
                var defaultParameterSet = variantParameterCounts.First(vpc => vpc.paramCount == smallestParameterCount).variant;

                var hasMultipleVariants = cmdletGroup.Count() > 1;
                var dpsText = hasMultipleVariants ? $"DefaultParameterSetName='{defaultParameterSet}'" : String.Empty;
                var supportsShouldProcess = cmdletGroup.Any(cg => cg.metadata.SupportsShouldProcess);
                var sspText = supportsShouldProcess ? $"{(hasMultipleVariants ? ", " : String.Empty)}SupportsShouldProcess={true.ToPsBool()}, ConfirmImpact='Medium'" : String.Empty;
                sb.AppendLine($"[CmdletBinding({dpsText}{sspText})]");
                sb.AppendLine("param(");

                var allVariants = cmdletGroup.Select(cg => cg.variant).ToArray();
                var parameterGroups = cmdletGroup
                    .SelectMany(cg => cg.metadata.Parameters.Select(p => (variant: cg.variant, parameter: p)))
                    .GroupBy(p => p.parameter.Key) // Parameter key is the Parameter name
                    .ToList();
                foreach (var parameterGroup in parameterGroups)
                {
                    var hasAllVariants = !allVariants.Except(parameterGroup.Select(pg => pg.variant)).Any();
                    var filteredParameterGroup = hasAllVariants ? parameterGroup.Take(1) : parameterGroup;
                    foreach (var variantGroup in filteredParameterGroup)
                    {
                        var paramMetadata = variantGroup.parameter.Value;
                        var paramAttribute = paramMetadata.Attributes.OfType<ParameterAttribute>().First();

                        var psnText = hasMultipleVariants && !hasAllVariants ? $"ParameterSetName='{variantGroup.variant}', " : String.Empty;
                        var mandatoryText = paramAttribute.Mandatory ? $"Mandatory={paramAttribute.Mandatory.ToPsBool()}, " : String.Empty;
                        var dontShowText = paramAttribute.DontShow ? $"DontShow={paramAttribute.DontShow.ToPsBool()}, " : String.Empty;
                        var vfpText = paramAttribute.ValueFromPipeline ? $"ValueFromPipeline={paramAttribute.ValueFromPipeline.ToPsBool()}, " : String.Empty;
                        var helpText = $"HelpMessage='{paramAttribute.HelpMessage}'";
                        sb.AppendLine($"{Indent}[Parameter({psnText}{mandatoryText}{dontShowText}{vfpText}{helpText})]");
                    }
                    var aliases = parameterGroup.SelectMany(pg => pg.parameter.Value.Attributes.OfType<AliasAttribute>()).FirstOrDefault();
                    var aliasText = aliases != null ? $"{Indent}[Alias({String.Join(",", aliases.AliasNames.Select(an => $"'{an}'"))})]{Environment.NewLine}" : String.Empty;
                    sb.Append(aliasText);

                    var hasVnn = parameterGroup.SelectMany(pg => pg.parameter.Value.Attributes.OfType<ValidateNotNullAttribute>()).Any();
                    var vnnText = hasVnn ? $"{Indent}[ValidateNotNull()]{Environment.NewLine}" : String.Empty;
                    sb.Append(vnnText);

                    var parameterTypeText = parameterGroup.Select(pg => pg.parameter.Value.ParameterType).First().ToPsType();
                    var hasArgumentCompleter = parameterGroup.SelectMany(pg => pg.parameter.Value.Attributes.OfType<ArgumentCompleterAttribute>()).Any();
                    var acText = hasArgumentCompleter ? $"{Indent}[ArgumentCompleter([{parameterTypeText}])]{Environment.NewLine}" : String.Empty;
                    sb.Append(acText);

                    sb.AppendLine($"{Indent}[{parameterTypeText}]");

                    var parameterName = parameterGroup.Key;
                    var parameterSeparator = parameterGroups.IndexOf(parameterGroup) == parameterGroups.Count - 1 ? ")" : ",";
                    sb.AppendLine($"{Indent}${{{parameterName}}}{parameterSeparator}{Environment.NewLine}");
                }

                sb.AppendLine("begin {");
                var sourceText = cmdletGroup.Select(cg => cg.info.Source).First();
                var variantText = hasMultipleVariants ? "_$($PsCmdlet.ParameterSetName)" : String.Empty;
                var beginText = $@"{Indent}try {{
{Indent}{Indent}$outBuffer = $null
{Indent}{Indent}if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {{
{Indent}{Indent}{Indent}$PSBoundParameters['OutBuffer'] = 1
{Indent}{Indent}}}
{Indent}{Indent}$wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(""{sourceText}\{cmdletName}{variantText}"", [System.Management.Automation.CommandTypes]::Cmdlet)
{Indent}{Indent}$scriptCmd = {{& $wrappedCmd @PSBoundParameters}}
{Indent}{Indent}$steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
{Indent}{Indent}$steppablePipeline.Begin($PSCmdlet)
{Indent}}} catch {{
{Indent}{Indent}throw
{Indent}}}";
                sb.AppendLine(beginText);
                sb.AppendLine($"}}{Environment.NewLine}");

                sb.AppendLine("process {");
                var processText = $@"{Indent}try {{
{Indent}{Indent}$steppablePipeline.Process($_)
{Indent}}} catch {{
{Indent}{Indent}throw
{Indent}}}";
                sb.AppendLine(processText);
                sb.AppendLine($"}}{Environment.NewLine}");

                sb.AppendLine("end {");
                var endText = $@"{Indent}try {{
{Indent}{Indent}$steppablePipeline.End()
{Indent}}} catch {{
{Indent}{Indent}throw
{Indent}}}";
                sb.AppendLine(endText);
                sb.AppendLine($"}}{Environment.NewLine}");

                sb.AppendLine("<#");
                var helpVariantText = hasMultipleVariants ? $"_{defaultParameterSet}" : String.Empty;
                sb.AppendLine($".ForwardHelpTargetName {sourceText}\\{cmdletName}{helpVariantText}");
                sb.AppendLine(".ForwardHelpCategory Cmdlet");
                var cmdletDescription = cmdletGroup.Select(cg => cg.metadata.HelpUri).FirstOrDefault();
                sb.AppendLine($".Description{Environment.NewLine}{cmdletDescription}");
                sb.AppendLine("#>");

                sb.AppendLine("}");

                File.WriteAllText(Path.Combine(OutputFolder, $"{cmdletName}.ps1"), sb.ToString());
            }
        }
    }

    public static class PsExtensions
    {
        public static string ToPsBool(this bool value) => $"${value.ToString().ToLowerInvariant()}";

        public static string ToPsType(this Type type)
        {
            var regex = new Regex(@"^(.*)`{1}\d+(.*)$");
            var match = regex.Match(type.ToString());
            return match.Success ? $"{match.Groups[1]}{match.Groups[2]}" : type.ToString();
        }
    }
}
