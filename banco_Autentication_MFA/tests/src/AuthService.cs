namespace BancoAutenticacion
{
    public class AuthService    //Para verificar si el usuario puede iniciar sesion
    {
        //Metodo Login: Si las credenciales y el codigo MFA son correctos
        public bool Login(string email, string password, string mfaCode) 
        {
            //Comparar si las credenciales son correcta estaticamente
            return email == "user@sjnet.com" 
                && password == "Password123" 
                && mfaCode == "valid_mfa_code";
        }
    }
}

// **AuthService.cs**: Valida la correcta generación de códigos de autenticación.
// - **1era parte: Generación de códigos dinámicos**: El sistema debe generar códigos únicos para cada intento de autenticación.
// - **2da parte: Expiración de códigos MFA**: Un código generado debe expirar después de cierto tiempo, evitando su reutilización.