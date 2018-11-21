using Triangle.Compiler.SyntaxTrees.Expressions;
using Triangle.Compiler.SyntaxTrees.Formals;
using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;
using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public class FuncDeclaration : Declaration
    {
        public Identifier Identifier { get; }
        public FormalParameterSequence Formals { get; }
        public Expression Expression { get; }

        public TypeDenoter Type { get; set; }

        public FuncDeclaration(Identifier identifier, FormalParameterSequence formals, TypeDenoter type, Expression expression, SourcePosition position)
            : base(position)
        {
            Identifier = identifier;
            Formals = formals;
            Type = type;
            Expression = expression;
        }

        public FuncDeclaration(Identifier identifier, FormalParameterSequence formals, TypeDenoter type)
            : this(identifier, formals, type, new EmptyExpression(), SourcePosition.Empty)
        {
        }

        public override TResult Visit<TArg, TResult>(IDeclarationVisitor<TArg, TResult> visitor, TArg arg)
        {
            return visitor.VisitFuncDeclaration(this, arg);
        }
    }
}