using System;
using System.Collections.Generic;

namespace first {
  interface IStatsGen {
    int GetWordCount();
    int GetCharacterCount();
    int GetLineCount();
    List<char> GetFirstLetter();
    List<string> GetFirstWord();
    List<char> GetEndLine();
  }
}