using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "FormatPs1xml")]
    [DoNotExport]
    public class ExportFormatPs1xml : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string FilePath { get; set; }

        private const string ModelNamespace = @"${$project.modelsExtensions.fullName}";
        private const string SupportNamespace = @"${$project.supportNamespace.fullName}";

        protected override void ProcessRecord()
        {
            //https://stackoverflow.com/a/79738/294804
            //https://stackoverflow.com/a/949285/294804
            var viewModels = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Select(t => (Type: t, Properties: t.GetProperties().Where(p => p.PropertyType.IsPsSimple()).ToArray()))
                .Where(tp => tp.Type.IsClass
                             && (tp.Type.Namespace.StartsWith(ModelNamespace) || tp.Type.Namespace.StartsWith(SupportNamespace))
                             && tp.Properties.Any())
                .Select(tp => CreateViewModel(tp.Type, tp.Properties)).ToList();
            var ps1xml = new Configuration
            {
                ViewDefinitions = new ViewDefinitions
                {
                    Views = viewModels
                }
            };
            File.WriteAllText(FilePath, ps1xml.ToXmlString());
        }

        private static View CreateViewModel(Type type, IEnumerable<PropertyInfo> properties)
        {
            var entries = properties.Select(p =>
                (TableColumnHeader: new TableColumnHeader { Label = p.Name },
                 TableColumnItem: new TableColumnItem { PropertyName = p.Name })).ToArray();

            return new View
            {
                Name = type.FullName,
                ViewSelectedBy = new ViewSelectedBy
                {
                    TypeName = type.FullName
                },
                TableControl = new TableControl
                {
                    TableHeaders = new TableHeaders
                    {
                        TableColumnHeaders = entries.Select(e => e.TableColumnHeader).ToList()
                    },
                    TableRowEntries = new TableRowEntries
                    {
                        TableRowEntry = new TableRowEntry
                        {
                            TableColumnItems = new TableColumnItems
                            {
                                TableItems = entries.Select(e => e.TableColumnItem).ToList()
                            }
                        }
                    }
                }
            };
        }
    }
}
