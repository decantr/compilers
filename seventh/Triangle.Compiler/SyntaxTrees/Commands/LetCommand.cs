using Triangle.Compiler.SyntaxTrees.Declarations;


namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class LetCommand : Command
    {
        public LetCommand(Declaration declaration, Command command, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Declaration = declaration;
            Command = command;
        }

        public Declaration Declaration { get; }

        public Command Command { get; }


    }
}