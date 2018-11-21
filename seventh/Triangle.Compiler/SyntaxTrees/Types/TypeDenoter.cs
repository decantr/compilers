

namespace Triangle.Compiler.SyntaxTrees.Types
{
    public class TypeDenoter : AbstractSyntaxTree
    {
        public TypeDenoter(SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }



    }
}