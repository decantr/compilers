namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class TernaryExpression : Expression
    {
        public TernaryExpression(Expression condition, Expression leftExpression,
            Expression rightExpression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Condition = condition;
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
        }

        public Expression Condition { get; }

        public Expression LeftExpression { get; }

        public Expression RightExpression { get; }


    }
}