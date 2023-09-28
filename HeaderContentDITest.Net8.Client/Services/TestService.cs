namespace RenderModeAutoDIBug.Client.Services;

public class TestService : ITestService
{
    public void TestMethod(string message)
        => Console.WriteLine($"{nameof(TestMethod)} Msg: {message}");
}
