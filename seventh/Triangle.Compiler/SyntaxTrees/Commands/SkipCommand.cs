

namespace Triangle.Compiler.SyntaxTrees.Commands
{
    public class SkipCommand : Command
    {
        public SkipCommand(SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}"); 
        }

        public SkipCommand()
            : this(SourcePosition.Empty)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }


    }
}