namespace Triangle.Compiler.SyntacticAnalyzer {
	public partial class Parser {

		void ParseExpression() {
			System.Console.WriteLine( "parsing expression" );
			ParsePrimaryExpression();
			while ( tokens.Current.Kind == TokenKind.Operator ) {
				ParseOperator();
				ParsePrimaryExpression();
			}
		}

		void ParsePrimaryExpression() {
			switch ( tokens.Current.Kind ) {
				case TokenKind.IntLiteral:
					ParseIntLiteral();
					break;
				case TokenKind.Identifier:
					ParseVname();
					break;
				case TokenKind.Operator:
					ParseOperator();
					ParsePrimaryExpression();
					break;
				case TokenKind.LeftBracket:
					AcceptIt();
					ParseExpression();
					Accept( TokenKind.RightBracket );
					break;
				case TokenKind.CharLiteral:
					ParseCharLiteral();
					break;
				default:
					System.Console.WriteLine( "error - exp" );
					break;
			}
		}
	}
}
