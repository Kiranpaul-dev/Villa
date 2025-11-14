namespace Villa.Services
{
    public interface ITestConnectionService
    {
        bool TestConnection(string server, string username, string password, out string errorMessage);
    }
}
