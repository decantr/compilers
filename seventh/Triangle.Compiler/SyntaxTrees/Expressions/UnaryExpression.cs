using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class UnaryExpression : Expression
    {
        public UnaryExpression(Operator op, Expression expression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Operator = op;
            Expression = expression;
        }

        public Operator Operator { get; }

        public Expression Expression { get; }


    }
}