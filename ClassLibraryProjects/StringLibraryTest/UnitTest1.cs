using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestInitialize]
    public void 前準備()
    {
    }

    [TestMethod]
    public void _1を渡すと文字列1を返す()
    {
        Assert.AreEqual("1", StringLibrary.convertTest(1));
    }

    [TestMethod]
    public void _2を渡すと文字列2を返す()
    {
        Assert.AreEqual("2", StringLibrary.convertTest(2));
    }

    [TestMethod]
    public void _3を渡すと文字列Fizzを返す()
    {
        Assert.AreEqual("Fizz", StringLibrary.convertTest(3));
    }

    [TestMethod]
    public void _5を渡すと文字列Buzzを返す()
    {
        Assert.AreEqual("Buzz", StringLibrary.convertTest(5));
    }


}