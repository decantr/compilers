using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;
using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Formals
{
    public class VarFormalParameter : FormalParameter
    {
        public Identifier Identifier { get; }

        public TypeDenoter Type { get; set; }

        public VarFormalParameter(Identifier identifier, TypeDenoter type, SourcePosition position)
            : base(position)
        {
            Identifier = identifier;
            Type = type;
        }

        public VarFormalParameter(TypeDenoter type)
            : this(Identifier.Empty, type, SourcePosition.Empty)
        {
        }
        
        public override TResult Visit<TArg, TResult>(IDeclarationVisitor<TArg, TResult> visitor, TArg arg)
        {
            return visitor.VisitVarFormalParameter(this, arg);
        }
    }
}