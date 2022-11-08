namespace nunit_sample;

public static class TestDelayer
{
    private const double TestDurationS = 10;
    
    private static int TestDurationMs => Convert.ToInt32(TestDurationS * 1000);

    public static void Delay()
    {
        Thread.Sleep(TestDurationMs);
    }
}
// dummy comment 1