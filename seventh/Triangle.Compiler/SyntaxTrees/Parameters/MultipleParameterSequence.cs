

namespace Triangle.Compiler.SyntaxTrees.Parameters
{
    public class MultipleParameterSequence : ParameterSequence
    {
        public MultipleParameterSequence(Parameter parameter, ParameterSequence parameters,
                SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            Parameter = parameter;
            Parameters = parameters;
        }

        public Parameter Parameter { get; }

        public ParameterSequence Parameters { get; }


    }
}