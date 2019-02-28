using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyTypeExtensions;

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
            var variants = CommandInfo.Select(ci => ci.ToVariant()).ToArray();
            var allProfiles = variants.SelectMany(v => v.Profiles).Distinct().ToArray();
            var profileGroups = allProfiles.Any()
                ? variants
                    .SelectMany(v => (v.Profiles.Any() ? v.Profiles : allProfiles).Select(p => (profile: p, variant: v)))
                    .GroupBy(pv => pv.profile)
                    .Select(pvg => new ProfileGroup(pvg.Select(pv => pv.variant).ToArray(), pvg.Key))
                : new[] { new ProfileGroup(variants) };

            foreach (var profileGroup in profileGroups)
            {
                var variantGroups = profileGroup.Variants
                    .GroupBy(v => v.CmdletName)
                    .Select(vg => new VariantGroup(vg.Key, vg.Select(v => v).ToArray(), Path.Combine(OutputFolder, profileGroup.ProfileFolder)));

                foreach (var variantGroup in variantGroups)
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
                        sb.Append(parameterGroup.HelpMessage.ToParameterHelpOutput());
                        sb.Append(parameterGroup.ParameterName.ToParameterNameOutput(parameterGroups.IndexOf(parameterGroup) == parameterGroups.Count - 1));
                    }
                    sb.Append($"){Environment.NewLine}{Environment.NewLine}");

                    sb.Append(variantGroup.ToBeginOutput());
                    sb.Append(variantGroup.ToProcessOutput());
                    sb.Append(variantGroup.ToEndOutput());

                    sb.Append($"}}{Environment.NewLine}");

                    Directory.CreateDirectory(variantGroup.OutputFolder);
                    File.WriteAllText(variantGroup.FilePath, sb.ToString());
                }
            }
        }
    }
}
