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
    public string PleaseWork()
    {
      return UserInput;
    }

    public List<string> ConvertStringToList()
    {
      List<string> nameList = new List<string>(UserInput.Split(' '));
        return nameList;
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