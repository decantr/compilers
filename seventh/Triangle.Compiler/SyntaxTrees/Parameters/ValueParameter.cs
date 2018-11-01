using Triangle.Compiler.SyntaxTrees.Expressions;


namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public class ValueParameter : Parameter
    {
        public ValueParameter(Expression expression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Expression = expression;
        }

        public Expression Expression { get; }


    }
}