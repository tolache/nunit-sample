using NUnit.Framework;

namespace TestHelper;

public static class Helper
{
    public static void IncreaseTestDuration()
    {
        int testDurationSec = 10; 
        TestContext.Out.WriteLine($"Falling asleep for {testDurationSec}...");
        Thread.Sleep(testDurationSec * 1000);
        TestContext.Out.WriteLine("Woken up.");
    }
}