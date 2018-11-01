
using Triangle.Compiler.SyntaxTrees.Expressions;

namespace Triangle.Compiler.SyntacticAnalyzer
{
    public partial class Parser
    {
        ///////////////////////////////////////////////////////////////////////////////
        //
        // EXPRESSIONS
        //
        ///////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Parses the expression, and constructs an AST to represent its phrase
        /// structure.
        /// </summary>
        /// <returns>
        /// an <link>Triangle.SyntaxTrees.Expressions.Expression</link>
        /// </returns> 
        /// <throws type="SyntaxError">
        /// a syntactic error
        /// </throws>
        void ParseExpression()
        {
            Compiler.WriteDebuggingInfo("Parsing Expression");
            Location startLocation = tokens.Current.Start;

            ParseSecondaryExpression();
            if (tokens.Current.Kind == TokenKind.QuestionMark)
            {
                Compiler.WriteDebuggingInfo("Parsing Ternary Expression");
                AcceptIt();
                ParseExpression();
                Accept(TokenKind.Colon);
                ParseExpression();
                SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
            }
            else
            {
                SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
            }
        }

        /// <summary>
        // Parses the secondary expression, and constructs an AST to represent its
        /// phrase structure.
        /// </summary>
        /// <returns>
        /// an <link>Triangle.SyntaxTrees.Expressions.Expression</link>
        /// </returns>
        /// <throws type="SyntaxError">
        /// a syntactic error
        /// </throws>
        void ParseSecondaryExpression()
        {
            Compiler.WriteDebuggingInfo("Parsing Secondary Expression");
            Location startLocation = tokens.Current.Start;
            ParsePrimaryExpression();
            while (tokens.Current.Kind == TokenKind.Operator)
            {
                ParseOperator();
                ParsePrimaryExpression();
                SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
                break;
            }
        }

        /// <summary>
        /// Parses the primary expression, and constructs an AST to represent its
        /// phrase structure.
        /// </summary>
        /// <returns>
        /// an <link>Triangle.SyntaxTrees.Expressions.Expression</link>
        /// </returns>
        /// <throws type="SyntaxError">
        /// a syntactic error
        /// </throws>
        void ParsePrimaryExpression()
        {
            Compiler.WriteDebuggingInfo("Parsing Primary Expression");
            Location startLocation = tokens.Current.Start;
            switch (tokens.Current.Kind)
            {
                case TokenKind.IntLiteral:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Int Expression");
                        ParseIntegerLiteral();
                        SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
                        break;
                    }

                case TokenKind.CharLiteral:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Char Expression");
                        ParseCharacterLiteral();
                        SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
                        break;
                    }


                case TokenKind.Identifier:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Call Expression or Identifier Expression");
                        ParseIdentifier();
                        if (tokens.Current.Kind == TokenKind.LeftBracket)
                        {
                            Compiler.WriteDebuggingInfo("Parsing Call Expression");
                            AcceptIt();
                            ParseParameters();
                            Accept(TokenKind.RightBracket);
                            SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
                            break;
                        }
                        else
                        {
                            Compiler.WriteDebuggingInfo("Parsing Identifier Expression");
                            SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
                            break;
                        }
                    }

                case TokenKind.Operator:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Unary Expression");
                        ParseOperator();
                        ParsePrimaryExpression();
                        SourcePosition expressionPos = new SourcePosition(startLocation, tokens.Current.Finish);
                        break;
                    }

                case TokenKind.LeftBracket:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Bracket Expression");
                        AcceptIt();
                        ParseExpression();
                        Accept(TokenKind.RightBracket);
                        break;
                    }

                default:
                    {
                        RaiseSyntacticError("\"%\" cannot start an expression", tokens.Current);
                        break;
                    }
            }
        }

    }
}