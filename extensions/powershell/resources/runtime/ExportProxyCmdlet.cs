using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "ProxyCmdlet")]
    [DoNotExport]
    public class ExportProxyCmdlet : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string[] ModulePath { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ExportsFolder { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string InternalFolder { get; set; }

        protected override void ProcessRecord()
        {
            var variants = GetModuleCmdlets(this, ModulePath)
                .SelectMany(ci => ci.ToVariants())
                .Where(v => !v.IsDoNotExport)
                .ToArray();
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
                    .GroupBy(v => new { v.CmdletName, v.IsInternal })
                    .Select(vg => new VariantGroup(vg.Key.CmdletName, vg.Select(v => v).ToArray(),
                        Path.Combine(vg.Key.IsInternal ? InternalFolder : ExportsFolder, profileGroup.ProfileFolder),
                        profileGroup.ProfileName));

                foreach (var variantGroup in variantGroups)
                {
                    var sb = new StringBuilder();
                    sb.Append(variantGroup.ToHelpCommentOutput());
                    sb.Append($"function {variantGroup.CmdletName} {{{Environment.NewLine}");
                    sb.Append(variantGroup.Aliases.ToAliasOutput());
                    sb.Append(variantGroup.OutputTypes.ToOutputTypeOutput());
                    sb.Append(variantGroup.ToCmdletBindingOutput());
                    sb.Append(variantGroup.ProfileName.ToProfileOutput());
                    sb.Append(variantGroup.Description.ToDescriptionOutput());

                    sb.Append("param(");
                    var allVariantNames = variantGroup.Variants.Select(vg => vg.VariantName).ToArray();
                    var parameterGroups = variantGroup.Variants
                        .SelectMany(v => v.ToParameters())
                        .GroupBy(p => p.ParameterName, StringComparer.InvariantCultureIgnoreCase)
                        .Select(pg => new ParameterGroup(pg.Key, pg.Select(p => p).ToArray(), allVariantNames))
                        .OrderBy(pg => pg.OrderCategory)
                        .ToList();
                    sb.Append($"{(parameterGroups.Any() ? Environment.NewLine : String.Empty)}");
                    foreach (var parameterGroup in parameterGroups)
                    {
                        var parameters = parameterGroup.HasAllVariants ? parameterGroup.Parameters.Take(1) : parameterGroup.Parameters;
                        foreach (var parameter in parameters)
                        {
                            sb.Append(parameter.ToParameterOutput(variantGroup.HasMultipleVariants, parameterGroup.HasAllVariants));
                        }
                        sb.Append(parameterGroup.Aliases.ToAliasOutput(true));
                        sb.Append(parameterGroup.HasValidateNotNull.ToValidateNotNullOutput());
                        sb.Append(parameterGroup.ToArgumentCompleterOutput());
                        sb.Append(parameterGroup.OrderCategory.ToParameterCategoryOutput());
                        sb.Append(parameterGroup.ParameterType.ToParameterTypeOutput());
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
