

namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public abstract class Command : AbstractSyntaxTree
    {
        protected Command(SourcePosition position) : base(position) {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}"); 
        }

    }
}