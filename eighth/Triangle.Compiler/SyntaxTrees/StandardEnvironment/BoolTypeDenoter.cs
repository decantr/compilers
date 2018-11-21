using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Types
{
    public class BoolTypeDenoter : TypeDenoter
    {
        public BoolTypeDenoter() : base(SourcePosition.Empty) { }

        public override TResult Visit<TArg, TResult>(ITypeDenoterVisitor<TArg, TResult> visitor, TArg arg)
        {
            return visitor.VisitBoolTypeDenoter(this, arg);
        }
    }
}