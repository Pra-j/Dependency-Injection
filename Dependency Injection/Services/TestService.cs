namespace Dependency_Injection.Services
{
    public class TestService : ITestService
    {
        public string GetMessage()
        {
            return "Hello from TestService";
        }
    }
}
