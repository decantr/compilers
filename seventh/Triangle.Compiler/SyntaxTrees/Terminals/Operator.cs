using Triangle.Compiler.SyntacticAnalyzer;
using Triangle.Compiler.SyntaxTrees.Declarations;


namespace Triangle.Compiler.SyntaxTrees.Terminals
{
    public class Operator : Terminal
    {
        public Operator(string spelling, SourcePosition position)
            : base(spelling, position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public Operator(Token token) : this(token.Spelling, token.Position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public Operator(string spelling) : this(spelling, SourcePosition.Empty)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public Declaration Declaration { get; set; }


    }
}