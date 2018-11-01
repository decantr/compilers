using Triangle.Compiler.SyntaxTrees.Parameters;
using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class CallExpression : Expression
    {
        public CallExpression(Identifier identifier, ParameterSequence parameters,
                SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
            Parameters = parameters;
        }

        public Identifier Identifier { get; }

        public ParameterSequence Parameters { get; }


    }
}