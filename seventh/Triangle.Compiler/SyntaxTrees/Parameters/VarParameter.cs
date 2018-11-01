using Triangle.Compiler.SyntaxTrees.Terminals;

namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public class VarParameter : Parameter
    {
        public VarParameter(Identifier identifier, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
        }

        public Identifier Identifier { get; }


    }
}