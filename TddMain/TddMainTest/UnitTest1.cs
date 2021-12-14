using NUnit.Framework;
using TddMain;

namespace TddMainTest
{
    public class Tests
    {

        public TddProduct tddProduct = new TddProduct();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ������Ԃ�3����8�̂Ƃ�������ԃI�u�W�F�N�g�̉��[�_�̒l��3�ł���()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual(3, tddProduct.closedRangeUnder());
        }

        [Test]
        public void ������Ԃ�2����5�̂Ƃ�������ԃI�u�W�F�N�g�̉��[�_�̒l��2�ł���()
        {
            tddProduct.setCloseRange(2, 5);
            Assert.AreEqual(2, tddProduct.closedRangeUnder());
        }

        [Test]
        public void ������Ԃ�3����8�̂Ƃ�������ԃI�u�W�F�N�g�̏�[�_�̒l��8�ł���()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual(8, tddProduct.closedRangeOver());
        }

        [Test]
        public void ������Ԃ�2����5�̂Ƃ�������ԃI�u�W�F�N�g�̏�[�_�̒l��5�ł���()
        {
            tddProduct.setCloseRange(2, 5);
            Assert.AreEqual(5, tddProduct.closedRangeOver());
        }

        [Test]
        [TestCase(TestName = "���[�_��3�A��[�_��8�̎��A������ԃI�u�W�F�N�g�ɂ��̕�����\����[3,8]�ł���"), Description("")]
        public void ���[�_��3�ŏ�[�_��8�̂Ƃ�������ԃI�u�W�F�N�g�ɂ�镶����\�������Ғʂ�ɂȂ�()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual("[3,8]", tddProduct.closedRangeString());
        }

        [Test]
        [TestCase(TestName = "���[�_��2�A��[�_��5�̎��A������ԃI�u�W�F�N�g�ɂ��̕�����\����[2,5]�ł���"), Description("")]
        public void ���[�_��2�ŏ�[�_��5�̂Ƃ�������ԃI�u�W�F�N�g�ɂ�镶����\�������Ғʂ�ɂȂ�()
        {
            tddProduct.setCloseRange(2, 5);
            Assert.AreEqual("[2,5]", tddProduct.closedRangeString());
        }

        [Test]
        public void ��[�_3��艺�[�_8���傫����Ԃ̏ꍇ���肪False�ƂȂ�()
        {
            tddProduct.setCloseRange(8, 3);
            Assert.AreEqual(false, tddProduct.closedRangeCheck());
        }

        [Test]
        public void ��[�_8��艺�[�_3���傫����Ԃ̏ꍇ���肪True�ƂȂ�()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual(true, tddProduct.closedRangeCheck());
        }

    }
}