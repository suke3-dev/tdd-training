using NUnit.Framework;
using TddLibrary;

namespace TddLibraryTest
{
    [TestFixture]
    public class Tests
    {
        private FizzBuzz fizzbuzz;

        // �O����
        [SetUp]
        public void Setup()
        {
            fizzbuzz = new FizzBuzz();
        }

        
        class _3�̔{���̎��͐��̑����Fizz��ϊ�����
        {
            private FizzBuzz fizzbuzz;

            // �O����
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            [Test]
            public void _3��n���ƕ�����Fizz��Ԃ�()
            {
                Assert.AreEqual("Fizz", fizzbuzz.convertTest(3));
            }
        }

        class _5�̔{���̎��͐��̑����Buzz��ϊ�����
        {
            private FizzBuzz fizzbuzz;

            // �O����
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }


            [Test]
            public void _5��n���ƕ�����Buzz��Ԃ�()
            {
                Assert.AreEqual("Buzz", fizzbuzz.convertTest(5));
            }
        }

        class _���̑��̐��̎��͂��̂܂ܕ�����ɕϊ�����
        {
            private FizzBuzz fizzbuzz;

            // �O����
            [SetUp]
            public void Setup()
            {
                fizzbuzz = new FizzBuzz();
            }

            [Test]
            public void _1��n���ƕ�����1��Ԃ�()
            {
                Assert.AreEqual("1", fizzbuzz.convertTest(1));
            }

            [Test]
            public void _2��n���ƕ�����2��Ԃ�()
            {
                Assert.AreEqual("2", fizzbuzz.convertTest(2));
            }
        }
    }
}