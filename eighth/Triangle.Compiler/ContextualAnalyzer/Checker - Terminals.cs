using Triangle.Compiler.SyntaxTrees.Declarations;
using Triangle.Compiler.SyntaxTrees.Terminals;
using Triangle.Compiler.SyntaxTrees.Types;
using Triangle.Compiler.SyntaxTrees.Visitors;

namespace Triangle.Compiler.ContextualAnalyzer
{
    public partial class Checker
    {
        // Literals, Identifiers and Operators

        public TypeDenoter VisitCharacterLiteral(CharacterLiteral literal, Void arg)
        {
            return StandardEnvironment.CharType;
        }

        public TypeDenoter VisitIntegerLiteral(IntegerLiteral literal, Void arg)
        {
            return StandardEnvironment.IntegerType;
        }

        public Declaration VisitIdentifier(Identifier identifier, Void arg)
        {
            throw new System.NotImplementedException();
        }
        
        public Declaration VisitOperator(Operator op, Void arg)
        {
            throw new System.NotImplementedException();
        }

    }
}