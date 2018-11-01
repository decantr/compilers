namespace Triangle.Compiler.SyntacticAnalyzer
{
    public partial class Parser
    {

        ///////////////////////////////////////////////////////////////////////////////
        //
        // PARAMETERS
        //
        ///////////////////////////////////////////////////////////////////////////////
        
        void ParseParameters()
        {
            Compiler.WriteDebuggingInfo("Parsing Parameters");
            Location startLocation = tokens.Current.Position.Start;
            ParseParameter();
            if (tokens.Current.Kind == TokenKind.Comma)
            {
                AcceptIt();
                ParseParameters();
                SourcePosition parameterPosition = new SourcePosition(startLocation, tokens.Current.Position.Finish);
            }
            else
            {
                SourcePosition parameterPosition = new SourcePosition(startLocation, tokens.Current.Position.Finish);
            }
           
        }
        
        void ParseParameter()
        {
            Compiler.WriteDebuggingInfo("Parsing Parameter");
            Location startLocation = tokens.Current.Position.Start;
            switch (tokens.Current.Kind)
            {
                case TokenKind.Identifier:
                case TokenKind.IntLiteral:
                case TokenKind.CharLiteral:
                case TokenKind.Operator:
                case TokenKind.LeftBracket:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Value Parameter");
                        ParseExpression();
                        SourcePosition parameterPosition = new SourcePosition(startLocation, tokens.Current.Position.Finish);
                        break;
                    }

                case TokenKind.Var:
                    {
                        Compiler.WriteDebuggingInfo("Parsing Variable Parameter");
                        AcceptIt();
                        ParseIdentifier();
                        SourcePosition parameterPosition = new SourcePosition(startLocation, tokens.Current.Position.Finish);
                        break;
                    }

                default:
                    {
                        RaiseSyntacticError("\"%\" cannot start a parameter", tokens.Current);
                        break;
                    }
            }

        }
    }
}