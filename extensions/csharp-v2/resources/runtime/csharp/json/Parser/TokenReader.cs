using System;

namespace Carbon.Json.Parser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    internal class TokenReader : IDisposable
    {
        private readonly JsonTokenizer tokenizer;
        private JsonToken current;

        public TokenReader(JsonTokenizer tokenizer)
        {
            this.tokenizer = tokenizer ?? throw new ArgumentNullException(nameof(tokenizer));
        }

        public void Next()
        {
            current = tokenizer.ReadNext();
        }

        public JsonToken Current => current;

        public void Ensure(TokenKind kind, string readerName)
        {
            if (current.Kind != kind)
            {
                throw new ParserException($"Expected {kind} while reading {readerName}). Was {current}.");
            }
        }

        public void Dispose()
        {
            tokenizer.Dispose();
        }
    }
}