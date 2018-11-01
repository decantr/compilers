using Triangle.Compiler.SyntaxTrees.Terminals;


namespace Triangle.Compiler.SyntaxTrees.Expressions
{
    public class CharacterExpression : Expression
    {
        public CharacterExpression(CharacterLiteral characterLiteral, SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            CharacterLiteral = characterLiteral;
        }

        public CharacterLiteral CharacterLiteral { get; }

        public override bool IsLiteral
        {
            get { return true; }
        }

        public override int Value
        {
            get { return CharacterLiteral.Value; }
        }

       
    }
}