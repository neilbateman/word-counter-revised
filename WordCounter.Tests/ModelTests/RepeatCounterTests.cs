using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {

    [TestMethod]
    public void Test_RepeatCounter_SingleWord_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("Hello World", "Hello");
      Assert.AreEqual(1, testRepeatCounter.GetPairs());
    }
    [TestMethod]
    public void Test_RepeatCounter_MultipleWord_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("Why Hello there Hello World", "Hello");
      Assert.AreEqual(2, testRepeatCounter.GetPairs());
    }
    [TestMethod]
    public void Test_RepeatCounter_CaseSensitive_True()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter("Hello World", "hello");
      Assert.AreEqual(1, testRepeatCounter.GetPairs());
    }

    [TestMethod]
    public void Test_RepeatCounter_IgnoresPartials_True()
    {
      RepeatCounter newRepeatCounter = new RepeatCounter("helloworld", "hello");

      Assert.AreEqual(0, newRepeatCounter.GetPairs());
    }
  }
}
