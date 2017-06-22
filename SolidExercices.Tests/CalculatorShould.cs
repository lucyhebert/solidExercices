using System;
using System.IO;
using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3);
        }

        [Test]
        public void CalculateASubstraction()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("3,5-1");
            Check.That(result).IsEqualTo(2.5);
        }

        [Test]
        public void CalculateAProduct()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2*2,3");
            Check.That(result).IsEqualTo(4.6);
        }

        [Test]
        public void CalculateADivision()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("6/2");
            Check.That(result).IsEqualTo(3);
        }

        [Test]
        public void ShowErrorIfMoreThan2Numbers()
        {
            var calculator = new Calculator();

            Assert.Throws<ArgumentException>(() => calculator.Calculate("6/2+3"));
        }
    }
}
