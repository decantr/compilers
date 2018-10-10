using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace first {
  public class ReadOut : Read, IStatsGen {
    public string Out { get; }

    public ReadOut(string i, string o) : base(i) => Out = o;

    protected override void ProcessLine ( int lN , string l ) {
      if ( IsValid( l ) )
        File.AppendAllText( Out , $"{lN}\t {l} {Environment.NewLine}" );
      else Console.WriteLine($"invalid line at {lN}");
    }

//  validity check
    private bool IsValid( string l ) {
        string t = l.Trim();
        if ( t == "" || t.First() == '#' ) return true;
        else {
          switch ( t.Last() ) {
            case '+':
            case ';':
                return true;
            default:
                return false;
          }
        }
    }
    
//  write out function
    public void WriteStats ( string f ) {
      StreamWriter file = File.CreateText(f);
      file.WriteLine(GetWordCount());
      file.WriteLine(GetCharacterCount());
      file.WriteLine(GetLineCount());
      file.WriteLine(string.Join(", ", GetFirstLetter()));
      file.WriteLine(string.Join(", ", GetFirstWord()));
      file.WriteLine(string.Join(", ", GetEndLine()));
      file.Close();
    }

//  functions for part four
    private static List<string> GetWords ( string l ) {
      List<string> wl = new List<string>();
      string w = "";

      foreach ( char c in l )
        if ( char.IsLetter(c) ) w += c;
        else if ( w.Length > 0 ) {
          wl.Add(w);
          w = "";
        }

      return wl;
    }

    public int GetWordCount() {
      int c = 0;
      foreach ( string l in Lines )
          c += GetWords( l ).Count;
      return c;
    }

    public int GetCharacterCount() {
      int c = 0;
      foreach ( string l in Lines )
        c += l.Length;
      return c;
    }

    public int GetLineCount() {
      return Lines.Count;
    }

    public List<char> GetFirstLetter() {
      List<char> ls = new List<char>();

      foreach ( string l in Lines ) 
        foreach ( string w in GetWords(l) )
          ls.Add(w[0]);

      return ls;
    }

    public List<string> GetFirstWord() {
      List<string> ws = new List<string>();

      foreach ( string l in Lines )
        if ( GetWords( l ).Count > 0 ) ws.Add(GetWords( l )[0]);
        else ws.Add( null );
      
      return ws;
    }

    public List<char> GetEndLine() {
      List<char> ls = new List<char>();
      
      foreach (string l in Lines)
        if (l.Length > 0) ls.Add( l[l.Length - 1] );

      return ls;
    }
  }
}