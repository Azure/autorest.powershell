using System;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal class MarkdownHelpInfo
    {
        public string ExternalHelpFile { get; }
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

        public MarkdownHelpInfo(VariantGroup variantGroup, PsHelpInfo helpInfo, string externalHelpFile = "")
        {
            ExternalHelpFile = String.IsNullOrEmpty(externalHelpFile) ? String.Empty : $"external help file: {externalHelpFile}";
            ModuleName = $@"Module Name: {"${$project.moduleName}"}";
            OnlineVersion = $"online version: {helpInfo.OnlineVersion?.Uri?.NullIfEmpty() ?? variantGroup.Link}";
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

            Examples = helpInfo.Examples.Select(e => e.ToExampleHelpInfo()).ToArray();
            //Parameters = helpInfo.Parameters.Join(variantGroup.Variants.ToParameterGroups(),
            //    phi => phi.Name, pg => pg.ParameterName, (phi, pg) => new MarkdownParameterHelpInfo(phi, pg)).ToArray();

            var parameterGroups = variantGroup.Variants.ToParameterGroups().Where(pg => !pg.DontShow).ToArray();
            Parameters = parameterGroups.Join(helpInfo.Parameters, pg => pg.ParameterName, phi => phi.Name, (pg, phi) => new MarkdownParameterHelpInfo(phi, pg)).ToArray();

            Inputs = helpInfo.InputTypes.Select(it => it.Name).ToArray().NullIfEmpty() ??
                     parameterGroups.Where(pg => pg.IsInputType).Select(pg => pg.ParameterType.FullName).ToArray();
            Outputs = helpInfo.OutputTypes.Select(ot => ot.Name).ToArray().NullIfEmpty() ??
                      variantGroup.OutputTypes.Select(ot => ot.Type.FullName).ToArray();
            RelatedLinks = helpInfo.RelatedLinks.Select(rl => rl.Text).ToArray();
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
        public string Name { get; }
        public string Description { get; }
        public Type Type { get; }
        public string Position { get; }
        public string DefaultValue { get; }

        public string[] ParameterSetNames { get; }
        public string[] Aliases { get; }

        public bool IsRequired { get; }
        public bool IsDynamic { get; }
        public bool AcceptsPipelineByValue { get; }
        public bool AcceptsPipelineByPropertyName { get; }
        public bool AcceptsWildcardCharacters { get; }

        public MarkdownParameterHelpInfo(PsParameterHelpInfo parameterHelpInfo, ParameterGroup parameterGroup)
        {
            Name = parameterGroup.ParameterName;
            var firstParameter = parameterGroup.Parameters.First();
            Description = parameterHelpInfo.Description.NullIfEmpty() ?? firstParameter.ParameterAttribute.HelpMessage;
            Type = parameterGroup.ParameterType;
            Position = parameterHelpInfo.PositionText.NullIfEmpty() ?? firstParameter.Position?.ToString() ?? "Named";
            DefaultValue = parameterHelpInfo.DefaultValueAsString.NullIfEmpty() ?? firstParameter.DefaultValue?.Value?.ToString() ?? "None";

            ParameterSetNames = parameterHelpInfo.ParameterSetNames.NullIfEmpty() ?? parameterGroup.AllVariantNames;
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
    }
}
