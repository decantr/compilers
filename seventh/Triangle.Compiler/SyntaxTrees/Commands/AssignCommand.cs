using Triangle.Compiler.SyntaxTrees.Expressions;
using Triangle.Compiler.SyntaxTrees.Terminals;

namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class AssignCommand : Command
    {
        public AssignCommand(Identifier identifier, Expression expression, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Identifier = identifier;
            Expression = expression;
        }

        public Identifier Identifier { get; }

        public Expression Expression { get; }

    }
}