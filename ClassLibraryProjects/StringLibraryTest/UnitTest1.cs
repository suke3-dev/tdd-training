using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void 数を文字列に変換する()
    {
        var test = 1;
        var test2 = 2;
        Assert.AreEqual(test, test2);
    }
}