namespace Dependency_Injection.Services
{
    public class HomeService : IHomeService
    {
        public string GetMessage()
        {
            return "Hello from HomeService";
        }
    }
}
