
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindReplace.Models;
using System.Collections.Generic;
using System;

namespace FindReplace.Tests
{
  [TestClass]
  public class FindReplaceTests
  {
    [TestMethod]
    public void FindReplaceListConversion_ConvertsUserInputToAList_ChangeWords()
    {
      ChangeWords newChangeSingleWord = new ChangeWords("test string");
      List<string> userStringList = new List<string>(newChangeSingleWord.UserInput.Split(' '));
      Console.WriteLine($"this is the newCHangeSingleWord variable: {newChangeSingleWord}");
      Assert.AreEqual(userStringList[0], "test");
      ;
    }

    [TestMethod]
    public void FindReplaceListConversion_ConvertStringToList_ChangeWords()
    {
      ChangeWords newChangeSingleWord = new ChangeWords("test string");
      List<string> NewList = newChangeSingleWord.ConvertStringToList();
      Assert.AreEqual(NewList[0], "test");
      ;
    }


    [TestMethod]
    public void ChangeListItem_ChangeItemInAList_ChangeWords()
    {
      ChangeWords newChangeSingleWord = new ChangeWords("test string");
      List<string> NewList = newChangeSingleWord.ChangeListItem(0, "this");
      Assert.AreEqual(NewList[0], "this");
      ;
    }

    [TestMethod]
    public void ConvertList_ConvertListToAString_ChangeWords()
    {
      ChangeWords newChangeSingleWord = new ChangeWords("test string");
      List<string> NewList = newChangeSingleWord.ChangeListItem(0, "this");
      string result = newChangeSingleWord.ConvertToString(NewList);
      Assert.AreEqual(result, "this string");
      ;
    }

    [TestMethod]
    public void FindIndex_FindsIndexOfAStringInAList_ChangeWords()
    {
      ChangeWords newChangeSingleWord = new ChangeWords("test string");
      List<string> userStringList = new List<string>(newChangeSingleWord.UserInput.Split(' '));
      int index = newChangeSingleWord.FindIndex("test", userStringList);
      Assert.AreEqual(index, 0);
      
    }


  }
}