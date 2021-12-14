using NUnit.Framework;
using TddMain;

namespace TddMainTest
{
    public class ������Ԃ̃e�X�g
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
        public class ������ԃI�u�W�F�N�g�͉��[�_������: ������Ԃ̃e�X�g
        {
            [Test]
            [TestCase(TestName = "������Ԃ�[3,8]�̂Ƃ��A������ԃI�u�W�F�N�g�̉��[�_�̒l��3�ł���")]
            public void UnderTest1()
            {
               Assert.AreEqual(3, closedRange3To8.closedRangeLower());
            }

            [Test]
            [TestCase(TestName = "������Ԃ�[2,5]�̂Ƃ��A������ԃI�u�W�F�N�g�̉��[�_�̒l��2�ł���")]
            public void UnderTest2()
            {
                Assert.AreEqual(2, closedRange2To5.closedRangeLower());
            }

            [Test]
            [TestCase(TestName = "������Ԃ�[-4,-2]�̂Ƃ��A������ԃI�u�W�F�N�g�̉��[�_�̒l��-4�ł���")]
            public void UnderTest3()
            {
                Assert.AreEqual(-4, closedRangeMinus4ToMinus2.closedRangeLower());
            }
        }

        [TestFixture]
        public class ������ԃI�u�W�F�N�g�͏�[�_������ : ������Ԃ̃e�X�g
        {
            [Test]
            [TestCase(TestName = "������Ԃ�[3,8]�̂Ƃ��A������ԃI�u�W�F�N�g�̏�[�_�̒l��8�ł���")]
            public void OverTest1()
            {
                Assert.AreEqual(8, closedRange3To8.closedRangeUpper());
            }

            [Test]
            [TestCase(TestName = "������Ԃ�[2,5]�̂Ƃ��A������ԃI�u�W�F�N�g�̏�[�_�̒l��5�ł���")]
            public void OverTest2()
            {
                Assert.AreEqual(5, closedRange2To5.closedRangeUpper());
            }

            [Test]
            [TestCase(TestName = "������Ԃ�[-4,-2]�̂Ƃ��A������ԃI�u�W�F�N�g�̏�[�_�̒l��-2�ł���")]
            public void OverTest3()
            {
                Assert.AreEqual(-2, closedRangeMinus4ToMinus2.closedRangeUpper());
            }
        }

        [TestFixture]
        public class ������Ԃ𕶎���\������ : ������Ԃ̃e�X�g
        {
            [Test]
            [TestCase(TestName = "���[�_��3�A��[�_��8�̎��A������ԃI�u�W�F�N�g�ɂ��̕�����\����[3,8]�ł���")]
            public void RangeStringTest1()
            {
                Assert.AreEqual("[3,8]", closedRange3To8.closedRangeString());
            }

            [Test]
            [TestCase(TestName = "���[�_��2�A��[�_��5�̎��A������ԃI�u�W�F�N�g�ɂ��̕�����\����[2,5]�ł���")]
            public void RangeStringTest2()
            {
                Assert.AreEqual("[2,5]", closedRange2To5.closedRangeString());
            }

            [Test]
            [TestCase(TestName = "���[�_��-4�A��[�_��-2�̎��A������ԃI�u�W�F�N�g�ɂ��̕�����\����[-4,-2]�ł���")]
            public void RangeStringTest3()
            {
                Assert.AreEqual("[-4,-2]", closedRangeMinus4ToMinus2.closedRangeString());
            }
        }

        [TestFixture]
        public class ��[�_��艺�[�_���傫����Ԃ���邱�Ƃ͂ł��Ȃ� : ������Ԃ̃e�X�g
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
            [TestCase(TestName = "��[�_3��艺�[�_8���傫����Ԃ̏ꍇ���肪False�ƂȂ�")]
            public void rangeCheckTest1()
            {
                Assert.AreEqual(false, closedRange8To3.closedRangeCheck());
            }

            [Test]
            [TestCase(TestName = "��[�_8��艺�[�_3���傫����Ԃ̏ꍇ���肪True�ƂȂ�")]
            public void rangeCheckTest2()
            {
                Assert.AreEqual(true, closedRange3To8.closedRangeCheck());
            }

            [Test]
            [TestCase(TestName = "��[�_3�Ɖ��[�_3��������Ԃ̏ꍇ���肪True�ƂȂ�")]
            public void rangeCheckTest3()
            {
                Assert.AreEqual(true, closedRangeEqual.closedRangeCheck());
            }
        }

        [TestFixture]
        public class �����̕�Ԃ͎w�肵���������܂ނ��ǂ����𔻒�ł��� : ������Ԃ̃e�X�g
        {
            private ClosedRange closedRangeEqual;

            [SetUp]
            public new void SetUp()
            {
                closedRangeEqual = new ClosedRange(3, 3);
            }

            [Test]
            [TestCase(3, TestName = "�������[3,8]�̒���3���܂܂�Ă��邩�m�F���A���肪True�ƂȂ�")]
            [TestCase(8, TestName = "�������[3,8]�̒���8���܂܂�Ă��邩�m�F���A���肪True�ƂȂ�")]
           
            public void ConteinTest1(int checkNum)
            {
                Assert.AreEqual(true, closedRange3To8.containInteger(checkNum));
            }

            [Test]
            [TestCase(2, TestName = "�������[3,8]�̒���2���܂܂�Ă��邩�m�F���A���肪False�ƂȂ�")]
            [TestCase(9, TestName = "�������[3,8]�̒���9���܂܂�Ă��邩�m�F���A���肪False�ƂȂ�")]

            public void ConteinTest2(int checkNum)
            {
                Assert.AreEqual(false, closedRange3To8.containInteger(checkNum));
            }

            [Test]
            [TestCase(2, TestName = "�������[3,3]�̒���2���܂܂�Ă��邩�m�F���A���肪False�ƂȂ�")]
            public void ConteinTest3(int checkNum)
            {
                Assert.AreEqual(false, closedRange3To8.containInteger(checkNum));
            }

            [Test]
            [TestCase(3, TestName = "�������[3,3]�̒���3���܂܂�Ă��邩�m�F���A���肪True�ƂȂ�")]
            public void ConteinTest4(int checkNum)
            {
                Assert.AreEqual(true, closedRange3To8.containInteger(checkNum));
            }
        }

        [TestFixture]
        public class ������Ԃ��ʂ̕�ԂƓ������ǂ����𔻒肷��
        {
            [Test]
            [TestCase(TestName = "�������[3,8]�͐������[3,9]�Ɠ����ł͂Ȃ��̂ŁA���肪False�ƂȂ�")]
            public void containRangeTest1()
            {
                Assert.AreEqual(false, closedRange3To8.containRange(3, 9));
            }
        }
    }
}