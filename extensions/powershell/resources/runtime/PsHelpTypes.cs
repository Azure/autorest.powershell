using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Xml.Serialization;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    public class CmdletHelpInfo
    {
        public string CmdletName { get; }
        public string Synopsis { get; }
        public string Description { get; }
        //public string ProfileName { get; }
        //public Variant[] Variants { get; }

        //public string[] Aliases { get; }
        //public PSTypeName[] OutputTypes { get; }
        //public bool SupportsShouldProcess { get; }
        //public string DefaultParameterSetName { get; }
        //public bool HasMultipleVariants { get; }
        
        //public bool IsGenerated { get; }

        public CmdletHelpInfo(PSMemberInfoCollection<PSPropertyInfo> properties)
        {
            CmdletName = properties.GetProperty<string>("Name");
            Synopsis = properties.GetProperty<string>("Synopsis");
            Description = String.Join(Environment.NewLine, properties.GetProperty<PSObject[]>("description").Select(dl => dl.Properties.GetProperty<string>("Text")));
        }
    }

    public static class HelpTypesExtensions
    {
        public static CmdletHelpInfo ToCmdletHelpInfo(this PSMemberInfoCollection<PSPropertyInfo> properties) => new CmdletHelpInfo(properties);
    }

    //[Serializable]
    //public class ViewDefinitions
    //{
    //    //https://stackoverflow.com/a/10518657/294804
    //    [XmlElement("View")]
    //    public List<View> Views { get; set; }
    //}

    //[Serializable]
    //public class View
    //{
    //    [XmlElement(nameof(Name))]
    //    public string Name { get; set; }
    //    [XmlElement(nameof(ViewSelectedBy))]
    //    public ViewSelectedBy ViewSelectedBy { get; set; }
    //    [XmlElement(nameof(TableControl))]
    //    public TableControl TableControl { get; set; }
    //}

    //[Serializable]
    //public class ViewSelectedBy
    //{
    //    [XmlElement(nameof(TypeName))]
    //    public string TypeName { get; set; }
    //}

    //[Serializable]
    //public class TableControl
    //{
    //    [XmlElement(nameof(TableHeaders))]
    //    public TableHeaders TableHeaders { get; set; }
    //    [XmlElement(nameof(TableRowEntries))]
    //    public TableRowEntries TableRowEntries { get; set; }
    //}

    //[Serializable]
    //public class TableHeaders
    //{
    //    [XmlElement("TableColumnHeader")]
    //    public List<TableColumnHeader> TableColumnHeaders { get; set; }
    //}

    //[Serializable]
    //public class TableColumnHeader
    //{
    //    [XmlElement(nameof(Label))]
    //    public string Label { get; set; }
    //}

    //[Serializable]
    //public class TableRowEntries
    //{
    //    [XmlElement(nameof(TableRowEntry))]
    //    public TableRowEntry TableRowEntry { get; set; }
    //}

    //[Serializable]
    //public class TableRowEntry
    //{
    //    [XmlElement(nameof(TableColumnItems))]
    //    public TableColumnItems TableColumnItems { get; set; }
    //}

    //[Serializable]
    //public class TableColumnItems
    //{
    //    [XmlElement("TableColumnItem")]
    //    public List<TableColumnItem> TableItems { get; set; }
    //}

    //[Serializable]
    //public class TableColumnItem
    //{
    //    [XmlElement(nameof(PropertyName))]
    //    public string PropertyName { get; set; }
    //}
}
