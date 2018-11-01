

namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public class SingleParameterSequence : ParameterSequence
    {
        public SingleParameterSequence(Parameter parameter, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Parameter = parameter;
        }

        public Parameter Parameter { get; }


    }
}