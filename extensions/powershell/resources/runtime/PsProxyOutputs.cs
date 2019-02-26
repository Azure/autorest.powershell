using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsProxyOutputExtensions;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    internal class OutputTypeOutput
    {
        public PSTypeName[] OutputTypes { get; }

        public OutputTypeOutput(IEnumerable<PSTypeName> outputTypes)
        {
            OutputTypes = outputTypes.ToArray();
        }

        public override string ToString() => OutputTypes != null && OutputTypes.Any() ? $"[OutputType({String.Join(", ", OutputTypes.Select(ot => $"'{ot}'"))})]{Environment.NewLine}" : String.Empty;
    }

    internal class CmdletBindingOutput
    {
        public VariantGroup VariantGroup { get; }

        public CmdletBindingOutput(VariantGroup variantGroup)
        {
            VariantGroup = variantGroup;
        }

        public override string ToString()
        {
            var isValidDpsn = VariantGroup.DefaultParameterSetName.IsValidParameterSetName();
            var dpsText = isValidDpsn ? $"DefaultParameterSetName='{VariantGroup.DefaultParameterSetName}'" : String.Empty;
            var sspText = VariantGroup.SupportsShouldProcess ? $"{(isValidDpsn ? ", " : String.Empty)}SupportsShouldProcess={true.ToPsBool()}, ConfirmImpact='Medium'" : String.Empty;
            return $"[CmdletBinding({dpsText}{sspText})]{Environment.NewLine}";
        }
    }

    internal class ParameterOutput
    {
        public Parameter Parameter { get; }
        public bool HasMultipleVariantsInVariantGroup { get; }
        public bool HasAllVariantsInParameterGroup { get; }

        public ParameterOutput(Parameter parameter, bool hasMultipleVariantsInVariantGroup, bool hasAllVariantsInParameterGroup)
        {
            Parameter = parameter;
            HasMultipleVariantsInVariantGroup = hasMultipleVariantsInVariantGroup;
            HasAllVariantsInParameterGroup = hasAllVariantsInParameterGroup;
        }

        public override string ToString()
        {
            var pa = Parameter.ParameterAttribute;
            var psnText = HasMultipleVariantsInVariantGroup && !HasAllVariantsInParameterGroup ? $"ParameterSetName='{Parameter.VariantName}', " : String.Empty;
            var mandatoryText = pa.Mandatory ? $"Mandatory={pa.Mandatory.ToPsBool()}, " : String.Empty;
            var dontShowText = pa.DontShow ? $"DontShow={pa.DontShow.ToPsBool()}, " : String.Empty;
            var vfpText = pa.ValueFromPipeline ? $"ValueFromPipeline={pa.ValueFromPipeline.ToPsBool()}, " : String.Empty;
            var helpText = $"HelpMessage='{pa.HelpMessage.ToPsStringLiteral()}'";
            return $"{Indent}[Parameter({psnText}{mandatoryText}{dontShowText}{vfpText}{helpText})]{Environment.NewLine}";
        }
    }

    internal class AliasOutput
    {
        public AliasAttribute Alias { get; }

        public AliasOutput(AliasAttribute alias)
        {
            Alias = alias;
        }

        public override string ToString() => Alias != null ? $"{Indent}[Alias({String.Join(",", Alias.AliasNames.Select(an => $"'{an}'"))})]{Environment.NewLine}" : String.Empty;
    }

    internal class ValidateNotNullOutput
    {
        public bool HasValidateNotNull { get; }

        public ValidateNotNullOutput(bool hasValidateNotNull)
        {
            HasValidateNotNull = hasValidateNotNull;
        }

        public override string ToString() => HasValidateNotNull ? $"{Indent}[ValidateNotNull()]{Environment.NewLine}" : String.Empty;
    }

    internal class ArgumentCompleterOutput
    {
        public bool HasArgumentCompleter { get; }
        public Type ParameterType { get; }

        public ArgumentCompleterOutput(ParameterGroup parameterGroup)
        {
            HasArgumentCompleter = parameterGroup.HasArgumentCompleter;
            ParameterType = parameterGroup.ParameterType;
        }

        public override string ToString() => HasArgumentCompleter ? $"{Indent}[ArgumentCompleter([{ParameterType.ToPsType()}])]{Environment.NewLine}" : String.Empty;
    }

    internal class ParameterTypeOutput
    {
        public Type ParameterType { get; }

        public ParameterTypeOutput(Type parameterType)
        {
            ParameterType = parameterType;
        }

        public override string ToString() => $"{Indent}[{ParameterType.ToPsType()}]{Environment.NewLine}";
    }

    internal class ParameterNameOutput
    {
        public string ParameterName { get; }
        public bool IsLast { get; }

        public ParameterNameOutput(string parameterName, bool isLast)
        {
            ParameterName = parameterName;
            IsLast = isLast;
        }

        public override string ToString() => $"{Indent}${{{ParameterName}}}{(IsLast ? String.Empty : $",{Environment.NewLine}")}{Environment.NewLine}";
    }

    internal class BeginOutput
    {
        public VariantGroup VariantGroup { get; }

        public BeginOutput(VariantGroup variantGroup)
        {
            VariantGroup = variantGroup;
        }

        public override string ToString() => $@"begin {{
{Indent}try {{
{Indent}{Indent}$outBuffer = $null
{Indent}{Indent}if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {{
{Indent}{Indent}{Indent}$PSBoundParameters['OutBuffer'] = 1
{Indent}{Indent}}}
{Indent}{Indent}$parameterSet = $PsCmdlet.ParameterSetName
{Indent}{Indent}$variantSuffix = ""_$parameterSet""
{Indent}{Indent}if (""$parameterSet"" -eq '{NoParameters}' -or ""$parameterSet"" -eq '{AllParameterSets}') {{
{Indent}{Indent}{Indent}$variantSuffix = ''
{Indent}{Indent}}}
{Indent}{Indent}$wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(""{VariantGroup.ModuleName}\{VariantGroup.CmdletName}$variantSuffix"", [System.Management.Automation.CommandTypes]::Cmdlet)
{Indent}{Indent}$scriptCmd = {{& $wrappedCmd @PSBoundParameters}}
{Indent}{Indent}$steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
{Indent}{Indent}$steppablePipeline.Begin($PSCmdlet)
{Indent}}} catch {{
{Indent}{Indent}throw
{Indent}}}
}}

";
    }

    internal class ProcessOutput
    {
        public override string ToString() => $@"process {{
{Indent}try {{
{Indent}{Indent}$steppablePipeline.Process($_)
{Indent}}} catch {{
{Indent}{Indent}throw
{Indent}}}
}}

";
    }

    internal class EndOutput
    {
        public override string ToString() => $@"end {{
{Indent}try {{
{Indent}{Indent}$steppablePipeline.End()
{Indent}}} catch {{
{Indent}{Indent}throw
{Indent}}}
}}

";
    }

    internal class HelpCommentOutput
    {
        public VariantGroup VariantGroup { get; }

        public HelpCommentOutput(VariantGroup variantGroup)
        {
            VariantGroup = variantGroup;
        }

        public override string ToString() => $@"<#
.Description
{VariantGroup.Description}
#>
";
    }

    internal static class PsProxyOutputExtensions
    {
        public const string NoParameters = "__NoParameters";

        public const string AllParameterSets = "__AllParameterSets";

        public const string Indent = "    ";

        public static OutputTypeOutput ToOutputTypeOutput(this IEnumerable<PSTypeName> outputTypes) => new OutputTypeOutput(outputTypes);

        public static CmdletBindingOutput ToCmdletBindingOutput(this VariantGroup variantGroup) => new CmdletBindingOutput(variantGroup);

        public static ParameterOutput ToParameterOutput(this Parameter parameter, bool hasMultipleVariantsInVariantGroup, bool hasAllVariantsInParameterGroup) => new ParameterOutput(parameter, hasMultipleVariantsInVariantGroup, hasAllVariantsInParameterGroup);

        public static AliasOutput ToAliasOutput(this AliasAttribute alias) => new AliasOutput(alias);

        public static ValidateNotNullOutput ToValidateNotNullOutput(this bool hasValidateNotNull) => new ValidateNotNullOutput(hasValidateNotNull);

        public static ArgumentCompleterOutput ToArgumentCompleterOutput(this ParameterGroup parameterGroup) => new ArgumentCompleterOutput(parameterGroup);

        public static ParameterTypeOutput ToParameterTypeOutput(this Type parameterType) => new ParameterTypeOutput(parameterType);

        public static ParameterNameOutput ToParameterNameOutput(this string parameterName, bool isLast) => new ParameterNameOutput(parameterName, isLast);

        public static BeginOutput ToBeginOutput(this VariantGroup variantGroup) => new BeginOutput(variantGroup);

        public static ProcessOutput ToProcessOutput(this VariantGroup variantGroup) => new ProcessOutput();

        public static EndOutput ToEndOutput(this VariantGroup variantGroup) => new EndOutput();

        public static HelpCommentOutput ToHelpCommentOutput(this VariantGroup variantGroup) => new HelpCommentOutput(variantGroup);
    }
}
