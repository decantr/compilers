using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class IntegerExpression : Expression
    {
        public IntegerExpression(IntegerLiteral integerLiteral, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            IntegerLiteral = integerLiteral;
        }

        public IntegerExpression(IntegerLiteral integerLiteral)
            : this(integerLiteral, SourcePosition.Empty)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public IntegerLiteral IntegerLiteral { get; }

        public override bool IsLiteral
        {
            get { return true; }
        }

        public override int Value
        {
            get { return IntegerLiteral.Value; }
        }
        

    }
}