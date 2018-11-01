using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;


namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public class VarDeclaration : Declaration
    {
        public VarDeclaration(Identifier identifier, TypeDenoter type, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
            Type = type;
        }

        public Identifier Identifier { get; }

        public TypeDenoter Type { get; set; }


    }
}