namespace Triangle.Compiler.SyntaxTrees.Terminals
{
    public abstract class Terminal : AbstractSyntaxTree
    {
        public string Spelling { get; }

        protected Terminal(string spelling, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Spelling = spelling;
        }
    }
}