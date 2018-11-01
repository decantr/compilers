using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class IdExpression : Expression
    {
        public IdExpression(Identifier identifier, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
        }

        public Identifier Identifier { get; }
    }
}