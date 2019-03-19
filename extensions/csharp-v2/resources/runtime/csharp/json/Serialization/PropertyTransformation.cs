using System;

namespace Carbon.Json
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class PropertyTransformation
    {
        public PropertyTransformation(string name, Func<object, object> transformer)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Transformer = transformer ?? throw new ArgumentNullException(nameof(transformer));
        }

        public string Name { get; }

        public Func<object, object> Transformer { get; }
    }
}