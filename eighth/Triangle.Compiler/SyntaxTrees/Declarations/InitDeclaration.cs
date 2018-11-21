using Triangle.Compiler.SyntaxTrees.Expressions;
using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;
using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public class InitDeclaration : Declaration
    {
        public Identifier Identifier { get; }
        public Expression Expression { get; }
        public TypeDenoter Type { get; }

        public InitDeclaration(Identifier identifier, TypeDenoter type, Expression expression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
            Type = type;
            Expression = expression;
        }

        public override TResult Visit<TArg, TResult>(IDeclarationVisitor<TArg, TResult> visitor, TArg arg)
        {
            return visitor.VisitInitDeclaration(this, arg);
        }
    }
}