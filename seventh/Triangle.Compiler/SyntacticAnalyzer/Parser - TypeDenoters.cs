using Triangle.Compiler.SyntaxTrees.Types;

namespace Triangle.Compiler.SyntacticAnalyzer
{
    public partial class Parser
    {

        // /////////////////////////////////////////////////////////////////////////////
        //
        // TYPE-DENOTERS
        //
        // /////////////////////////////////////////////////////////////////////////////

        /**
         * Parses the type denoter, and constructs an AST to represent its phrase
         * structure.
         * 
         * @return a {@link triangle.compiler.syntax.trees.types.TypeDenoter}
         * 
         * @throws SyntaxError
         *           a syntactic error
         * 
         */
        void ParseTypeDenoter()
        {
            Compiler.WriteDebuggingInfo("Parsing Type Denoter");
            Location startLocation = tokens.Current.Start;
            switch (tokens.Current.Kind)
            {
                case TokenKind.Identifier:
                    {
                        ParseIdentifier();
                        SourcePosition typePosition = new SourcePosition(startLocation, tokens.Current.Finish);
                        break;
                    }
                    
                default:
                    {
                        RaiseSyntacticError("\"%\" cannot start a type denoter", tokens.Current);
                        break;
                    }
            }
        }

    }
}