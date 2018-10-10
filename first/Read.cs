using System;
using System.IO;
using System.Collections.Generic;

namespace first {
  public class Read  {

    public string Filename { get; }
    public List<string> Lines { get; } = new List<string>();

    public Read ( string f ) {
      Filename = f;
    }

    public void ReadFile () {
      StreamReader r = File.OpenText( Filename );
      string l = r.ReadLine();
      int lN = 1;

      while ( l != null ) {
        Lines.Add(l);
        ProcessLine( lN , l );
        lN++;
        l = r.ReadLine();
      }

      r.Close();
    }

    protected virtual void ProcessLine ( int lN , string l ) {
      Console.WriteLine( $"{ lN }\t: { l }" );
    }
  }
}