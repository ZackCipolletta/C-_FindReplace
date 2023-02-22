
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
    public void FindReplaceConstructor_CreatesChangeWordsObjectWithStoredString_ChangeWords()
    {
      //Arrange
      ChangeWords newChangeSingleWord = new ChangeWords("test String");
      //Act
      string userString = newChangeSingleWord.PleaseWork();
      //Assert
      Assert.AreEqual(userString, "test String");
    }

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
    public void FindReplaceListConversion_PleaseWork_ChangeWords()
    {
      ChangeWords newChangeSingleWord = new ChangeWords("test string");
      List<string> thisIsShit = newChangeSingleWord.ConvertStringToList();
      Assert.AreEqual(thisIsShit[0], "test");
      ;
    }
  }
}


testing if this works