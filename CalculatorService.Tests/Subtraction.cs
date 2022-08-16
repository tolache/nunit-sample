using TestHelper;

namespace CalculatorService.Tests;

public class Subtraction
{
    private CalculatorService _calculatorService;

    [SetUp]
    public void Setup()
    {
        _calculatorService = new CalculatorService();
    }

    [Test, TestCaseSource(nameof(GetTestCases))]
    public void SubtractTwoTerms_SubtractsCorrectly(int minuend, int subtrahend)
    {
        int difference = minuend - subtrahend;
        Assert.That(_calculatorService.SubtractTwoTerms(minuend, subtrahend), Is.EqualTo(difference));
        Helper.IncreaseTestDuration();
    }

    private static IEnumerable<int[]> GetTestCases()
    {
        yield return
            new[] {1, 2};

        yield return
            new[] {4, 3};
    }
}