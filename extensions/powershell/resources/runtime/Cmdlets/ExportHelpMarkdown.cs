using System;
using System.IO;
using System.Linq;
using System.Management.Automation;
using static Microsoft.Rest.ClientRuntime.PowerShell.PsHelpers;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Cmdlet(VerbsData.Export, "HelpMarkdown")]
    [DoNotExport]
    public class ExportHelpMarkdown : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ModuleName { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string ModuleDescription { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public PSObject[] FunctionInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public PSObject[] HelpInfo { get; set; }

        [Parameter(Mandatory = true)]
        [ValidateNotNullOrEmpty]
        public string DocsFolder { get; set; }

        protected override void ProcessRecord()
        {
            //var functionInfos = GetScriptCmdlets(this, ScriptFolder)
            //    .Where(fi => !fi.ScriptBlock.Attributes.OfType<DoNotExportAttribute>().Any())
            //    .ToArray();
            //var names = functionInfos.Select(fi => fi.Name).Distinct();
            //var helpObjects = GetCmdletHelp(this, names);

            var variantGroups = FunctionInfo.Select(fi => fi.BaseObject).Cast<FunctionInfo>()
                .Select(fi => fi.ToVariants())
                .Select(va => new VariantGroup(va.First().CmdletName, va, String.Empty))
                .ToArray();

            var helpInfos = HelpInfo.Select(hi => hi.ToPsHelpInfo()).ToArray();

            var markdownInfos = variantGroups.Join(helpInfos, vg => vg.CmdletName, phi => phi.CmdletName, (vg, phi) => new MarkdownHelpInfo(vg, phi)).ToArray();

            //foreach (var psPropertyInfo in HelpInfo.SelectMany(h => h.Properties))
            //{
            //    Console.Write("name: " + psPropertyInfo.Name);
            //    Console.Write("\tvalue: " + psPropertyInfo.Value);
            //    Console.WriteLine("\tmemberType: " + psPropertyInfo.MemberType);
            //}





            //var viewModels = Assembly.GetExecutingAssembly().GetExportedTypes()
            //    .Select(t => (Type: t, Properties: t.GetProperties().Where(p => p.PropertyType.IsPsSimple()).ToArray()))
            //    .Where(tp => tp.Type.IsClass
            //                 && (tp.Type.Namespace.StartsWith(ModelNamespace) || tp.Type.Namespace.StartsWith(SupportNamespace))
            //                 && tp.Properties.Any())
            //    .Select(tp => CreateViewModel(tp.Type, tp.Properties)).ToList();
            //var ps1xml = new Configuration
            //{
            //    ViewDefinitions = new ViewDefinitions
            //    {
            //        Views = viewModels
            //    }
            //};
            //File.WriteAllText(FilePath, ps1xml.ToXmlString());
        }
    }
}
