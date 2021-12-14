using NUnit.Framework;
using TddMain;

namespace TddMainTest
{
    public class 整数閉区間のテスト
    {
        public static ClosedRange closedRange3To8;
        public static ClosedRange closedRange2To5;
        public static ClosedRange closedRangeMinus4ToMinus2;

        [SetUp]
        public void SetUp()
        {
            closedRange3To8 = new ClosedRange(3, 8);
            closedRange2To5 = new ClosedRange(2, 5);
            closedRangeMinus4ToMinus2 = new ClosedRange(-4, -2);
        }

        [TestFixture]
        public class 整数閉区間オブジェクトは下端点をもつ: 整数閉区間のテスト
        {
            [Test]
            [TestCase(TestName = "整数閉区間が[3,8]のとき、整数閉区間オブジェクトの下端点の値は3である")]
            public void UnderTest1()
            {
               Assert.AreEqual(3, closedRange3To8.closedRangeLower());
            }

            [Test]
            [TestCase(TestName = "整数閉区間が[2,5]のとき、整数閉区間オブジェクトの下端点の値は2である")]
            public void UnderTest2()
            {
                Assert.AreEqual(2, closedRange2To5.closedRangeLower());
            }

            [Test]
            [TestCase(TestName = "整数閉区間が[-4,-2]のとき、整数閉区間オブジェクトの下端点の値は-4である")]
            public void UnderTest3()
            {
                Assert.AreEqual(-4, closedRangeMinus4ToMinus2.closedRangeLower());
            }
        }

        [TestFixture]
        public class 整数閉区間オブジェクトは上端点をもつ : 整数閉区間のテスト
        {
            [Test]
            [TestCase(TestName = "整数閉区間が[3,8]のとき、整数閉区間オブジェクトの上端点の値は8である")]
            public void OverTest1()
            {
                Assert.AreEqual(8, closedRange3To8.closedRangeUpper());
            }

            [Test]
            [TestCase(TestName = "整数閉区間が[2,5]のとき、整数閉区間オブジェクトの上端点の値は5である")]
            public void OverTest2()
            {
                Assert.AreEqual(5, closedRange2To5.closedRangeUpper());
            }

            [Test]
            [TestCase(TestName = "整数閉区間が[-4,-2]のとき、整数閉区間オブジェクトの上端点の値は-2である")]
            public void OverTest3()
            {
                Assert.AreEqual(-2, closedRangeMinus4ToMinus2.closedRangeUpper());
            }
        }

        [TestFixture]
        public class 整数閉区間を文字列表現する : 整数閉区間のテスト
        {
            [Test]
            [TestCase(TestName = "下端点が3、上端点が8の時、整数閉区間オブジェクトによるの文字列表現は[3,8]である")]
            public void RangeStringTest1()
            {
                Assert.AreEqual("[3,8]", closedRange3To8.closedRangeString());
            }

            [Test]
            [TestCase(TestName = "下端点が2、上端点が5の時、整数閉区間オブジェクトによるの文字列表現は[2,5]である")]
            public void RangeStringTest2()
            {
                Assert.AreEqual("[2,5]", closedRange2To5.closedRangeString());
            }

            [Test]
            [TestCase(TestName = "下端点が-4、上端点が-2の時、整数閉区間オブジェクトによるの文字列表現は[-4,-2]である")]
            public void RangeStringTest3()
            {
                Assert.AreEqual("[-4,-2]", closedRangeMinus4ToMinus2.closedRangeString());
            }
        }

        [TestFixture]
        public class 上端点より下端点が大きい閉区間を作ることはできない : 整数閉区間のテスト
        {

            private ClosedRange closedRange8To3;
            private ClosedRange closedRangeEqual;

            [SetUp]
            public new void SetUp()
            {
                closedRange8To3 = new ClosedRange(8, 3);
                closedRangeEqual = new ClosedRange(3, 3);
            }

            [Test]
            [TestCase(TestName = "上端点3より下端点8が大きい閉区間の場合判定がFalseとなる")]
            public void rangeCheckTest1()
            {
                Assert.AreEqual(false, closedRange8To3.closedRangeCheck());
            }

            [Test]
            [TestCase(TestName = "上端点8より下端点3が大きい閉区間の場合判定がTrueとなる")]
            public void rangeCheckTest2()
            {
                Assert.AreEqual(true, closedRange3To8.closedRangeCheck());
            }

            [Test]
            [TestCase(TestName = "上端点3と下端点3が同じ閉区間の場合判定がTrueとなる")]
            public void rangeCheckTest3()
            {
                Assert.AreEqual(true, closedRangeEqual.closedRangeCheck());
            }
        }

        [TestFixture]
        public class 整数の閉区間は指定した整数を含むかどうかを判定できる : 整数閉区間のテスト
        {
            private ClosedRange closedRangeEqual;

            [SetUp]
            public new void SetUp()
            {
                closedRangeEqual = new ClosedRange(3, 3);
            }

            [Test]
            [TestCase(3, TestName = "整数閉区間[3,8]の中に3が含まれているか確認し、判定がTrueとなる")]
            [TestCase(8, TestName = "整数閉区間[3,8]の中に8が含まれているか確認し、判定がTrueとなる")]
           
            public void ConteinTest1(int checkNum)
            {
                Assert.AreEqual(true, closedRange3To8.containInteger(checkNum));
            }

            [Test]
            [TestCase(2, TestName = "整数閉区間[3,8]の中に2が含まれているか確認し、判定がFalseとなる")]
            [TestCase(9, TestName = "整数閉区間[3,8]の中に9が含まれているか確認し、判定がFalseとなる")]

            public void ConteinTest2(int checkNum)
            {
                Assert.AreEqual(false, closedRange3To8.containInteger(checkNum));
            }

            [Test]
            [TestCase(2, TestName = "整数閉区間[3,3]の中に2が含まれているか確認し、判定がFalseとなる")]
            public void ConteinTest3(int checkNum)
            {
                Assert.AreEqual(false, closedRange3To8.containInteger(checkNum));
            }

            [Test]
            [TestCase(3, TestName = "整数閉区間[3,3]の中に3が含まれているか確認し、判定がTrueとなる")]
            public void ConteinTest4(int checkNum)
            {
                Assert.AreEqual(true, closedRange3To8.containInteger(checkNum));
            }
        }

        [TestFixture]
        public class 整数閉区間が別の閉区間と等価かどうかを判定する
        {
            [Test]
            [TestCase(TestName = "整数閉区間[3,8]は整数閉区間[3,9]と等価ではないので、判定がFalseとなる")]
            public void containRangeTest1()
            {
                Assert.AreEqual(false, closedRange3To8.containRange(3, 9));
            }
        }
    }
}