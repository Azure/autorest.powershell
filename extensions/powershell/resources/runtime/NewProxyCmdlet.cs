using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsCommon.New, "ProxyCmdlet")]
    [OutputType(typeof(string))]
    public class NewProxyCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public CommandInfo[] CommandInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        protected override void ProcessRecord()
        {
            var variantsGroups = CommandInfo
                .Select(ci => ci.ToVariant())
                .GroupBy(v => v.CmdletName)
                .Select(vg => new VariantGroup(vg.Key, vg.Select(v => v).ToArray()));

            foreach (var variantGroup in variantsGroups)
            {
                var sb = new StringBuilder();
                sb.Append(variantGroup.ToHelpCommentOutput());
                sb.Append($"function {variantGroup.CmdletName} {{{Environment.NewLine}");
                sb.Append(variantGroup.OutputTypes.ToOutputTypeOutput());
                sb.Append(variantGroup.ToCmdletBindingOutput());

                sb.Append("param(");
                var allVariantNames = variantGroup.Variants.Select(vg => vg.VariantName).ToArray();
                var parameterGroups = variantGroup.Variants
                    .SelectMany(v => v.ToParameters())
                    .GroupBy(p => p.ParameterName)
                    .Select(pg => new ParameterGroup(pg.Key, pg.Select(p => p).ToArray(), allVariantNames))
                    .ToList();
                sb.Append($"{(parameterGroups.Any() ? Environment.NewLine : String.Empty)}");
                foreach (var parameterGroup in parameterGroups)
                {
                    var parameters = parameterGroup.HasAllVariants ? parameterGroup.Parameters.Take(1) : parameterGroup.Parameters;
                    foreach (var parameter in parameters)
                    {
                        sb.Append(parameter.ToParameterOutput(variantGroup.HasMultipleVariants, parameterGroup.HasAllVariants));
                    }
                    sb.Append(parameterGroup.Alias.ToAliasOutput());
                    sb.Append(parameterGroup.HasValidateNotNull.ToValidateNotNullOutput());
                    sb.Append(parameterGroup.ToArgumentCompleterOutput());
                    sb.Append(parameterGroup.ParameterType.ToParameterTypeOutput());
                    sb.Append(parameterGroup.ParameterName.ToParameterNameOutput(parameterGroups.IndexOf(parameterGroup) == parameterGroups.Count - 1));
                }
                sb.Append($"){Environment.NewLine}{Environment.NewLine}");

                sb.Append(variantGroup.ToBeginOutput());
                sb.Append(variantGroup.ToProcessOutput());
                sb.Append(variantGroup.ToEndOutput());

                sb.Append($"}}{Environment.NewLine}");

                File.WriteAllText(Path.Combine(OutputFolder, $"{variantGroup.CmdletName}.ps1"), sb.ToString());
            }
        }
    }
}
