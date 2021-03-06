using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;
using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Formals
{
    public class ConstFormalParameter : FormalParameter
    {
        public Identifier Identifier { get; }

        public TypeDenoter Type { get; set; }

        public ConstFormalParameter(Identifier identifier, TypeDenoter type, SourcePosition position)
            : base(position)
        {
            Identifier = identifier;
            Type = type;
        }

        public ConstFormalParameter(TypeDenoter typeDenoter)
            : this(Identifier.Empty, typeDenoter, SourcePosition.Empty)
        {
        }

        public override TResult Visit<TArg, TResult>(IDeclarationVisitor<TArg, TResult> visitor, TArg arg)
        {
            return visitor.VisitConstFormalParameter(this, arg);
        }
    }
}