using NUnit.Framework;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int num = 20;
            Assert.True(num == 20);
            Assert.Pass();
        }

        [Test]
        public void NewTest()
        {
            int total = 100, marks1 = 60, marks2 = 75;
            Assert.That(marks1, Is.Not.EqualTo(marks2));
            Assert.That(marks1, Is.LessThan(marks2));
            Assert.That(marks1, Is.InRange(50,80));
        }
        [Test]
        public void Warnings()
        {
            int total = 100, marks1 = 160, marks2 = 75;
            Warn.If(marks1 > 100);
            Warn.Unless(marks1 + marks2 < 200);
            Assert.Warn("This is a test Warning message");
        }
    }
}