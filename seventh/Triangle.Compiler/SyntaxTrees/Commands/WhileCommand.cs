using Triangle.Compiler.SyntaxTrees.Expressions;


namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class WhileCommand : Command
    {
        public WhileCommand(Expression expression, Command command, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Command = command;
            Expression = expression;
        }

        public Expression Expression { get; }

        public Command Command { get; }


    }
}