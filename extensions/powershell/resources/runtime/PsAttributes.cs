using System;

namespace Microsoft.Rest
{
    [AttributeUsage(AttributeTargets.Class)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class DoNotExportAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class GeneratedAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class ProfileAttribute : Attribute
    {
        public string[] Profiles { get; }

        public ProfileAttribute(params string[] profiles)
        {
            Profiles = profiles;
        }
    }


    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class CategoryAttribute : Attribute
    {
        public ParameterCategory[] Categories { get; }

        public CategoryAttribute(params ParameterCategory[] categories)
        {
            Categories = categories;
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public enum ParameterCategory
    {
        Azure,
        Runtime
    }
}
