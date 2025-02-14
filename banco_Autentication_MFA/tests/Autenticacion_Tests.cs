using Xunit;
using BancoAutenticacion;
//Importacion de libreria de prueba y servicio de autenticacion

public class AuthenticationTests
{
    [Fact]
    public void MFA_Authentication_Successful() //Verificar que el MFA sea exitoso
    {
        var authService = new AuthService();    //Instancia del servicio de autenticacion
        bool result = authService.Login("user@sjnet.com", "Password123", "valid_mfa_code"); //Metodo Login para las credenciales correctas y codigo MFA valido
        Assert.True(result);
    }

    [Fact]
    public void MFA_Authentication_Fails_With_Wrong_Credentials() //Verificar que el MFA falle
    {
        var authService = new AuthService();
        bool result = authService.Login("user@sjnet.com", "SjNPr3ba9723", "valid_mfa_code");    // Metodo Login para las credenciales incorrectas y codigo MFA valido
        Assert.False(result);
    }
}

// Documentación

// Propósito de esta prueba unitaria

// **Banco (Autenticación MFA y Generación de codigo dinamico)**
// **Authenticacion_Tests.cs**: Estas pruebas validan la autenticación multifactor del usuario, asegurando que solo aquellos con credenciales válidas puedan acceder a su cuenta.
// - **1era parte: Inicio de sesión exitoso con MFA**: Un usuario con credenciales correctas y un código MFA válido debe poder iniciar sesión exitosamente.
// - **2da parte: Fallo en la autenticación por credenciales incorrectas**: Si un usuario proporciona credenciales incorrectas o un código MFA inválido, el acceso debe ser denegado.

// **AuthService.cs**: Valida la correcta generación de códigos de autenticación.
// - **1era parte: Generación de códigos dinámicos**: El sistema debe generar códigos únicos para cada intento de autenticación.
// - **2da parte: Expiración de códigos MFA**: Un código generado debe expirar después de cierto tiempo, evitando su reutilización.