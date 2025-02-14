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

# Documentación

## Propósito de esta prueba unitaria

### **Banco (Autenticación MFA y Generación de codigo dinamico)**
- **Authenticacion_Tests.cs**: Estas pruebas validan la autenticación multifactor del usuario, asegurando que solo aquellos con credenciales válidas puedan acceder a su cuenta.
  - **Caso de Uso 1: Inicio de sesión exitoso con MFA**: Un usuario con credenciales correctas y un código MFA válido debe poder iniciar sesión exitosamente.
  - **Caso de Uso 2: Fallo en la autenticación por credenciales incorrectas**: Si un usuario proporciona credenciales incorrectas o un código MFA inválido, el acceso debe ser denegado.

- **AuthService.cs**: Valida la correcta generación de códigos de autenticación.
  - **Caso de Uso 3: Generación de códigos dinámicos**: El sistema debe generar códigos únicos para cada intento de autenticación.
  - **Caso de Uso 4: Expiración de códigos MFA**: Un código generado debe expirar después de cierto tiempo, evitando su reutilización.