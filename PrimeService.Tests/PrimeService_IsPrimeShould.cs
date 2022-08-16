using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;
using TestHelper;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService _primeService;
        
        [SetUp]
        public void Setup()
        {
            _primeService = new PrimeService();
        }

        [Test, TestCaseSource(nameof(GetTestCasesLessThan2))]
        public void IsPrime_ValueLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");

            string filePath = $"WriteLines{value}.txt";
            string[] lines =
            {
                $"{result}" 
            };
            Helper.IncreaseTestDuration();
            File.WriteAllLines(filePath, lines);
            TestContext.AddTestAttachment(filePath, "dummy attachment");
        }

        private static IEnumerable<int> GetTestCasesLessThan2()
        {
            return Enumerable.Range(0, 2);
        }
        
        [Test, TestCaseSource(nameof(GetTestCases))]
        public void IsPrime_EvenValueMoreThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");

            string filePath = $"WriteLines{value}.txt";
            string[] lines =
            {
                $"{result}" 
            };
            Helper.IncreaseTestDuration();
            File.WriteAllLines(filePath, lines);
            TestContext.AddTestAttachment(filePath, "dummy attachment");
        }

        private static IEnumerable<int> GetTestCases()
        {
            for (int i = 4; i <= 10; i += 2)
            {
                yield return i;
            }
        }
    }
}