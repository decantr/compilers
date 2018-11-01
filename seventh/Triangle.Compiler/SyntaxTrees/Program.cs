using Triangle.Compiler.SyntaxTrees.Commands;


namespace Triangle.Compiler.SyntaxTrees
{
    public class Program : AbstractSyntaxTree
    {
        public Program(Command command, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Command = command;
        }

        public Command Command { get; }
    }
}