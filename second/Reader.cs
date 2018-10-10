using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace second {
  class Reader {

    public Reader() {
      IEnumerable<string> ls = ReadFrom( "quotes/s" );
      foreach ( string l in ls ) Console.WriteLine( l );
    }

    private IEnumerable<string> ReadFrom( string f ) {
      string l;
      using ( StreamReader r = File.OpenText( f ) ) {
        while ( ( l = r.ReadLine() ) != null ) yield return l;
      }
    }

  }
}
