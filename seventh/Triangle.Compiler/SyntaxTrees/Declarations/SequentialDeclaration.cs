

namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public class SequentialDeclaration : Declaration
    {
        public SequentialDeclaration(Declaration firstDeclaration, Declaration secondDeclaration,
                SourcePosition position)
            : base(position)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
            FirstDeclaration = firstDeclaration;
            SecondDeclaration = secondDeclaration;
        }

        public Declaration FirstDeclaration { get; }

        public Declaration SecondDeclaration { get; }


    }
}