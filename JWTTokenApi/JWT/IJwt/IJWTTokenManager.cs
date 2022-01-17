namespace JWTTokenApi.JWT.IJwt
{
    public interface IJWTTokenManager
    {
        string Authenticate(string username, string password);
    }
}
