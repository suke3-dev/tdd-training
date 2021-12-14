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
        public void 整数閉区間が3から8のとき整数閉区間オブジェクトの下端点の値は3である()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual(3, tddProduct.closedRangeUnder());
        }

        [Test]
        public void 整数閉区間が2から5のとき整数閉区間オブジェクトの下端点の値は2である()
        {
            tddProduct.setCloseRange(2, 5);
            Assert.AreEqual(2, tddProduct.closedRangeUnder());
        }

        [Test]
        public void 整数閉区間が3から8のとき整数閉区間オブジェクトの上端点の値は8である()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual(8, tddProduct.closedRangeOver());
        }

        [Test]
        public void 整数閉区間が2から5のとき整数閉区間オブジェクトの上端点の値は5である()
        {
            tddProduct.setCloseRange(2, 5);
            Assert.AreEqual(5, tddProduct.closedRangeOver());
        }

        [Test]
        [TestCase(TestName = "下端点が3、上端点が8の時、整数閉区間オブジェクトによるの文字列表現は[3,8]である"), Description("")]
        public void 下端点が3で上端点が8のとき整数閉区間オブジェクトによる文字列表現が期待通りになる()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual("[3,8]", tddProduct.closedRangeString());
        }

        [Test]
        [TestCase(TestName = "下端点が2、上端点が5の時、整数閉区間オブジェクトによるの文字列表現は[2,5]である"), Description("")]
        public void 下端点が2で上端点が5のとき整数閉区間オブジェクトによる文字列表現が期待通りになる()
        {
            tddProduct.setCloseRange(2, 5);
            Assert.AreEqual("[2,5]", tddProduct.closedRangeString());
        }

        [Test]
        public void 上端点3より下端点8が大きい閉区間の場合判定がFalseとなる()
        {
            tddProduct.setCloseRange(8, 3);
            Assert.AreEqual(false, tddProduct.closedRangeCheck());
        }

        [Test]
        public void 上端点8より下端点3が大きい閉区間の場合判定がTrueとなる()
        {
            tddProduct.setCloseRange(3, 8);
            Assert.AreEqual(true, tddProduct.closedRangeCheck());
        }

    }
}