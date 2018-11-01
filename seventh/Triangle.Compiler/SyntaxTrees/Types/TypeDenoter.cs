

namespace Triangle.Compiler.SyntaxTrees.Types
{
    public class TypeDenoter : AbstractSyntaxTree
    {
        protected TypeDenoter(SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }


       
    }
}