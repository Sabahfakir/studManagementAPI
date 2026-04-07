namespace studManagementAPI.Services
{
    public interface ITokenService
    {
        string GenerateToken(string username);
    }
}
