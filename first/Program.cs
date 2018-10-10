using System;
using System.IO;

namespace first {
    public class Program {
        // file names
        const string IN = @"i", OUT = @"o", STATS = @"s";

        static void Main( string[] args ) {
            // delete files from previes runs
            if(File.Exists(@"o")) File.Delete(@"o");
            if(File.Exists(@"s")) File.Delete(@"s");

            Read r = new Read( IN );
            // Console.WriteLine( $"Listing of {r.Filename}:" );
            // r.ReadFile();

            ReadOut ro = new ReadOut( IN , OUT );
            ro.ReadFile();
            ro.WriteStats(STATS);
        }
    }
}
