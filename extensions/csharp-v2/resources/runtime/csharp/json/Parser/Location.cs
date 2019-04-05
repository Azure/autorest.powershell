namespace Carbon.Json.Parser
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("AutoRest", "${$project.autorestVersion}")]
    public struct SourceLocation
    {
        private int line;
        private int column;
        private int position;

        public SourceLocation(int line = 0, int column = 0, int position = 0)
        {
            this.line = line;
            this.column = column;
            this.position = position;
        }

        public int Line => line;

        public int Column => column;

        public int Position => position;

        public void Advance()
        {
            this.column++;
            this.position++;
        }

        public void MarkNewLine()
        {
            this.line++;
            this.column = 0;
        }

        public SourceLocation Clone()
        {
            return new SourceLocation(line, column, position);
        }
    }
}