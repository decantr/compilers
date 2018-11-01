

namespace Triangle.Compiler.SyntaxTrees.Declarations
{
    public abstract class Declaration : AbstractSyntaxTree
    {
        protected Declaration(SourcePosition pos) : base(pos) {
        Compiler.WriteDebuggingInfo($"Creating {this.GetType().Name}");
		}

        public bool Duplicated { get; set; }


    }
}