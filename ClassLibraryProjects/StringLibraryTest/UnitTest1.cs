using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest;


public class UnitTest1
{
    [TestInitialize]
    public void 前準備()
    {
    }

    [TestClass]
    public class convertメソッドは数を文字列に変換する
    {
        [TestClass]
        public class _その他の数の時はそのまま文字列に変換する
        {
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
        }


        [TestClass]
        public class _3の倍数の時は数の代わりにFizzに変換する
        {
            [TestMethod]
            public void _3を渡すと文字列Fizzを返す()
            {
                Assert.AreEqual("Fizz", StringLibrary.convertTest(3));
            }
        }

        [TestClass]
        public class _5の倍数の時は数の代わりにBuzzに変換する
        {

            [TestMethod]
            public void _5を渡すと文字列Buzzを返す()
            {
                Assert.AreEqual("Buzz", StringLibrary.convertTest(5));
            }
        }
    }

  


}