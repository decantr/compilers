using Triangle.Compiler.SyntacticAnalyzer;

namespace Triangle.Compiler.SyntaxTrees.Terminals
{
    public class CharacterLiteral : Terminal
    {
        public CharacterLiteral(string spelling, SourcePosition position)
            : base(spelling, position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public CharacterLiteral(Token token) : this(token.Spelling, token.Position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public int Value { get { return Spelling[1]; } }
    }
}