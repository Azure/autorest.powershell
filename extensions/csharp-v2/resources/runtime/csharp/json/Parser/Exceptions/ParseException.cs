using System;

namespace Carbon.Json.Parser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class ParserException : Exception
    {
        public ParserException(string message)
            : base(message)
        { }

        public ParserException(string message, SourceLocation location)
            : base(message)
        {

            Location = location;
        }

        public SourceLocation Location { get; }
    }
}