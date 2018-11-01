

namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public class EmptyParameterSequence : ParameterSequence
    {
        public EmptyParameterSequence(SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }


    }
}