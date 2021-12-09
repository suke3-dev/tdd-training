using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void _1を渡すと文字列1を返す()
    {
        string actual = StringLibrary.convertTest(1);
        Assert.AreEqual("1", actual);
    }

   
}