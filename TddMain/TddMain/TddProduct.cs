namespace TddMain
{
    public class TddProduct
    {
        // 変数
        private int underNum; // 下端点
        private int overNum; // 上端点


        public void setCloseRange(int num1, int num2)
        {
            underNum = num1;
            overNum = num2;
        }

        public int closedRangeUnder()
        {
            return underNum;
        }

        public int closedRangeOver()
        {
            return overNum;
        }

        public string closedRangeString()
        {
            return "[" + underNum + "," + overNum + "]";
        }

        public bool closedRangeCheck()
        {
            return false;
        }
    }
}