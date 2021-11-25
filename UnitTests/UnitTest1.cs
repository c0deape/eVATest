using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CandidateTest;

namespace CandidateUnitTests
{
    [TestClass]
    public class CandidateUnitTests
    {
        [TestMethod]
        public void BonusCalculationIsCorrect()
        {
            var calculatedValue = TestFunctions.BonusCalculation(100, 200.20);
            var expectedValue = 20020;
            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }

        [TestMethod]
        public void NamesAreUnique()
        {
            string[] names1 = { "Ava", "Emma", "Olivia" };
            string[] names2 = { "Olivia", "Sophia", "Emma" };
            string[] expectedValue = { "Ava", "Emma", "Olivia", "Sophia"};
            var calculatedValue = string.Join(", ", TestFunctions.UniqueNames(names1, names2));

            Assert.AreEqual(expectedValue,calculatedValue,"Value is incorrect");
        }
        [TestMethod]
        public void PopularLetter()
        {
            var calculatedValue = TestFunctions.PopularLetter("I want to work for Cox Automotive");
            var expectedValue = 'o';

            Assert.AreEqual(expectedValue, calculatedValue, "Value is incorrect");
        }
    }
}
