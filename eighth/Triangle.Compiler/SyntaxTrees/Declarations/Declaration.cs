using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public abstract class Declaration : AbstractSyntaxTree
    {
        public bool Duplicated { get; set; }

        protected Declaration(SourcePosition pos) : base(pos)
        {
            Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
        }

        public abstract TResult Visit<TArg, TResult>(IDeclarationVisitor<TArg, TResult> visitor, TArg arg);
    }
}