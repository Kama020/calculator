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

        [TestMethod]
        public void Calc_Sub_NN()
        {
            Calc.Calculator calc = new Calc.Calculator(-2, -1);
            Assert.AreEqual(calc.Subs(), -1);
        }
        [TestMethod]
        public void Calc_Sub_PN()
        {
            Calc.Calculator calc = new Calc.Calculator(2, -1);
            Assert.AreEqual(calc.Subs(), 3);
        }
        [TestMethod]
        public void Calc_Sub_NP()
        {
            Calc.Calculator calc = new Calc.Calculator(-2, 1);
            Assert.AreEqual(calc.Subs(), -3);
        }

        [TestMethod]
        public void Calc_Sub_Edge_PN()
        {
            Calc.Calculator calc = new Calc.Calculator(2147483647, -2147483647);
            Assert.AreEqual(calc.Subs(), 4294967294);
        }

        [TestMethod]
        public void Calc_Sub_Edge_NP()
        {
            Calc.Calculator calc = new Calc.Calculator(-2147483647, 2147483647);
            Assert.AreEqual(calc.Subs(), -4294967294);
        }

    }
    [TestClass]
    public class AddsTests
    {
        [TestMethod]
        public void Calc_Adds_PP()
        {
            Calc.Calculator calc = new Calc.Calculator(2, 1);
            Assert.AreEqual(calc.Adds(), 3);
        }
        [TestMethod]
        public void Calc_Adds_NN()
        {
            Calc.Calculator calc = new Calc.Calculator(-2, -1);
            Assert.AreEqual(calc.Adds(), -3);
        }
        [TestMethod]
        public void Calc_Adds_PN()
        {
            Calc.Calculator calc = new Calc.Calculator(2, -1);
            Assert.AreEqual(calc.Adds(), 1);
        }
        [TestMethod]
        public void Calc_Adds_NP()
        {
            Calc.Calculator calc = new Calc.Calculator(-2, 1);
            Assert.AreEqual(calc.Adds(), -1);
        }

        [TestMethod]
        public void Calc_Adds_Edge_PP()
        {
            Calc.Calculator calc = new Calc.Calculator(2147483647, 2147483647);
            Assert.AreEqual(calc.Adds(), 4294967294);
        }
        [TestMethod]
        public void Calc_Adds_Edge_NN()
        {
            Calc.Calculator calc = new Calc.Calculator(-2147483647, -2147483647);
            Assert.AreEqual(calc.Adds(), -4294967294);
        }
    }

    [TestClass]
    public class FirstIsPossitiveTests
    {
        [TestMethod]
        public void Calc_FirstIsPossitive_P()
        {
            Calc.Calculator calc = new Calc.Calculator(2, 1);
            Assert.AreEqual(calc.FirstIsPossitive(), true);
        }
        public void Calc_FirstIsPossitive_N()
        {
            Calc.Calculator calc = new Calc.Calculator(-2, 1);
            Assert.AreEqual(calc.FirstIsPossitive(), false);
        }
        public void Calc_FirstIsPossitive_0()
        {
            Calc.Calculator calc = new Calc.Calculator(0, 1);
            Assert.AreEqual(calc.FirstIsPossitive(), false);
        }
    }
    public class SecondIsPossitiveTests
    {
        [TestMethod]
        public void Calc_FirstIsPossitive_P()
        {
            Calc.Calculator calc = new Calc.Calculator(2, 1);
            Assert.AreEqual(calc.SecondIsPossitive(), true);
        }
        public void Calc_FirstIsPossitive_N()
        {
            Calc.Calculator calc = new Calc.Calculator(-2, -3);
            Assert.AreEqual(calc.SecondIsPossitive(), false);
        }
        public void Calc_FirstIsPossitive_0()
        {
            Calc.Calculator calc = new Calc.Calculator(0, 0);
            Assert.AreEqual(calc.SecondIsPossitive(), false);
        }
    }
}
