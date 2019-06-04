using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
            ////https://stackoverflow.com/a/79738/294804
            ////https://stackoverflow.com/a/949285/294804
            //var viewModels = Assembly.GetExecutingAssembly().GetExportedTypes()
            //    .Select(t => (Type: t, Properties: t.GetProperties().Where(p => p.PropertyType.IsPsSimple()).ToArray()))
            //    .Where(tp => tp.Type.IsClass
            //                 && (tp.Type.Namespace.StartsWith(ModelNamespace) || tp.Type.Namespace.StartsWith(SupportNamespace))
            //                 && tp.Properties.Any())
            //    .Select(tp => CreateViewModel(tp.Type, tp.Properties)).ToList();
            var viewModels = GetFilteredViewParameters().Select(CreateViewModel).ToList();
            var ps1xml = new Configuration
            {
                ViewDefinitions = new ViewDefinitions
                {
                    Views = viewModels
                }
            };
            File.WriteAllText(FilePath, ps1xml.ToXmlString());
        }

        private static IEnumerable<ViewParameters> GetFilteredViewParameters()
        {
            //https://stackoverflow.com/a/79738/294804
            //https://stackoverflow.com/a/949285/294804
            var types = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Where(t => t.IsClass
                            && (t.Namespace.StartsWith(ModelNamespace) || t.Namespace.StartsWith(SupportNamespace))
                            && !t.GetCustomAttributes<DoNotFormatAttribute>().Any());
            return types.Select(t => new ViewParameters(t, t.GetProperties()
                .Select(p => new PropertyFormat(p, p.GetCustomAttributes<FormatTableAttribute>().FirstOrDefault()))
                .Where(pf => !pf.Property.GetCustomAttributes<DoNotFormatAttribute>().Any()
                             && pf.Property.Name != "Id"
                             && (pf.FormatTable != null || pf.Property.PropertyType.IsPsSimple()))
                .OrderByDescending(pf => pf.Index.HasValue)
                .ThenBy(pf => pf.Index))).Where(vp => vp.Properties.Any());
            //var tuples = types.Select(t => (Type: t, Properties: t.GetProperties()
            //    .Where(p => !p.GetCustomAttributes<DoNotFormatAttribute>().Any()
            //                && p.Name != "Id"
            //                && (p.GetCustomAttributes<FormatTableAttribute>().Any() || p.PropertyType.IsPsSimple()))
            //    .OrderBy(p =>
            //        {
            //            var formatTable = p.GetCustomAttributes<FormatTableAttribute>().ToArray();
            //            return formatTable.Any() ? formatTable.First().
            //        })


            //    ))



            //return types
            //    .Select(t => (Type: t, Properties: t.GetProperties().Where(p => p.PropertyType.IsPsSimple()).ToArray()))
            //    .Where(tp => tp.Type.IsClass
            //                 && (tp.Type.Namespace.StartsWith(ModelNamespace) || tp.Type.Namespace.StartsWith(SupportNamespace))
            //                 && tp.Properties.Any());
        }

        private static View CreateViewModel(ViewParameters viewParameters)
        {
            var entries = viewParameters.Properties.Select(pf =>
                (TableColumnHeader: new TableColumnHeader { Label = pf.Label, Width = pf.Width },
                 TableColumnItem: new TableColumnItem { PropertyName = pf.Property.Name })).ToArray();

            return new View
            {
                Name = viewParameters.Type.FullName,
                ViewSelectedBy = new ViewSelectedBy
                {
                    TypeName = viewParameters.Type.FullName
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

    internal class ViewParameters
    {
        public Type Type { get; }
        public IEnumerable<PropertyFormat> Properties { get; }

        public ViewParameters(Type type, IEnumerable<PropertyFormat> properties)
        {
            Type = type;
            Properties = properties;
        }
    }

    internal class PropertyFormat
    {
        public PropertyInfo Property { get; }
        public FormatTableAttribute FormatTable { get; }

        public int? Index { get; }
        public string Label { get; }
        public int? Width { get; }

        public PropertyFormat(PropertyInfo propertyInfo, FormatTableAttribute formatTable)
        {
            Property = propertyInfo;
            FormatTable = formatTable;

            Index = formatTable?.HasIndex ?? false ? (int?)formatTable.Index : null;
            Label = formatTable?.Label ?? propertyInfo.Name;
            Width = formatTable?.HasWidth ?? false ? (int?)formatTable.Width : null;
        }
    }
}
