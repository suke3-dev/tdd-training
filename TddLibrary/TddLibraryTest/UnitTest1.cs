using NUnit.Framework;
using TddLibrary;

namespace TddLibraryTest
{
    [TestFixture]
    public class Tests
    {
        private FizzBuzz fizzbuzz;

        // ‘O€”õ
        [SetUp]
        public void Setup()
        {
            fizzbuzz = new FizzBuzz();
        }

        [Test]
        public void _1‚ğ“n‚·‚Æ•¶š—ñ1‚ğ•Ô‚·()
        {
            Assert.AreEqual("1", fizzbuzz.convertTest(1));
        }

        [Test]
        public void _2‚ğ“n‚·‚Æ•¶š—ñ2‚ğ•Ô‚·()
        {
            Assert.AreEqual("2", fizzbuzz.convertTest(2));
        }

        [Test]
        public void _3‚ğ“n‚·‚Æ•¶š—ñFizz‚ğ•Ô‚·()
        {
            Assert.AreEqual("Fizz", fizzbuzz.convertTest(3));
        }

        [Test]
        public void _5‚ğ“n‚·‚Æ•¶š—ñBuzz‚ğ•Ô‚·()
        {
            Assert.AreEqual("Buzz", fizzbuzz.convertTest(5));
        }
    }

}