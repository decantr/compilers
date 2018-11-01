using Triangle.Compiler.SyntaxTrees.Expressions;
using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;


namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public class InitDeclaration : Declaration
    {
        public InitDeclaration(Identifier identifier, TypeDenoter type, Expression expression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
            Type = type;
            Expression = expression;
        }

        public Identifier Identifier { get; }

        public Expression Expression { get; }

        public TypeDenoter Type { get; set; }


    }
}