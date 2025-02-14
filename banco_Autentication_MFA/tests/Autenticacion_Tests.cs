using Xunit;
using BancoAutenticacion;

public class AuthenticationTests
{
    [Fact]
    public void MFA_Authentication_Successful()
    {
        var authService = new AuthService();
        bool result = authService.Login("user@sjnet.com", "Password123", "valid_mfa_code");
        Assert.True(result);
    }

    [Fact]
    public void MFA_Authentication_Fails_With_Wrong_Credentials()
    {
        var authService = new AuthService();
        bool result = authService.Login("user@sjnet.com", "SjNPr3ba9723", "valid_mfa_code");
        Assert.False(result);
    }
}
