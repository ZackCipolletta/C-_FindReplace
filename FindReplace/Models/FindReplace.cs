using System;
using System.Collections.Generic;

namespace FindReplace.Models
{
  public class ChangeWords
  {
    public string UserInput { get; set; }
    public ChangeWords(string s)
    {
      UserInput = s;
    }

    public List<string> ConvertStringToList()
    {
      List<string> nameList = new List<string>(UserInput.Split(' '));
        return nameList;
    }

    public int FindIndex(string word, List<string> list)
    {
      int index = list.FindIndex(a => a.Contains($"{word}"));
      return index;
    }

    public List<string> ChangeListItem(int index, string replacement)
    {
      List<string> nameList = new List<string>(UserInput.Split(' '));
      nameList[index] = replacement;
      return nameList;
    }

    public string ConvertToString(List<string> list)
    {
      string result = string.Join(" ", list);
      return result;
    }


  }

  // public List<string> 

}