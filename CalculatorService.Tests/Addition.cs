using TestHelper;

namespace CalculatorService.Tests;

public class Addition
{
    private CalculatorService _calculatorService;
        
    [SetUp]
    public void Setup()
    {
        _calculatorService = new CalculatorService();
    }

    [Test, TestCaseSource(nameof(GetTestCases))]
    public void AddTwoTerms_AddsCorrectly(Tuple<int,int> terms)
    {
        int sum = terms.Item1 + terms.Item2;
        Assert.That(_calculatorService.AddTwoTerms(terms.Item1, terms.Item2), Is.EqualTo(sum));
        Helper.IncreaseTestDuration();
    }
    
    private static IEnumerable<Tuple<int,int>> GetTestCases()
    {
        return new[] {new Tuple<int, int>(2, 3), new Tuple<int, int>(4, 5)};
    }
}