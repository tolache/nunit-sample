namespace CalculatorService.Tests;

public class Subtraction
{
    private global::CalculatorService.CalculatorService _calculatorService;
        
    [SetUp]
    public void Setup()
    {
        _calculatorService = new global::CalculatorService.CalculatorService();
    }

    [Test, TestCaseSource(nameof(GetTestCases))]
    public void SubtractTwoTerms_SubtractsCorrectly(int minuend, int subtrahend)
    {
        int difference = minuend - subtrahend;
        Assert.That(_calculatorService.SubtractTwoTerms(minuend, subtrahend), Is.EqualTo(difference));
    }
    
    private static IEnumerable<int[]> GetTestCases()
    {
        yield return
            new int[] {1, 2};

        yield return
            new int[] {4, 3};
    }
}