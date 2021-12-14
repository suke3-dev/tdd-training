using NUnit.Framework;
using TddLibrary;

namespace TddLibraryTest
{
    [TestFixture]
    public class Tests
    {
        private FizzBuzz fizzbuzz;

        // 前準備
        [SetUp]
        public void Setup()
        {
            fizzbuzz = new FizzBuzz();
        }


        class _3の倍数の時は数の代わりにFizzを変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            [Test]
            public void _3を渡すと文字列Fizzを返す()
            {
                Assert.AreEqual("Fizz", fizzbuzz.convertTest(3));
            }
        }

        class _5の倍数の時は数の代わりにBuzzを変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            [Test]
            public void _5を渡すと文字列Buzzを返す()
            {
                Assert.AreEqual("Buzz", fizzbuzz.convertTest(5));
            }
        }

        class _その他の数の時はそのまま文字列に変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }

            [Test]
            public void _1を渡すと文字列1を返す()
            {
                Assert.AreEqual("1", fizzbuzz.convertTest(1));
            }

            [Test]
            public void _2を渡すと文字列2を返す()
            {
                Assert.AreEqual("2", fizzbuzz.convertTest(2));
            }
        }
    }
}