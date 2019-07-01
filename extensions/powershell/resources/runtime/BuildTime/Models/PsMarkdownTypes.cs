using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.MarkdownTypesExtensions;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpOutputExtensions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal class MarkdownHelpInfo
    {
        public string ExternalHelpFilename { get; }
        public string ModuleName { get; }
        public string OnlineVersion { get; }
        public Version Schema { get; }

        public string CmdletName { get; }
        public string[] Aliases { get; }
        public string Synopsis { get; }
        public string Description { get; }

        public MarkdownSyntaxHelpInfo[] SyntaxInfos { get; }
        public MarkdownExampleHelpInfo[] Examples { get; }
        public MarkdownParameterHelpInfo[] Parameters { get; }

        public string[] Inputs { get; }
        public string[] Outputs { get; }
        public string[] RelatedLinks { get; }

        public bool SupportsShouldProcess { get; }
        public bool SupportsPaging { get; }

        public MarkdownHelpInfo(VariantGroup variantGroup, PsHelpInfo helpInfo, string examplesFolder, string externalHelpFilename = "")
        {
            ExternalHelpFilename = externalHelpFilename;
            ModuleName = helpInfo.ModuleName;
            OnlineVersion = helpInfo.OnlineVersion?.Uri?.NullIfEmpty() ?? variantGroup.Link;
            Schema = Version.Parse("2.0.0");

            CmdletName = variantGroup.CmdletName;
            Aliases = helpInfo.Aliases.NullIfEmpty() ?? variantGroup.Aliases;
            Synopsis = helpInfo.Synopsis.NullIfEmpty() ?? variantGroup.Description;
            Description = helpInfo.Description.NullIfEmpty() ?? variantGroup.Description;

            var defaultParameterSet = variantGroup.DefaultParameterSetName;
            SyntaxInfos = variantGroup.Variants.Select(v => new MarkdownSyntaxHelpInfo(v, v.VariantName == defaultParameterSet)).ToArray();

            Examples = GetExamplesFromMarkdown(examplesFolder).NullIfEmpty() 
                       ?? helpInfo.Examples.Select(e => e.ToExampleHelpInfo()).ToArray().NullIfEmpty() 
                       ?? DefaultExampleHelpInfos;

            var parameterGroups = variantGroup.ParameterGroups.Where(pg => !pg.DontShow).ToArray();
            Parameters = parameterGroups
                .Join(helpInfo.Parameters, pg => pg.ParameterName, phi => phi.Name, (pg, phi) => new MarkdownParameterHelpInfo(phi, pg))
                .OrderBy(phi => phi.Name).ToArray();

            Inputs = helpInfo.InputTypes.Where(it => it.Name.NullIfWhiteSpace() != null).Select(it => it.Name).ToArray().NullIfEmpty() ??
                     parameterGroups.Where(pg => pg.IsInputType).Select(pg => pg.ParameterType.FullName).ToArray();
            Outputs = helpInfo.OutputTypes.Where(it => it.Name.NullIfWhiteSpace() != null).Select(ot => ot.Name).ToArray().NullIfEmpty() ??
                      variantGroup.OutputTypes.Select(ot => ot.Type.FullName).ToArray();
            RelatedLinks = helpInfo.RelatedLinks.Select(rl => rl.Text).ToArray();

            SupportsShouldProcess = variantGroup.SupportsShouldProcess;
            SupportsPaging = variantGroup.SupportsPaging;
        }

        private MarkdownExampleHelpInfo[] GetExamplesFromMarkdown(string examplesFolder)
        {
            var filePath = Path.Combine(examplesFolder, $"{CmdletName}.md");
            if (!Directory.Exists(examplesFolder) || !File.Exists(filePath)) return null;

            var lines = File.ReadAllLines(filePath);
            var nameIndices = lines.Select((l, i) => l.StartsWith(ExampleNameHeader) ? i : -1).Where(i => i != -1).ToArray();
            //https://codereview.stackexchange.com/a/187148/68772
            var indexCountGroups = nameIndices.Skip(1).Append(lines.Length).Zip(nameIndices, (next, current) => (NameIndex: current, LineCount: next - current));
            var exampleGroups = indexCountGroups.Select(icg => lines.Skip(icg.NameIndex).Take(icg.LineCount).ToArray());
            return exampleGroups.Select(eg =>
            {
                var name = eg.First().Replace(ExampleNameHeader, String.Empty);
                var codeStartIndex = eg.Select((l, i) => l.StartsWith(ExampleCodeHeader) ? (int?)i : null).FirstOrDefault(i => i.HasValue);
                var codeEndIndex = eg.Select((l, i) => l.StartsWith(ExampleCodeFooter) ? (int?)i : null).FirstOrDefault(i => i.HasValue && i != codeStartIndex);
                var code = codeStartIndex.HasValue && codeEndIndex.HasValue
                    ? String.Join(Environment.NewLine, eg.Skip(codeStartIndex.Value + 1).Take(codeEndIndex.Value - (codeStartIndex.Value + 1)))
                    : String.Empty;
                var descriptionStartIndex = (codeEndIndex ?? 0) + 1;
                descriptionStartIndex = String.IsNullOrWhiteSpace(eg[descriptionStartIndex]) ? descriptionStartIndex + 1 : descriptionStartIndex;
                var descriptionEndIndex = eg.Length - 1;
                descriptionEndIndex = String.IsNullOrWhiteSpace(eg[descriptionEndIndex]) ? descriptionEndIndex - 1 : descriptionEndIndex;
                var description = String.Join(Environment.NewLine, eg.Skip(descriptionStartIndex).Take((descriptionEndIndex + 1) - descriptionStartIndex));
                return new MarkdownExampleHelpInfo(name, code, description);
            }).ToArray();
        }
    }

    internal class MarkdownSyntaxHelpInfo
    {
        public Variant Variant { get; }
        public bool IsDefault { get; }
        public string ParameterSetName { get; }
        public string SyntaxText { get; }

        public MarkdownSyntaxHelpInfo(Variant variant, bool isDefault)
        {
            Variant = variant;
            IsDefault = isDefault;
            ParameterSetName = Variant.VariantName;
            SyntaxText = CreateSyntaxFormat();
        }

        //https://github.com/PowerShell/platyPS/blob/a607a926bfffe1e1a1e53c19e0057eddd0c07611/src/Markdown.MAML/Renderer/Markdownv2Renderer.cs#L29-L32
        private const int SyntaxLineWidth = 110;
        private string CreateSyntaxFormat()
        {
            var parameterStrings = Variant.Parameters
                .Where(p => !p.DontShow)
                //https://stackoverflow.com/a/6461526/294804
                .OrderByDescending(p => p.IsMandatory).ThenByDescending(p => p.Position.HasValue).ThenBy(p => p.Position)
                .Select(p => p.ToPropertySyntaxOutput().ToString());
            if (Variant.SupportsShouldProcess)
            {
                parameterStrings = parameterStrings.Append(" [-Confirm]").Append(" [-WhatIf]");
            }
            if (Variant.SupportsPaging)
            {
                parameterStrings = parameterStrings.Append(" [-First <UInt64>]").Append(" [-IncludeTotalCount]").Append(" [-Skip <UInt64>]");
            }
            parameterStrings = parameterStrings.Append(" [<CommonParameters>]");

            var lines = new List<string>(20);
            return parameterStrings.Aggregate(Variant.CmdletName, (current, ps) =>
            {
                var combined = current + ps;
                if (combined.Length <= SyntaxLineWidth) return combined;

                lines.Add(current);
                return ps;
            }, last =>
            {
                lines.Add(last);
                return String.Join(Environment.NewLine, lines);
            });
        }
    }

    internal class MarkdownExampleHelpInfo
    {
        public string Name { get; }
        public string Code { get; }
        public string Description { get; }

        public MarkdownExampleHelpInfo(string name, string code, string description)
        {
            Name = name;
            Code = code;
            Description = description;
        }
    }

    internal class MarkdownParameterHelpInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public string Position { get; set; }
        public string DefaultValue { get; set; }

        public bool HasAllParameterSets { get; set; }
        public string[] ParameterSetNames { get; set; }
        public string[] Aliases { get; set; }

        public bool IsRequired { get; set; }
        public bool IsDynamic { get; set; }
        public bool AcceptsPipelineByValue { get; set; }
        public bool AcceptsPipelineByPropertyName { get; set; }
        public bool AcceptsWildcardCharacters { get; set; }

        // For use by common parameters that have no backing data in the objects themselves.
        public MarkdownParameterHelpInfo() { }

        public MarkdownParameterHelpInfo(PsParameterHelpInfo parameterHelpInfo, ParameterGroup parameterGroup)
        {
            Name = parameterGroup.ParameterName;
            Description = parameterHelpInfo.Description.NullIfEmpty() ?? parameterGroup.Description;
            Type = parameterGroup.ParameterType;
            Position = parameterHelpInfo.PositionText.ToUpperFirstCharacter().NullIfEmpty() ?? parameterGroup.FirstPosition?.ToString() ?? "Named";
            DefaultValue = parameterHelpInfo.DefaultValueAsString.NullIfEmpty() ?? parameterGroup.DefaultValue?.Value?.ToString() ?? "None";

            HasAllParameterSets = parameterGroup.HasAllVariants;
            ParameterSetNames = parameterHelpInfo.ParameterSetNames.NullIfEmpty() ?? parameterGroup.Parameters.Select(p => p.VariantName).ToArray();
            Aliases = parameterHelpInfo.Aliases.NullIfEmpty() ?? parameterGroup.Aliases;

            IsRequired = parameterHelpInfo.IsRequired ?? parameterGroup.IsMandatory;
            IsDynamic = parameterHelpInfo.IsDynamic ?? false;
            AcceptsPipelineByValue = parameterHelpInfo.SupportsPipelineInput?.Contains("ByValue") ?? parameterGroup.ValueFromPipeline;
            AcceptsPipelineByPropertyName = parameterHelpInfo.SupportsPipelineInput?.Contains("ByPropertyName") ?? parameterGroup.ValueFromPipelineByPropertyName;
            AcceptsWildcardCharacters = parameterGroup.SupportsWildcards;
        }
    }

    internal static class MarkdownTypesExtensions
    {
        public static MarkdownExampleHelpInfo ToExampleHelpInfo(this PsHelpExampleInfo exampleInfo) => new MarkdownExampleHelpInfo(exampleInfo.Title, exampleInfo.Code, exampleInfo.Remarks);

        public static MarkdownExampleHelpInfo[] DefaultExampleHelpInfos =
        {
            new MarkdownExampleHelpInfo("Example 1: {{ Add title here }}", $@"PS C:\> {{{{ Add code here }}}}{Environment.NewLine}{Environment.NewLine}{{{{ Add output here }}}}", @"{{ Add description here }}"),
            new MarkdownExampleHelpInfo("Example 2: {{ Add title here }}", $@"PS C:\> {{{{ Add code here }}}}{Environment.NewLine}{Environment.NewLine}{{{{ Add output here }}}}", @"{{ Add description here }}")
        };

        public static MarkdownParameterHelpInfo[] SupportsShouldProcessParameters =
        {
            new MarkdownParameterHelpInfo
            {
                Name = "Confirm",
                Description ="Prompts you for confirmation before running the cmdlet.",
                Type = typeof(SwitchParameter),
                Position = "Named",
                DefaultValue = "None",
                HasAllParameterSets = true,
                ParameterSetNames = new [] { "(All)" },
                Aliases = new [] { "cf" }
            },
            new MarkdownParameterHelpInfo
            {
                Name = "WhatIf",
                Description ="Shows what would happen if the cmdlet runs. The cmdlet is not run.",
                Type = typeof(SwitchParameter),
                Position = "Named",
                DefaultValue = "None",
                HasAllParameterSets = true,
                ParameterSetNames = new [] { "(All)" },
                Aliases = new [] { "wi" }
            }
        };

        public static MarkdownParameterHelpInfo[] SupportsPagingParameters =
        {
            new MarkdownParameterHelpInfo
            {
                Name = "First",
                Description ="Gets only the first 'n' objects.",
                Type = typeof(ulong),
                Position = "Named",
                DefaultValue = "None",
                HasAllParameterSets = true,
                ParameterSetNames = new [] { "(All)" },
                Aliases = new string[0]
            },
            new MarkdownParameterHelpInfo
            {
                Name = "IncludeTotalCount",
                Description ="Reports the number of objects in the data set (an integer) followed by the objects. If the cmdlet cannot determine the total count, it returns \"Unknown total count\".",
                Type = typeof(SwitchParameter),
                Position = "Named",
                DefaultValue = "None",
                HasAllParameterSets = true,
                ParameterSetNames = new [] { "(All)" },
                Aliases = new string[0]
            },
            new MarkdownParameterHelpInfo
            {
                Name = "Skip",
                Description ="Ignores the first 'n' objects and then gets the remaining objects.",
                Type = typeof(ulong),
                Position = "Named",
                DefaultValue = "None",
                HasAllParameterSets = true,
                ParameterSetNames = new [] { "(All)" },
                Aliases = new string[0]
            }
        };
    }
}
