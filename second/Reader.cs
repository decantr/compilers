using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace second {
  class Reader {

    public Reader() {
      // IEnumerable<string> ls = ReadFrom( "quotes/s" );
      // // foreach ( string l in ls ) Console.WriteLine( l );
      // foreach ( string l in ls ) {
      //   Console.Write( l );
      //   if ( !string.IsNullOrWhiteSpace( l ) ) {
      //     Task p = Task.Delay( 200 );
      //     p.Wait();
      //   }
      // }

      // ShowTeleprompter().Wait();
      RunTeleprompter().Wait();
    }

    private async Task RunTeleprompter() {
      var c = new Config();
      var dT = ShowTeleprompter( c );
      var sT = GetInput( c );
      
      await Task.WhenAny( dT , sT );
    }

    private async Task GetInput( Config c ) {
      Action w = () => {
        do {
          ConsoleKeyInfo k = Console.ReadKey( true );
          switch ( k.KeyChar ) {
            case '>': c.UpdateDelay( -10 ); break;
            case '<': c.UpdateDelay( 10 ); break;
            default: break;
          }
        } while ( !c.f );
      };
      await Task.Run( w );
    }

    private async Task ShowTeleprompter( Config c ) {
      IEnumerable<string> ws = ReadFrom( "quotes/s");

      foreach ( var l in ws ) {
        Console.Write( l );
        if ( !string.IsNullOrWhiteSpace( l ) ) await Task.Delay( c.d );
      }
      c.SetDone();
    }

    private IEnumerable<string> ReadFrom( string f ) {
      string l;
      using ( StreamReader r = File.OpenText( f ) ) {
        // while ( ( l = r.ReadLine() ) != null ) yield return l;
        while ( ( l = r.ReadLine() ) != null ) {
          int lN = 0;
          String[] ws = l.Split(' ');
          foreach ( string w in ws ) { 
            yield return w + ' ';
            lN += w.Length + 1;
            if ( lN > 70 ) {
              yield return Environment.NewLine + "\t";
              lN = 0;
            }
          }
          yield return Environment.NewLine;
        }
      }
    }

  }
}
