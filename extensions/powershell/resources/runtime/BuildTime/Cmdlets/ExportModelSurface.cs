using System;
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

        private const string ModelNamespace = @"${$project.modelsExtensions.fullName}";
        private const string SupportNamespace = @"${$project.supportNamespace.fullName}";

        protected override void ProcessRecord()
        {
            var typeGroups = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Where(t => t.IsClass && (t.Namespace.StartsWith(ModelNamespace) || t.Namespace.StartsWith(SupportNamespace)))
                .Select(t => (
                    Type: t,
                    TypeName: t.Name,
                    Properties: t.GetProperties(BindingFlags.Public | BindingFlags.Instance).OrderBy(p => p.Name).ToArray(),
                    NamespaceGroup: t.Namespace.Split('.').LastOrDefault().EmptyIfNull()
                )).Where(tp => tp.Properties.Any())
                .OrderBy(tp => tp.TypeName)
                .ThenBy(tp => tp.NamespaceGroup);
            var sb = new StringBuilder();
            foreach (var typeGroup in typeGroups)
            {
                sb.Append($"### {typeGroup.TypeName} [{typeGroup.NamespaceGroup}]{Environment.NewLine}");
                foreach (var property in typeGroup.Properties)
                {
                    sb.Append($"  - {property.Name}{Environment.NewLine}");
                }
                sb.AppendLine();
            }
            Directory.CreateDirectory(OutputFolder);
            File.WriteAllText(Path.Combine(OutputFolder, "ModelSurface.md"), sb.ToString());
        }
    }
}
