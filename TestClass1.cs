namespace nunit_sample;

[TestFixture]
public class TestClass1
{
    private string _className;
    
    [SetUp]
    public void Setup()
    {
        _className = GetType().Name;
    }

    [Test]
    public void Test1()
    {
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{_className}.{methodName}";
        TestDelayer.Delay();
        TestContext.Out.WriteLine($"Application root folder: " +
                                  $"{Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)}");
        TestContext.Out.WriteLine($"{testName} completed.");
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{_className}.{methodName}";
        TestDelayer.Delay();
        TestContext.Out.WriteLine($"{testName} completed.");
        Assert.Pass();
    }
    
    [Test]
    public void Test3()
    {
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{_className}.{methodName}";
        TestDelayer.Delay();
        TestContext.Out.WriteLine($"{testName} completed.");
        Assert.Pass();
    }
    
    [Test]
    public void Test4()
    {
        string methodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
        string testName = $"{_className}.{methodName}";
        TestDelayer.Delay();
        TestContext.Out.WriteLine($"{testName} completed.");
        Assert.Pass();
    }
}