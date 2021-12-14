namespace TddMain
{
    public class ClosedRange
    {
        // 変数
        public int lowerNum { get; set; } // 下端点
        public int upperNum { get; set; } // 上端点


        public ClosedRange(int num1, int num2)
        {
            lowerNum = num1;
            upperNum = num2;
        }

        public int closedRangeLower()
        {
            return lowerNum;
        }

        public int closedRangeUpper()
        {
            return upperNum;
        }

        public string closedRangeString()
        {
            return "[" + lowerNum + "," + upperNum + "]";
        }

        public bool closedRangeCheck()
        {

            if(lowerNum > upperNum)
            {
                return false;
            }
            return true;
        }

        public bool containInteger(int checkNum)
        {

            if (lowerNum <= checkNum && checkNum <= upperNum)
            {
                return true;
            }
            return false;
        }

        public bool containRange(int checkLowerNum, int checkUpperNum)
        {

            if (checkLowerNum == lowerNum && checkUpperNum == upperNum)
            {
                return true;
            }
            return false;
        }
    }
}