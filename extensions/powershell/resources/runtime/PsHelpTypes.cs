using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal class PsHelpInfo
    {
        public string CmdletName { get; }
        public string ModuleName { get; }
        public string Synopsis { get; }
        public string Description { get; }
        public string AlertText { get; }
        public string Category { get; }
        public PsHelpLinkInfo OnlineVersion { get; }
        public PsHelpLinkInfo[] RelatedLinks { get; }

        public PsHelpTypeInfo[] InputTypes { get; }
        public PsHelpTypeInfo[] OutputTypes { get; }
        public PsHelpExampleInfo[] Examples { get; }

        public PsParameterHelpInfo[] Parameters { get; }
        public PsHelpSyntaxInfo[] Syntax { get; }

        public object Component { get; }
        public object Functionality { get; }
        public object PsSnapIn { get; }
        public object Role { get; }
        

        public PsHelpInfo(PSObject helpObject)
        {
            CmdletName = helpObject.GetProperty<string>("Name").EmptyAsNull() ?? helpObject.GetNestedProperty<string>("details", "name");
            ModuleName = helpObject.GetProperty<string>("ModuleName");
            Synopsis = helpObject.GetProperty<string>("Synopsis");
            Description = helpObject.GetProperty<PSObject[]>("description").ToDescriptionText().EmptyAsNull() ?? 
                          helpObject.GetNestedProperty<PSObject[]>("details", "description").ToDescriptionText();
            AlertText = helpObject.GetNestedProperty<PSObject[]>("alertSet", "alert").ToDescriptionText();
            Category = helpObject.GetProperty<string>("Category");

            var links = helpObject.GetNestedProperty<PSObject[]>("relatedLinks", "navigationLink").Select(nl => nl.ToLinkInfo()).ToArray();
            OnlineVersion = links.FirstOrDefault(l => l.Text.ToLowerInvariant().StartsWith("online version:"));
            RelatedLinks = links.Where(l => !l.Text.ToLowerInvariant().StartsWith("online version:")).ToArray();

            //// navigationLink can be either a single item or an array of items.
            //OutputTypeNames = helpObject.GetNestedProperty<PSObject[]>("returnValues", "returnValue").Select(rv => rv.GetNestedProperty<string>("type", "name")).ToArray();
            //OutputTypeNames = OutputTypeNames.Any() ? OutputTypeNames : new []{ helpObject.GetNestedProperty<string>("returnValues", "returnValue", "type", "name") };

            InputTypes = helpObject.GetNestedProperty<PSObject[]>("inputTypes", "inputType").Select(it => it.ToTypeInfo()).ToArray();
            OutputTypes = helpObject.GetNestedProperty<PSObject[]>("returnValues", "returnValue").Select(rv => rv.ToTypeInfo()).ToArray();
            Examples = helpObject.GetNestedProperty<PSObject[]>("examples", "example").Select(e => e.ToExampleInfo()).ToArray();

            Parameters = helpObject.GetNestedProperty<PSObject[]>("parameters", "parameter").Select(p => p.ToPsParameterHelpInfo()).ToArray();
            Syntax = helpObject.GetNestedProperty<PSObject[]>("syntax", "syntaxItem").Select(si => si.ToSyntaxInfo()).ToArray();

            Component = helpObject.GetProperty<object>("Component");
            Functionality = helpObject.GetProperty<object>("Functionality");
            PsSnapIn = helpObject.GetProperty<object>("PSSnapIn");
            Role = helpObject.GetProperty<object>("Role");
        }
    }

    internal class PsHelpTypeInfo
    {
        public string Name { get; }
        public string Description { get; }

        public PsHelpTypeInfo(PSObject typeObject)
        {
            Name = typeObject.GetNestedProperty<string>("type", "name");
            Description = typeObject.GetProperty<PSObject[]>("description").ToDescriptionText();
        }
    }

    internal class PsHelpLinkInfo
    {
        public string Uri { get; }
        public string Text { get; }

        public PsHelpLinkInfo(PSObject linkObject)
        {
            Uri = linkObject.GetProperty<string>("uri");
            Text = linkObject.GetProperty<string>("linkText");
        }
    }

    internal class PsHelpSyntaxInfo
    {
        public string CmdletName { get; }
        public PsParameterHelpInfo[] Parameters { get; }

        public PsHelpSyntaxInfo(PSObject syntaxObject)
        {
            CmdletName = syntaxObject.GetProperty<string>("name");
            Parameters = syntaxObject.GetProperty<PSObject[]>("parameter").Select(p => p.ToPsParameterHelpInfo()).ToArray();
        }
    }

    internal class PsHelpExampleInfo
    {
        public string Title { get; }
        public string Code { get; }
        public string Remarks { get; }

        public PsHelpExampleInfo(PSObject exampleObject)
        {
            Title = exampleObject.GetProperty<string>("title");
            Code = exampleObject.GetProperty<string>("code");
            Remarks = exampleObject.GetProperty<PSObject[]>("remarks").ToDescriptionText();
        }
    }

    internal class PsParameterHelpInfo
    {
        public string DefaultValueAsString { get; }
        public bool SupportsGlobbing { get; }
        public string Name { get; }
        public string TypeName { get; }
        public string SupportsPipelineInput { get; }
        public string PositionText { get; }
        public bool IsRequired { get; }

        public PsParameterHelpInfo(PSObject parameterHelpObject)
        {
            DefaultValueAsString = parameterHelpObject.GetProperty<string>("defaultValue");
            SupportsGlobbing = Convert.ToBoolean(parameterHelpObject.GetProperty<string>("globbing").ToLowerInvariant());
            Name = parameterHelpObject.GetProperty<string>("name");
            TypeName = parameterHelpObject.GetProperty<string>("parameterValue").EmptyAsNull() ?? parameterHelpObject.GetNestedProperty<string>("type", "name");
            SupportsPipelineInput = parameterHelpObject.GetProperty<string>("pipelineInput");
            PositionText = parameterHelpObject.GetProperty<string>("position");
            IsRequired = Convert.ToBoolean(parameterHelpObject.GetProperty<string>("required").ToLowerInvariant());
        }
    }

    internal class MarkdownHelpInfo
    {
        public string ExternalHelpFile { get; }
        public string ModuleName { get; }
        public string OnlineVersion { get; }
        public Version Schema { get; }

        public string CmdletName { get; }
        public string[] Aliases { get; }

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
            OnlineVersion = $"online version: {helpInfo.OnlineVersion?.Uri?.EmptyAsNull() ?? variantGroup.Link}";
            Schema = Version.Parse("2.0.0");

            CmdletName = variantGroup.CmdletName;
            Aliases = variantGroup.Aliases;

            var syntaxTexts = variantGroup.Variants.FirstOrDefault(v => v.HasParameterSets)?.Info?.Definition?.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries) ??
                              variantGroup.Variants.Select(v => v.Info.Definition.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()).ToArray();
            var parameterSetNames = variantGroup.Variants.Select(v => v.VariantName).ToArray();
            var defaultParameterSet = variantGroup.DefaultParameterSetName;
            SyntaxInfos = syntaxTexts.Zip(parameterSetNames, (st, psn) => new MarkdownSyntaxHelpInfo(psn, st, psn == defaultParameterSet)).ToArray();

            Examples = helpInfo.Examples.Select(e => e.ToExampleHelpInfo()).ToArray();

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
        public string[] ParameterSetNames { get; }
        public string[] Aliases { get; }

        public bool IsRequired { get; }
        public string Position { get; }
        public string DefaultValue { get; }
        public bool AcceptsPipelineByValue { get; }
        public bool AcceptsPipelineByPropertyName { get; }
        public bool AcceptsWildcardCharacters { get; }

        public MarkdownParameterHelpInfo()
        {

        }
    }

    internal static class HelpTypesExtensions
    {
        public static PsHelpInfo ToPsHelpInfo(this PSObject helpObject) => new PsHelpInfo(helpObject);
        public static PsParameterHelpInfo ToPsParameterHelpInfo(this PSObject parameterHelpObject) => new PsParameterHelpInfo(parameterHelpObject);

        public static string ToDescriptionText(this PSObject[] descriptionObject) => String.Join(Environment.NewLine, descriptionObject.Select(dl => dl.GetProperty<string>("Text")));
        public static PsHelpTypeInfo ToTypeInfo(this PSObject typeObject) => new PsHelpTypeInfo(typeObject);
        public static PsHelpExampleInfo ToExampleInfo(this PSObject exampleObject) => new PsHelpExampleInfo(exampleObject);
        public static PsHelpLinkInfo ToLinkInfo(this PSObject linkObject) => new PsHelpLinkInfo(linkObject);
        public static PsHelpSyntaxInfo ToSyntaxInfo(this PSObject syntaxObject) => new PsHelpSyntaxInfo(syntaxObject);

        public static MarkdownExampleHelpInfo ToExampleHelpInfo(this PsHelpExampleInfo exampleInfo) => new MarkdownExampleHelpInfo(exampleInfo.Title, exampleInfo.Code, exampleInfo.Remarks);
    }
}
