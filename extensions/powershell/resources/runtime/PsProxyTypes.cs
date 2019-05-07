using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyOutputExtensions;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyTypeExtensions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal class ProfileGroup
    {
        public string ProfileName { get; }
        public Variant[] Variants { get; }
        public string ProfileFolder { get; }

        public ProfileGroup(Variant[] variants, string profileName = NoProfiles)
        {
            ProfileName = profileName;
            Variants = variants;
            ProfileFolder = ProfileName != NoProfiles ? ProfileName : String.Empty;
        }
    }

    internal class VariantGroup
    {
        public string CmdletName { get; }
        public string ProfileName { get; }
        public Variant[] Variants { get; }

        public string[] Aliases { get; }
        public PSTypeName[] OutputTypes { get; }
        public bool SupportsShouldProcess { get; }
        public string DefaultParameterSetName { get; }
        public bool HasMultipleVariants { get; }
        public string Description { get; }
        public bool IsGenerated { get; }
        public string Link { get; }

        public string OutputFolder { get; }
        public string FileName { get; }
        public string FilePath { get; }

        public VariantGroup(string cmdletName, Variant[] variants, string outputFolder, string profileName = NoProfiles, bool isTest = false)
        {
            CmdletName = cmdletName;
            ProfileName = profileName;
            Variants = variants;
            Aliases = Variants.SelectMany(v => v.Attributes).ToAliasNames().ToArray();
            OutputTypes = Variants.SelectMany(v => v.Info.OutputType).GroupBy(ot => ot.Type).Select(otg => otg.First()).ToArray();
            SupportsShouldProcess = Variants.Any(v => v.Metadata.SupportsShouldProcess);
            DefaultParameterSetName = DetermineDefaultParameterSetName();
            HasMultipleVariants = Variants.Length > 1;
            Description = Variants.SelectMany(v => v.Attributes).OfType<DescriptionAttribute>().FirstOrDefault()?.Description;
            IsGenerated = Variants.All(v => v.Attributes.OfType<GeneratedAttribute>().Any());
            Link = $@"https://docs.microsoft.com/en-us/powershell/module/{@"${$project.moduleName}".ToLowerInvariant()}/{CmdletName.ToLowerInvariant()}";

            OutputFolder = outputFolder;
            FileName = $"{CmdletName}{(isTest ? ".Tests" : String.Empty)}.ps1";
            FilePath = Path.Combine(OutputFolder, FileName);
        }

        private string DetermineDefaultParameterSetName()
        {
            var defaultParameterSet = Variants
                .Select(v => v.Metadata.DefaultParameterSetName)
                .LastOrDefault(dpsn => dpsn.IsValidDefaultParameterSetName());

            if (String.IsNullOrEmpty(defaultParameterSet))
            {
                var variantParamCountGroups = Variants
                    .Select(v => (
                        variant: v.VariantName,
                        paramCount: v.CmdletOnlyParameters.Count(p => p.IsMandatory),
                        isSimple: v.CmdletOnlyParameters.Where(p => p.IsMandatory).All(p => p.Metadata.ParameterType.IsPsSimple())))
                    .GroupBy(vpc => vpc.isSimple)
                    .ToArray();
                var variantParameterCounts = (variantParamCountGroups.Any(g => g.Key) ? variantParamCountGroups.Where(g => g.Key) : variantParamCountGroups).SelectMany(g => g).ToArray();
                var smallestParameterCount = variantParameterCounts.Min(vpc => vpc.paramCount);
                defaultParameterSet = variantParameterCounts.First(vpc => vpc.paramCount == smallestParameterCount).variant;
            }

            return defaultParameterSet;
        }
    }

    internal class Variant
    {
        public string CmdletName { get; }
        public string VariantName { get; }
        public CommandInfo Info { get; }
        public CommandMetadata Metadata { get; }
        public bool IsFunction { get; }
        public string PrivateModuleName { get; }
        public string PrivateCmdletName { get; }
        public bool IsInternal { get; }
        public bool IsDoNotExport { get; }
        public bool HasParameterSets { get; }

        public Attribute[] Attributes { get; }
        public Parameter[] Parameters { get; }
        public Parameter[] CmdletOnlyParameters { get; }
        public string[] Profiles { get; }

        public Variant(string cmdletName, string variantName, CommandInfo info, CommandMetadata metadata, bool hasParameterSets = false)
        {
            CmdletName = cmdletName;
            VariantName = variantName;
            Info = info;
            Metadata = metadata;
            HasParameterSets = hasParameterSets;
            IsFunction = Info.CommandType == CommandTypes.Function;
            PrivateModuleName = Info.Source;
            PrivateCmdletName = Metadata.Name;
            Attributes = this.ToAttributes();
            Parameters = this.ToParameters();
            IsInternal = Attributes.OfType<InternalExportAttribute>().Any();
            IsDoNotExport = Attributes.OfType<DoNotExportAttribute>().Any();
            CmdletOnlyParameters = Parameters.Where(p => !p.Attributes.OfType<CategoryAttribute>().Any(a =>
                a.Categories.Contains(ParameterCategory.Azure) ||
                a.Categories.Contains(ParameterCategory.Runtime))).ToArray();
            Profiles = Attributes.OfType<ProfileAttribute>().SelectMany(pa => pa.Profiles).ToArray();
        }
    }

    internal class ParameterGroup
    {
        public string ParameterName { get; }
        public Parameter[] Parameters { get; }

        public string[] AllVariantNames { get; }
        public bool HasAllVariants { get; }
        public Type ParameterType { get; }

        public string[] Aliases { get; }
        public bool HasValidateNotNull { get; }
        public bool HasArgumentCompleter { get; }
        public ParameterCategory OrderCategory { get; }
        public bool IsMandatory { get; }

        public ParameterGroup(string parameterName, Parameter[] parameters, string[] allVariantNames)
        {
            ParameterName = parameterName;
            Parameters = parameters;

            AllVariantNames = allVariantNames;
            HasAllVariants = !AllVariantNames.Except(Parameters.Select(p => p.VariantName)).Any();
            ParameterType = Parameters.Select(p => p.Metadata.ParameterType).First();

            Aliases = Parameters.SelectMany(p => p.Attributes).ToAliasNames().ToArray();
            HasValidateNotNull = Parameters.SelectMany(p => p.Attributes.OfType<ValidateNotNullAttribute>()).Any();
            HasArgumentCompleter = Parameters.SelectMany(p => p.Attributes.OfType<ArgumentCompleterAttribute>()).Any();
            OrderCategory = Parameters.SelectMany(p => p.Attributes.OfType<CategoryAttribute>().SelectMany(ca => ca.Categories)).DefaultIfEmpty(ParameterCategory.Body).Min();
            IsMandatory = HasAllVariants && Parameters.First().IsMandatory;
        }
    }

    internal class Parameter
    {
        public string VariantName { get; }
        public string ParameterName { get; }
        public ParameterMetadata Metadata { get; }

        public Attribute[] Attributes { get; }
        public ParameterAttribute ParameterAttribute { get; }
        public bool IsMandatory { get; }

        public Parameter(string variantName, string parameterName, ParameterMetadata metadata)
        {
            VariantName = variantName;
            ParameterName = parameterName;
            Metadata = metadata;
            Attributes = Metadata.Attributes.ToArray();
            ParameterAttribute = Attributes.OfType<ParameterAttribute>().First();
            IsMandatory = ParameterAttribute.Mandatory;
        }
    }

    internal static class PsProxyTypeExtensions
    {
        public const string NoProfiles = "__NoProfiles";

        public static bool IsValidDefaultParameterSetName(this string parameterSetName) =>
            !String.IsNullOrEmpty(parameterSetName)
            && parameterSetName != AllParameterSets;

        public static Variant[] ToVariants(this CommandInfo info)
        {
            var metadata = new CommandMetadata(info);
            var privateCmdletName = metadata.Name;
            var parts = privateCmdletName.Split('_');
            return parts.Length > 1
                ? new[] { new Variant(parts[0], parts[1], info, metadata) }
                // Process multiple parameter sets, so we declare a variant per parameter set.
                : info.ParameterSets.Select(ps => new Variant(privateCmdletName, ps.Name, info, metadata, true)).ToArray();
        }

        public static Parameter[] ToParameters(this Variant variant)
        {
            var parameters = variant.Metadata.Parameters.AsEnumerable();
            if (variant.HasParameterSets)
            {
                parameters = parameters.Where(p => p.Value.ParameterSets.ContainsKey(variant.VariantName));
            }
            return parameters.Select(p => new Parameter(variant.VariantName, p.Key, p.Value)).ToArray();
        }

        public static Attribute[] ToAttributes(this Variant variant) => variant.IsFunction 
            ? ((FunctionInfo)variant.Info).ScriptBlock.Attributes.ToArray()
            : variant.Metadata.CommandType.GetCustomAttributes(false).Cast<Attribute>().ToArray();
    }
}
