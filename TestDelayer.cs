namespace nunit_sample;

public static class TestDelayer
{
    private const double TestDurationS = 0.1;
    
    private static int TestDurationMs => Convert.ToInt32(TestDurationS * 1000);

    public static void Delay()
    {
        Thread.Sleep(TestDurationMs);
    }
}
