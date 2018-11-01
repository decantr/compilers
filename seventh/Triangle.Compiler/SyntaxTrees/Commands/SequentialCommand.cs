

namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class SequentialCommand : Command
    {
        public SequentialCommand(Command firstCommand, Command secondCommand,
                SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            FirstCommand = firstCommand;
            SecondCommand = secondCommand;
        }

        public Command FirstCommand { get; }

        public Command SecondCommand { get; }


    }
}