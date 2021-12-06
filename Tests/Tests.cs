using AdventOfCode2021;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TestDay01()
        {
            var result1 = Day01.CalculatePart1(@"Data\inputDay01.dat");
            Assert.AreEqual(1316, result1);
            var result2 = Day01.CalculatePart2(@"Data\inputDay01.dat");
            Assert.AreEqual(1344, result2);
        }

        [Test]
        public void TestDay02()
        {
            var result1 = Day02.CalculatePart1(@"Data\inputDay02.dat");
            Assert.AreEqual(1815044, result1);
            var result2 = Day02.CalculatePart2(@"Data\inputDay02.dat");
            Assert.AreEqual(1739283308, result2);
        }

        [Test]
        public void TestDay03()
        {
            var result1 = Day03.CalculatePart1(@"Data\inputDay03.dat");
            Assert.AreEqual(845186, result1);
            var result2 = Day03.CalculatePart2(@"Data\inputDay03.dat");
            Assert.AreEqual(4636702, result2);
        }

        [Test]
        public void TestDay04()
        {
            var result1 = Day04.CalculatePart1(@"Data\inputDay04.dat");
            Assert.AreEqual(8442, result1);
            var result2 = Day04.CalculatePart2(@"Data\inputDay04.dat");
            Assert.AreEqual(4590, result2);
        }

        [Test]
        public void TestDay05()
        {
            var result1 = Day05.CalculatePart1(@"Data\inputDay05.dat");
            Assert.AreEqual(5835, result1);
            var result2 = Day05.CalculatePart2(@"Data\inputDay05.dat");
            Assert.AreEqual(17013, result2);
        }
    }
}