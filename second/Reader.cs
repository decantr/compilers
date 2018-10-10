using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace second {
  class Reader {

    public Reader() {
      IEnumerable<string> ls = ReadFrom( "quotes/s" );
      // foreach ( string l in ls ) Console.WriteLine( l );
      foreach ( string l in ls ) {
        Console.Write( l );
        if ( !string.IsNullOrWhiteSpace( l ) ) {
          Task p = Task.Delay( 200 );
          p.Wait();
        }
      }
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
