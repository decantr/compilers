

namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public abstract class Parameter : AbstractSyntaxTree
    {
        protected Parameter(SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }


    }
}