using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Microsoft.Rest.ClientRuntime.PowerShell
{
    [Serializable]
    [XmlRoot(nameof(Configuration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class Configuration
    {
        [XmlElement("ViewDefinitions")]
        public ViewDefinitions ViewDefinitions { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class ViewDefinitions
    {
        //https://stackoverflow.com/a/10518657/294804
        [XmlElement("View")]
        public List<View> Views { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class View
    {
        [XmlElement(nameof(Name))]
        public string Name { get; set; }
        [XmlElement(nameof(ViewSelectedBy))]
        public ViewSelectedBy ViewSelectedBy { get; set; }
        [XmlElement(nameof(TableControl))]
        public TableControl TableControl { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class ViewSelectedBy
    {
        [XmlElement(nameof(TypeName))]
        public string TypeName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableControl
    {
        [XmlElement(nameof(TableHeaders))]
        public TableHeaders TableHeaders { get; set; }
        [XmlElement(nameof(TableRowEntries))]
        public TableRowEntries TableRowEntries { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableHeaders
    {
        [XmlElement("TableColumnHeader")]
        public List<TableColumnHeader> TableColumnHeaders { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableColumnHeader
    {
        [XmlElement(nameof(Label))]
        public string Label { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableRowEntries
    {
        [XmlElement(nameof(TableRowEntry))]
        public TableRowEntry TableRowEntry { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableRowEntry
    {
        [XmlElement(nameof(TableColumnItems))]
        public TableColumnItems TableColumnItems { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableColumnItems
    {
        [XmlElement("TableColumnItem")]
        public List<TableColumnItem> TableItems { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    [Serializable]
    public class TableColumnItem
    {
        [XmlElement(nameof(PropertyName))]
        public string PropertyName { get; set; }
    }
}
