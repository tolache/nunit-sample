using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Prime.Services;

namespace Prime.UnitTests.Services
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

        [Test, TestCaseSource(nameof(GetTestCases))]
        public void IsPrime_ValueLessThan2_ReturnFalse(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime");
        }

        private static IEnumerable<int> GetTestCases()
        {
            return Enumerable.Range(1, 9500);
        }
    }
}