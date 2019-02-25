using System;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyOutputExtensions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal class VariantGroup
    {
        public string CmdletName { get; }
        public Variant[] Variants { get; }

        public PSTypeName[] OutputTypes { get; }
        public bool SupportsShouldProcess { get; }
        public string DefaultParameterSetName { get; }
        public bool HasMultipleVariants { get; }
        public string ModuleName { get; }
        public string Description { get; }

        public VariantGroup(string cmdletName, Variant[] variants)
        {
            CmdletName = cmdletName;
            Variants = variants;
            OutputTypes = Variants.SelectMany(v => v.Info.OutputType).GroupBy(ot => ot.Type).Select(otg => otg.First()).ToArray();
            SupportsShouldProcess = Variants.Any(v => v.Metadata.SupportsShouldProcess);
            DefaultParameterSetName = DetermineDefaultParameterSetName();
            HasMultipleVariants = Variants.Length > 1;
            ModuleName = Variants.Select(v => v.Info.Source).First();
            Description = Variants.SelectMany(v => v.Attributes).OfType<DescriptionAttribute>().FirstOrDefault()?.Description;
        }

        private string DetermineDefaultParameterSetName()
        {
            var defaultParameterSet = Variants
                .Select(v => v.Metadata.DefaultParameterSetName)
                .FirstOrDefault(dpsn => dpsn.IsValidParameterSetName());

            if (String.IsNullOrEmpty(defaultParameterSet))
            {
                var variantParamCountGroups = Variants
                    .Select(v => (
                        variant: v.VariantName,
                        paramCount: v.CmdletOnlyParameters.Length,
                        isSimple: v.CmdletOnlyParameters.All(p => p.Metadata.ParameterType.IsPsSimple())))
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

        public Attribute[] Attributes { get; }
        public Parameter[] Parameters { get; }
        public Parameter[] CmdletOnlyParameters { get; }

        public Variant(string cmdletName, string variantName, CommandInfo info, CommandMetadata metadata)
        {
            CmdletName = cmdletName;
            VariantName = variantName;
            Info = info;
            Metadata = metadata;
            Attributes = Metadata.CommandType.GetCustomAttributes(false).Cast<Attribute>().ToArray();
            Parameters = this.ToParameters();
            CmdletOnlyParameters = Parameters.Where(p => !p.Metadata.Attributes.OfType<CategoryAttribute>().Any(a =>
                a.Categories.Contains(ParameterCategory.Azure) ||
                a.Categories.Contains(ParameterCategory.Runtime))).ToArray();
        }
    }

    internal class ParameterGroup
    {
        public string ParameterName { get; }
        public Parameter[] Parameters { get; }

        public string[] AllVariantNames { get; }
        public bool HasAllVariants { get; }
        public Type ParameterType { get; }

        public AliasAttribute Alias { get; }
        public bool HasValidateNotNull { get; }
        public bool HasArgumentCompleter { get; }

        public ParameterGroup(string parameterName, Parameter[] parameters, string[] allVariantNames)
        {
            ParameterName = parameterName;
            Parameters = parameters;

            AllVariantNames = allVariantNames;
            HasAllVariants = !AllVariantNames.Except(Parameters.Select(p => p.VariantName)).Any();
            ParameterType = Parameters.Select(p => p.Metadata.ParameterType).First();

            Alias = Parameters.SelectMany(p => p.Attributes.OfType<AliasAttribute>()).FirstOrDefault();
            HasValidateNotNull = Parameters.SelectMany(p => p.Attributes.OfType<ValidateNotNullAttribute>()).Any();
            HasArgumentCompleter = Parameters.SelectMany(p => p.Attributes.OfType<ArgumentCompleterAttribute>()).Any();
        }
    }

    internal class Parameter
    {
        public string VariantName { get; }
        public string ParameterName { get; }
        public ParameterMetadata Metadata { get; }

        public Attribute[] Attributes { get; }
        public ParameterAttribute ParameterAttribute { get; }

        public Parameter(string variantName, string parameterName, ParameterMetadata metadata)
        {
            VariantName = variantName;
            ParameterName = parameterName;
            Metadata = metadata;
            Attributes = Metadata.Attributes.ToArray();
            ParameterAttribute = Attributes.OfType<ParameterAttribute>().First();
        }
    }

    internal static class PsProxyTypeExtensions
    {
        public static bool IsValidParameterSetName(this string parameterSetName) =>
            !String.IsNullOrEmpty(parameterSetName)
            && parameterSetName != NoParameters
            && parameterSetName != AllParameterSets;

        public static Variant ToVariant(this CommandInfo info)
        {
            var metadata = new CommandMetadata(info);
            var parts = metadata.Name.Split('_');
            return new Variant(parts[0], parts.Length > 1 ? parts[1] : NoParameters, info, metadata);
        }

        public static Parameter[] ToParameters(this Variant variant) => variant.Metadata.Parameters.Select(p => new Parameter(variant.VariantName, p.Key, p.Value)).ToArray();
    }
}
