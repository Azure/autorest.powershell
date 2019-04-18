using System;

namespace Microsoft.Rest
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DescriptionAttribute : Attribute
    {
        public string Description { get; }

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class DoNotExportAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class InternalExportAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class GeneratedAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class ProfileAttribute : Attribute
    {
        public string[] Profiles { get; }

        public ProfileAttribute(params string[] profiles)
        {
            Profiles = profiles;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class CategoryAttribute : Attribute
    {
        public ParameterCategory[] Categories { get; }

        public CategoryAttribute(params ParameterCategory[] categories)
        {
            Categories = categories;
        }
    }

    public enum ParameterCategory
    {

        Path,
        Query,
        Header,
        Cookie,
        Body,

        Azure,
        Runtime
    }
}
