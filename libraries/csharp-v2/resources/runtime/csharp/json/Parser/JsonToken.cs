namespace Carbon.Json.Parser
{
    public enum TokenKind
    {
        LeftBrace,      // {	Object start
        RightBrace,     // }	Object end

        LeftBracket,    // [	Array start
        RightBracket,   // ]	Array end

        Comma,          // ,	Comma
        Colon,          // :	Value indicator
        Dot,            // .	Access field indicator
        Terminator,     // \0	Stream terminator

        Boolean = 31,   // true or false
        Null = 33,      // null
        Number = 34,    // i.e. -1.93, -1, 0, 1, 1.1
        String = 35,    // i.e. "text"

        Eof = 50
    }

    public /* readonly */ struct JsonToken
    {
        public static readonly JsonToken BraceOpen = new JsonToken(TokenKind.LeftBrace, "{");
        public static readonly JsonToken BraceClose = new JsonToken(TokenKind.RightBrace, "}");

        public static readonly JsonToken BracketOpen = new JsonToken(TokenKind.LeftBracket, "[");
        public static readonly JsonToken BracketClose = new JsonToken(TokenKind.RightBracket, "]");

        public static readonly JsonToken Colon = new JsonToken(TokenKind.Colon, ":");
        public static readonly JsonToken Comma = new JsonToken(TokenKind.Comma, ",");
        public static readonly JsonToken Terminator = new JsonToken(TokenKind.Terminator, "\0");

        public static readonly JsonToken True = new JsonToken(TokenKind.Boolean, "true");
        public static readonly JsonToken False = new JsonToken(TokenKind.Boolean, "false");
        public static readonly JsonToken Null = new JsonToken(TokenKind.Null, "null");

        public static readonly JsonToken Eof = new JsonToken(TokenKind.Eof, null);

        public JsonToken(TokenKind kind, string value)
        {
            Kind = kind;
            Value = value;
        }

        public readonly TokenKind Kind;

        public readonly string Value;

        public override string ToString() => Kind + ": " + Value;

        #region Helpers

        public bool IsLiteral => (byte)Kind > 30 && (byte)Kind < 40;

        public bool IsTerminator => Kind == TokenKind.Terminator;

        #endregion
    }
}