using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Calc
{
    public class Calculator
    {
        private long val1, val2;
        public Calculator(long num1, long num2)
        {
            val1 = num1;
            val2 = num2;
        }
        public long Subs()
        {
            return val1 - val2;
        }
    }
        public long Adds()
    {
            return val1 + val2;
    }
    public bool FirstIsPossitive()
    {
        if (val1 > 0)
            return true;
        else
            return false;
    }
    public bool SecondIsPossitive()
    {
        if (val2 > 0)
            return true;
        else
            return false;
    }
}
