using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "ModelSurface")]
    [DoNotExport]
    public class ExportModelSurface : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string OutputFolder { get; set; }

        [Parameter]
        public bool UseExpandedFormat { get; set; }

        private const string ModelNamespace = @"${$project.modelsExtensions.fullName}";
        private const string SupportNamespace = @"${$project.supportNamespace.fullName}";

        protected override void ProcessRecord()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Where(t => t.IsClass && (t.Namespace.StartsWith(ModelNamespace) || t.Namespace.StartsWith(SupportNamespace)));
            var sb = UseExpandedFormat ? ExpandedFormat(types) : CondensedFormat(types);
            Directory.CreateDirectory(OutputFolder);
            File.WriteAllText(Path.Combine(OutputFolder, "ModelSurface.md"), sb.ToString());
        }

        private static StringBuilder ExpandedFormat(IEnumerable<Type> types)
        {
            var sb = new StringBuilder();
            var typeGroups = types.Select(t => (
                    TypeName: t.Name,
                    Properties: t.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name).ToArray(),
                    NamespaceGroup: t.Namespace.Split('.').LastOrDefault().EmptyIfNull()
                )).Where(tp => tp.Properties.Any())
                .OrderBy(tp => tp.TypeName)
                .ThenBy(tp => tp.NamespaceGroup);
            foreach (var typeGroup in typeGroups)
            {
                sb.Append($"### {typeGroup.TypeName} [{typeGroup.NamespaceGroup}]{Environment.NewLine}");
                foreach (var property in typeGroup.Properties)
                {
                    sb.Append($"  - {property.Name} `{property.PropertyType.ToSyntaxTypeName()}`{Environment.NewLine}");
                }
                sb.AppendLine();
            }

            return sb;
        }

        private static StringBuilder CondensedFormat(IEnumerable<Type> types)
        {
            var sb = new StringBuilder();
            var typeGroups = types.Select(t => (
                    TypeName: t.Name,
                    Properties: t.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name).ToArray(),
                    NamespaceGroup: t.Namespace.Split('.').LastOrDefault().EmptyIfNull()
                )).Where(tp => tp.Properties.Any())
                .GroupBy(tp => tp.TypeName)
                .Select(tpg => (
                    TypeName: tpg.Key,
                    Properties: tpg.SelectMany(tp => tp.Properties).DistinctBy(p => p.Name).OrderBy(p => p.Name).ToArray(),
                    NamespaceGroups: tpg.Select(tp => tp.NamespaceGroup).OrderBy(ng => ng).ToArray()
                ))
                .OrderBy(tc => tc.TypeName);
            foreach (var typeGroup in typeGroups)
            {
                sb.Append($"### {typeGroup.TypeName} [{String.Join(", ", typeGroup.NamespaceGroups)}]{Environment.NewLine}");
                foreach (var property in typeGroup.Properties)
                {
                    sb.Append($"  - {property.Name} `{property.PropertyType.ToSyntaxTypeName()}`{Environment.NewLine}");
                }
                sb.AppendLine();
            }

            return sb;
        }
    }
}
