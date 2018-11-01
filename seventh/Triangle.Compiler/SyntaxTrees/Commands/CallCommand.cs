using Triangle.Compiler.SyntaxTrees.Parameters;
using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class CallCommand : Command
    {
        public CallCommand(Identifier identifier, ParameterSequence parameters, SourcePosition position)
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