namespace BancoAutenticacion
{
    public class AuthService
    {
        public bool Login(string email, string password, string mfaCode)
        {
            return email == "user@sjnet.com" 
                && password == "Password123" 
                && mfaCode == "valid_mfa_code";
        }
    }
}
