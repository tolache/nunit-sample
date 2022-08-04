namespace CalculatorService.Tests;

public class CalculatorService_Addition
{
    private global::CalculatorService.CalculatorService _calculatorService;
        
    [SetUp]
    public void Setup()
    {
        _calculatorService = new global::CalculatorService.CalculatorService();
    }

    [Test, TestCaseSource(nameof(GetTestCases))]
    public void AddTwoTerms_AddsCorrectly(Tuple<int,int> terms)
    {
        int sum = terms.Item1 + terms.Item2;
        Assert.That(_calculatorService.AddTwoTerms(terms.Item1, terms.Item2), Is.EqualTo(sum));
    }
    
    private static IEnumerable<Tuple<int,int>> GetTestCases()
    {
        return new Tuple<int, int>[] {new Tuple<int, int>(2, 3), new Tuple<int, int>(4, 5)};
    }
}