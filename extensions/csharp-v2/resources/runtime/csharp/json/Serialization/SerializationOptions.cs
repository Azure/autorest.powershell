using System;
using System.Linq;

namespace Carbon.Json
{
    public class SerializationOptions
    {
        public static readonly SerializationOptions Default = new SerializationOptions();

        public SerializationOptions() { }

        public SerializationOptions(
            string[] include = null,
            bool ingoreNullValues = false)
        {
            Include = include;
            IgnoreNullValues = ingoreNullValues;
        }

        public string[] Include { get; set; }

        public string[] Exclude { get; set; }

        public bool IgnoreNullValues { get; set; }

        public PropertyTransformation[] Transformations { get; set; }

        public Func<string, string> PropertyNameTransformer { get; set; }

        public int MaxDepth { get; set; } = 5;

        public bool IsIncluded(string name)
        {
            if (Exclude != null)
            {
                return !Exclude.Any(exclude => exclude.Equals(name, StringComparison.OrdinalIgnoreCase));
            }
            else if (Include != null)
            {
                return Include.Any(exclude => exclude.Equals(name, StringComparison.OrdinalIgnoreCase));
            }

            return true;
        }

        public PropertyTransformation GetTransformation(string propertyName)
        {
            if (Transformations == null) return null;

            foreach (var t in Transformations)
            {
                if (t.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase))
                {
                    return t;
                }
            }

            return null;
        }
    }
}