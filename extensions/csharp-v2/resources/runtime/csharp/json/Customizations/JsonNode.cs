namespace Carbon.Json
{
    using System;
    using System.Collections.Generic;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public partial class JsonNode
    {
        /// <summary>
        /// Returns the content of this node as the underlying value.
        /// Will default to the string representation if not overridden in child classes.
        /// </summary>
        /// <returns>an object with the underlying value of the node.</returns>
        internal virtual object ToValue()
        {
            return this.ToString();
        }
    }
}