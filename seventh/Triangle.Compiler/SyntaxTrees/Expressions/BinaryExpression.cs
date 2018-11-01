using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class BinaryExpression : Expression
    {
        public BinaryExpression(Expression leftExpression, Operator operation,
            Expression rightExpression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Operation = operation;
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
        }

        public Operator Operation { get; }

        public Expression LeftExpression { get; }

        public Expression RightExpression { get; }


    }
}