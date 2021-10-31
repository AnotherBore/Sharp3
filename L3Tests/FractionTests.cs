using Microsoft.VisualStudio.TestTools.UnitTesting;
using L3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3.Tests
{
    [TestClass()]
    public class FractionTests
    {
        [TestMethod()]
        public void WriteTest()
        {
            var fraction = new Fraction(1, 5);
            Assert.AreEqual("0 1 5", fraction.Write());
        }

        [TestMethod()]

        public void ReductionTest()
        {
            var fraction = new Fraction(2, 10);
            fraction.Reduction();
            Assert.AreEqual("0 1 5", fraction.Write());
        }

        [TestMethod()]
        public void AddingTest()
        {
            var fraction1 = new Fraction(5, 2);
            var fraction2 = new Fraction(7, 3);
            var fraction3 = fraction1 + fraction2;
            Assert.AreEqual("4 5 6", fraction3.Write());
        }
        [TestMethod()]
        public void DivisionTest()
        {
            var fraction1 = new Fraction(2, 10);
            var fraction2 = new Fraction(2, 1);
            var fraction3 = fraction1 / fraction2;
            Assert.AreEqual("0 1 10", fraction3.Write());
        }
        [TestMethod()]
        public void MultiplyTest()
        {
            var fraction1 = new Fraction(2, 10);
            var fraction2 = new Fraction(10, 2);
            var fraction3 = fraction1 * fraction2;
            Assert.AreEqual("1 0 1", fraction3.Write());
        }
        [TestMethod()]
        public void MinusTest()
        {
            var fraction1 = new Fraction(5, 2);
            var fraction2 = new Fraction(7, 3);
            var fraction3 = fraction1 - fraction2;
            Assert.AreEqual("0 1 6", fraction3.Write());
        }
        [TestMethod()]
        public void ComparisonTest()
        {
            var fraction1 = new Fraction(2, 10);
            var fraction2 = new Fraction(1, 10);
            int a = Fraction.Comparison(fraction1, fraction2);
            Assert.AreEqual(1, a);
        }
    }
}