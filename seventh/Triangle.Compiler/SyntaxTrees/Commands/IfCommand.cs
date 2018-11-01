using Triangle.Compiler.SyntaxTrees.Expressions;


namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class IfCommand : Command
    {
        public IfCommand(Expression expression, Command trueCommand,
                Command falseCommand, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Expression = expression;
            TrueCommand = trueCommand;
            FalseCommand = falseCommand;
        }

        public Expression Expression { get; }

        public Command TrueCommand { get; }

        public Command FalseCommand { get; }


    }
}