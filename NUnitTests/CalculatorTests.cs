using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests
{
    [TestFixture()]
    public class CalculatorTests
    {
        private CCalculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new CCalculator();
        }
        [Test()]
        [TestCase(10,20,ExpectedResult=30)]
        [TestCase(100, 200, ExpectedResult = 300)]
        [TestCase(1000, 2000, ExpectedResult = 3000)]
        public int DDAddTest(int x, int y)
        {
            
            //Act 
            return calculator.Add(x, y);

        }

        [Test()]
        public void SubTest()
        {
            //Arrange
            int num1 = 200, num2 = 160;
            int expectedResult = 40;

            //Act 
            int result = calculator.Sub(num1, num2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]
        public void MulTest()
        {
            //Arrange
            int num1 = 20, num2 = 4;
            int expectedResult = 80;

            //Act 
            int result = calculator.Mul(num1, num2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test()]
        public void DivTest()
        {
            //Arrange
            int num1 = 40, num2 = 20;
            int expectedResult = 2;

            //Act 
            int result = calculator.Div(num1, num2);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test()]
        public void DivByZeroTest()
        {
            //Arrange
            int num1 = 0, num2 = 0;
            int expectedResult = 0;

            //Act // Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(num1, num2));

        }
    }
}