using System;
using NUnit.Framework;

namespace LogAn.UnitTests
{
    [TestFixture]
    class MemCalculatorTest
    {
        private static MemCalculator MakeMemCalculator()
        {
            return new MemCalculator();
        }

        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator mc = MakeMemCalculator();
            var sum = mc.Sum();
            Assert.AreEqual(0, sum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            MemCalculator mc = MakeMemCalculator();
            mc.Add(1);
            var sum = mc.Sum();
            Assert.AreEqual(1, sum);
        }
    }
}
