

namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class EmptyExpression : Expression
    {
        public EmptyExpression() : base(SourcePosition.Empty)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }


    }
}