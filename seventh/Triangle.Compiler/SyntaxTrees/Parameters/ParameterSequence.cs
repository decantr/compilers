

namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public abstract class ParameterSequence : AbstractSyntaxTree
    {
        protected ParameterSequence(SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }


    }
}