﻿using System;
using System.Text;

namespace Carbon.Json.Parser
{
    using System.IO;
    using Internal.Extensions;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public class JsonTokenizer : IDisposable
    {
        private readonly StringBuilder sb = new StringBuilder();

        private readonly SourceReader reader;

        public JsonTokenizer(TextReader reader)
            : this(new SourceReader(reader)) { }

        internal JsonTokenizer(SourceReader reader)
        {
            this.reader = reader;

            reader.Next(); // Start with the first char
        }

        public JsonToken ReadNext()
        {
            reader.SkipWhitespace();

            if (reader.IsEof) return JsonToken.Eof;

            switch (reader.Current)
            {
                case '"': return ReadQuotedString();

                // Symbols
                case '[': reader.Next(); return JsonToken.BracketOpen;  // Array start
                case ']': reader.Next(); return JsonToken.BracketClose; // Array end
                case ',': reader.Next(); return JsonToken.Comma;        // Value seperator
                case ':': reader.Next(); return JsonToken.Colon;        // Field value indicator
                case '{': reader.Next(); return JsonToken.BraceOpen;    // Object start
                case '}': reader.Next(); return JsonToken.BraceClose;   // Object end
                case '\0': reader.Next(); return JsonToken.Terminator;   // Stream terminiator

                default: return ReadLiteral();
            }
        }

        private JsonToken ReadQuotedString()
        {
            Expect('"', "quoted string indicator");

            reader.Next(); // Read '"' (Starting quote)

            // Read until we reach an unescaped quote char
            while (reader.Current != '"')
            {
                EnsureNotEof("quoted string");

                if (reader.Current == '\\')
                {
                    char escapedCharacter = reader.ReadEscapeCode();

                    sb.Append(escapedCharacter);

                    continue;
                }

                StoreCurrentCharacterAndReadNext();
            }

            reader.Next(); // Read '"' (Ending quote)

            return new JsonToken(TokenKind.String, value: sb.Extract());
        }

        private JsonToken ReadLiteral()
        {
            if (char.IsDigit(reader.Current) ||
                reader.Current == '-' ||
                reader.Current == '+')
            {
                return ReadNumber();
            }

            return ReadIdentifer();
        }

        private JsonToken ReadNumber()
        {
            // Read until we hit a non-numeric character
            // -6.247737e-06
            // E

            while (char.IsDigit(reader.Current)
                || reader.Current == '.'
                || reader.Current == 'e'
                || reader.Current == 'E'
                || reader.Current == '-'
                || reader.Current == '+')
            {
                StoreCurrentCharacterAndReadNext();
            }

            return new JsonToken(TokenKind.Number, value: sb.Extract());
        }

        int count = 0;

        private JsonToken ReadIdentifer()
        {
            count++;

            if (!char.IsLetter(reader.Current))
            {
                throw new ParserException(
                   message: $"Expected literal (number, boolean, or null). Was '{reader.Current}'.",
                   location: reader.Location
               );
            }

            // Read letters, numbers, and underscores '_'
            while (char.IsLetterOrDigit(reader.Current) || reader.Current == '_')
            {
                StoreCurrentCharacterAndReadNext();
            }

            string text = sb.Extract();

            switch (text)
            {
                case "true": return JsonToken.True;
                case "false": return JsonToken.False;
                case "null": return JsonToken.Null;

                default: return new JsonToken(TokenKind.String, text);
            }
        }

        private void Expect(char character, string description)
        {
            if (reader.Current != character)
            {
                throw new ParserException(
                    message: $"Expected {description} ('{character}'). Was '{reader.Current}'.",
                    location: reader.Location
                );
            }
        }

        private void EnsureNotEof(string tokenType)
        {
            if (reader.IsEof)
            {
                throw new ParserException(
                    message: $"Unexpected EOF while reading {tokenType}.",
                    location: reader.Location
                );
            }
        }

        private void StoreCurrentCharacterAndReadNext()
        {
            sb.Append(reader.Current);

            reader.Next();
        }

        public void Dispose()
        {
            reader.Dispose();
        }
    }
}