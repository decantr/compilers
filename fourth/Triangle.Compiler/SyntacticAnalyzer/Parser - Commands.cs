/**
 * @Author: John Isaacs <john>
 * @Date:   10-Oct-172017
 * @Filename: Parser - Commands.cs
 * @Last modified by:   john
 * @Last modified time: 19-Oct-172017
 */



namespace Triangle.Compiler.SyntacticAnalyzer {
  public partial class Parser {
    ////////////////////////////////////////////////////////////////////////////
    //
    // COMMANDS
    //
    ////////////////////////////////////////////////////////////////////////////

    /// Parses the command error
    void ParseCommand() {
      System.Console.WriteLine( "parsing command" );
      ParseSingleCommand();
      while ( tokens.Current.Kind == TokenKind.Semicolon ) {
        AcceptIt();
        ParseSingleCommand();
      }
    }

    /// Parses the single command
    void ParseSingleCommand() {
      System.Console.WriteLine( "parsing single command" );
      switch ( tokens.Current.Kind ) {
        case TokenKind.Identifier:
          ParseVname();
          //Accept(TokenKind.Becomes);
          //ParseExpression();
          break;
        case TokenKind.Begin:
          AcceptIt();
          ParseCommand();
          break;
        default:
          System.Console.WriteLine( "error" );
          break;
      }
    }
  }
}
