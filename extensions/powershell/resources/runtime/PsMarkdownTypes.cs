using System;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

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

        public MarkdownHelpInfo(VariantGroup variantGroup, PsHelpInfo helpInfo, string externalHelpFilename = "")
        {
            ExternalHelpFilename = externalHelpFilename;
            ModuleName = helpInfo.ModuleName;
            OnlineVersion = helpInfo.OnlineVersion?.Uri?.NullIfEmpty() ?? variantGroup.Link;
            Schema = Version.Parse("2.0.0");

            CmdletName = variantGroup.CmdletName;
            Aliases = helpInfo.Aliases.NullIfEmpty() ?? variantGroup.Aliases;
            Synopsis = helpInfo.Synopsis.NullIfEmpty() ?? variantGroup.Description;
            Description = helpInfo.Description.NullIfEmpty() ?? variantGroup.Description;

            var syntaxTexts = variantGroup.Variants.FirstOrDefault(v => v.HasParameterSets)?.Info?.GetSyntax()?.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries) ??
                              variantGroup.Variants.Select(v => v.Info.GetSyntax()?.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()).ToArray();
            var parameterSetNames = variantGroup.Variants.Select(v => v.VariantName).ToArray();
            var defaultParameterSet = variantGroup.DefaultParameterSetName;
            SyntaxInfos = syntaxTexts.Zip(parameterSetNames, (st, psn) => new MarkdownSyntaxHelpInfo(psn, st, psn == defaultParameterSet)).ToArray();

            Examples = helpInfo.Examples.Select(e => e.ToExampleHelpInfo()).ToArray().NullIfEmpty() ??
                       new []{ new MarkdownExampleHelpInfo("Example 1", @"PS C:\> {{ Add example code here }}", @"{{ Add example description here }}") };
            //Parameters = helpInfo.Parameters.Join(variantGroup.Variants.ToParameterGroups(),
            //    phi => phi.Name, pg => pg.ParameterName, (phi, pg) => new MarkdownParameterHelpInfo(phi, pg)).ToArray();

            var parameterGroups = variantGroup.Variants.ToParameterGroups().Where(pg => !pg.DontShow).ToArray();
            Parameters = parameterGroups
                .Join(helpInfo.Parameters, pg => pg.ParameterName, phi => phi.Name, (pg, phi) => new MarkdownParameterHelpInfo(phi, pg))
                .OrderBy(phi => phi.Name).ToArray();

            Inputs = helpInfo.InputTypes.Select(it => it.Name).ToArray().NullIfEmpty() ??
                     parameterGroups.Where(pg => pg.IsInputType).Select(pg => pg.ParameterType.FullName).ToArray();
            Outputs = helpInfo.OutputTypes.Select(ot => ot.Name).ToArray().NullIfEmpty() ??
                      variantGroup.OutputTypes.Select(ot => ot.Type.FullName).ToArray();
            RelatedLinks = helpInfo.RelatedLinks.Select(rl => rl.Text).ToArray();

            SupportsShouldProcess = variantGroup.SupportsShouldProcess;
            SupportsPaging = variantGroup.SupportsPaging;
        }
    }

    internal class MarkdownSyntaxHelpInfo
    {
        public bool IsDefault { get; }
        public string ParameterSetName { get; }
        public string SyntaxText { get; }

        public MarkdownSyntaxHelpInfo(string parameterSetName, string syntaxText, bool isDefault)
        {
            ParameterSetName = parameterSetName;
            SyntaxText = syntaxText;
            IsDefault = isDefault;
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
            var firstParameter = parameterGroup.Parameters.First();
            Description = parameterHelpInfo.Description.NullIfEmpty() ?? firstParameter.ParameterAttribute.HelpMessage;
            Type = parameterGroup.ParameterType;
            Position = parameterHelpInfo.PositionText.ToUpperFirstCharacter().NullIfEmpty() ?? firstParameter.Position?.ToString() ?? "Named";
            DefaultValue = parameterHelpInfo.DefaultValueAsString.NullIfEmpty() ?? firstParameter.DefaultValue?.Value?.ToString() ?? "None";

            HasAllParameterSets = parameterGroup.HasAllVariants;
            ParameterSetNames = parameterHelpInfo.ParameterSetNames.NullIfEmpty() ?? parameterGroup.Parameters.Select(p => p.VariantName).ToArray();
            Aliases = parameterHelpInfo.Aliases.NullIfEmpty() ?? parameterGroup.Aliases;

            IsRequired = parameterHelpInfo.IsRequired ?? parameterGroup.IsMandatory;
            IsDynamic = parameterHelpInfo.IsDynamic ?? false;
            AcceptsPipelineByValue = parameterHelpInfo.SupportsPipelineInput?.Contains("ByValue") ?? firstParameter.ValueFromPipeline;
            AcceptsPipelineByPropertyName = parameterHelpInfo.SupportsPipelineInput?.Contains("ByPropertyName") ?? firstParameter.ValueFromPipelineByPropertyName;
            AcceptsWildcardCharacters = parameterGroup.SupportsWildcards;
        }
    }

    internal static class MarkdownTypesExtensions
    {
        public static MarkdownExampleHelpInfo ToExampleHelpInfo(this PsHelpExampleInfo exampleInfo) => new MarkdownExampleHelpInfo(exampleInfo.Title, exampleInfo.Code, exampleInfo.Remarks);

        public static string GetSyntax(this CommandInfo commandInfo)
            => typeof(CommandInfo).GetProperties(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault(pi => pi.Name == "Syntax")?.GetValue(commandInfo) as string;

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
                Aliases = new [] { "cf" },
                IsRequired = false,
                IsDynamic = false,
                AcceptsPipelineByValue = false,
                AcceptsPipelineByPropertyName = false,
                AcceptsWildcardCharacters = false
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
                Aliases = new [] { "wi" },
                IsRequired = false,
                IsDynamic = false,
                AcceptsPipelineByValue = false,
                AcceptsPipelineByPropertyName = false,
                AcceptsWildcardCharacters = false
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
                Aliases = new string[0],
                IsRequired = false,
                IsDynamic = false,
                AcceptsPipelineByValue = false,
                AcceptsPipelineByPropertyName = false,
                AcceptsWildcardCharacters = false
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
                Aliases = new string[0],
                IsRequired = false,
                IsDynamic = false,
                AcceptsPipelineByValue = false,
                AcceptsPipelineByPropertyName = false,
                AcceptsWildcardCharacters = false
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
                Aliases = new string[0],
                IsRequired = false,
                IsDynamic = false,
                AcceptsPipelineByValue = false,
                AcceptsPipelineByPropertyName = false,
                AcceptsWildcardCharacters = false
            }
        };
    }
}
