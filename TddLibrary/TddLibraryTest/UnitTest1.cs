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


        class _3の倍数の時は数の代わりにFizzに変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            //[Test]
            //public void 同値類の中の最小の3の倍数である3を渡すと文字列Fizzを返す()
            //{
            //    Assert.AreEqual("Fizz", fizzbuzz.convertTest(3));
            //}
            //[Test]
            //public void 上限の境界値の一つ内側であり同値類の中の最大の3の倍数である99を渡すと文字列Fizzを返す()
            //{
            //    Assert.AreEqual("Fizz", fizzbuzz.convertTest(99));
            //}
            [Test]
            [TestCase(3, TestName = " 同値類の中の最小の3の倍数である3を渡すと文字列Fizzを返す")]
            [TestCase(99, TestName = " 上限の境界値の一つ内側であり同値類の中の最大の3の倍数である99を渡すと文字列Fizzを返す")]
            public void _3の倍数の時は数の代わりにFizzに変換するよ(int num)
            {
                Assert.AreEqual("Fizz", fizzbuzz.convertTest(num));
            }

        }

        

        class _5の倍数の時は数の代わりにBuzzに変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            [Test]
            public void 同値類の中の最小の5の倍数である5を渡すと文字列Buzzを返す()
            {
                Assert.AreEqual("Buzz", fizzbuzz.convertTest(5));
            }
            [Test]
            public void 上限の境界値であり同値類の中の最大の5の倍数である100を渡すと文字列Buzzを返す()
            {
                Assert.AreEqual("Buzz", fizzbuzz.convertTest(100));
            }
        }

        class _3と5両方の倍数の時は数の代わりにFizzBuzzに変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            [Test]
            public void 同値類の中の最小の3と5の公倍数である15を渡すと文字列FizzBuzzを返す()
            {
                Assert.AreEqual("FizzBuzz", fizzbuzz.convertTest(15));
            }
        }

        class その他の数の時はそのまま文字列に変換する
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }

            [Test]
            public void 下限の境界値である1を渡すと文字列1を返す()
            {
                Assert.AreEqual("1", fizzbuzz.convertTest(1));
            }

            [Test]
            public void 下限の境界値の1つ内側である2を渡すと文字列2を返す()
            {
                Assert.AreEqual("2", fizzbuzz.convertTest(2));
            }
        }

        class 仕様の範囲外の値であっても同様の変換規則が適用される
        {
            private FizzBuzz fizzbuzz;

            // 前準備
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }

            [Test]
            public void 上限の境界値の1つ外側である101を渡すと文字列101を返す()
            {
                Assert.AreEqual("101", fizzbuzz.convertTest(101));
            }
            [Test]
            public void 下限の境界値の1つ外側である0は3と5の公倍数でもあるので文字列FizzBuzzを返す()
            {
                Assert.AreEqual("FizzBuzz", fizzbuzz.convertTest(0));
            }
        }
    }
}