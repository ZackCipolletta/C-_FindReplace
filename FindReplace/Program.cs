using System;
using FindReplace.Models;
using System.Collections.Generic;

namespace FindReplace
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome!");
      Console.WriteLine("Please Input a Sentence");
      string string1 = Console.ReadLine();
      Console.WriteLine("What word would you like to replace");
      string string2 = Console.ReadLine();
      Console.WriteLine("What word would you like to replace it with");
      string string3 = Console.ReadLine();
      HandleReplacement(string1, string2, string3);
    }

    static void HandleReplacement(string string1, string string2, string string3)
    {
      ChangeWords newChangeSingleWord = new ChangeWords(string1);
      List<string> OgList = newChangeSingleWord.ConvertStringToList();
      int index = newChangeSingleWord.FindIndex(string2, OgList);
      List<string> NewList = newChangeSingleWord.ChangeListItem(index, string3);
      string result = newChangeSingleWord.ConvertToString(NewList);
      Console.WriteLine(result);
    }
  }

}