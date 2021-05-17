using Calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Unittests
{
    [TestClass]
    public class SubTests
    {
        [TestMethod]
        public void Calc_Sub_PP()
        {
            Calc.Calculator calc = new Calc.Calculator(2, 1);
            Assert.AreEqual(calc.Subs(), 1);
        }
    }
}
