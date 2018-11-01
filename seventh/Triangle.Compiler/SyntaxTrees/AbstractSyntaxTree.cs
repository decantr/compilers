

namespace Triangle.Compiler.SyntaxTrees
{

    public abstract class AbstractSyntaxTree
    {
        protected AbstractSyntaxTree(SourcePosition position)
        {
            Position = position;
        }

        public SourcePosition Position { get; }

        public Location Start { get { return Position.Start; } }

        public Location Finish { get { return Position.Finish; } }

    }
}