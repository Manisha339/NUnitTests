using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Calculator;

namespace NUnitTests
{
    [TestFixture()]
    public class CalculatorTests
    {
        private CCalculator calculator;

        static List<TestCaseData> TestCases
        {
            get
            {
                return AddTestData.Get();
            }
        }

        [SetUp]
        public void Setup()
        {
            /*Mock<Offset> mockObj = new Mock<Offset>();
            mockObj.Setup(m => m.Get()).Returns(100);
            calculator = new CCalculator(mockObj.Object);*/
            FakeOffset fake = new FakeOffset();
            calculator = new CCalculator(fake);
            
        }
        [Test()]
        public void AddWithOffset_Test()
        {
            // Arrange
            int num1 = 20, num2 = 40;
            int expectedResult = 160;

            // Act
            int result = calculator.AddWithOffset(num1, num2);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        [Test()]
        [TestCaseSource("TestCases")]
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