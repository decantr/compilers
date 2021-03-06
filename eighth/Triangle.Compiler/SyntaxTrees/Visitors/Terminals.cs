using Triangle.Compiler.SyntaxTrees.Terminals;

namespace Triangle.Compiler.SyntaxTrees.Visitors
{
    public interface ILiteralVisitor<TArg, TResult>
    {
        TResult VisitCharacterLiteral(CharacterLiteral ast, TArg arg);

        TResult VisitIntegerLiteral(IntegerLiteral ast, TArg arg);
    }

    public interface ITerminalVisitor<TArg, TResult>
    {
        TResult VisitIdentifier(Identifier ast, TArg arg);

        TResult VisitOperator(Operator ast, TArg arg);
    }
}