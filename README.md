## Propósito de las Pruebas Unitarias

### **Banco (C# - xUnit)**
- **AuthenticationTests.cs**: Estas pruebas validan la autenticación multifactor del usuario, asegurando que solo aquellos con credenciales válidas puedan acceder a su cuenta.
  - **1era parte: Inicio de sesión exitoso con MFA**: Un usuario con credenciales correctas y un código MFA válido debe poder iniciar sesión exitosamente.
  - **2da parte: Fallo en la autenticación por credenciales incorrectas**: Si un usuario proporciona credenciales incorrectas o un código MFA inválido, el acceso debe ser denegado.

- **CodeGenerationTests.cs**: Valida la correcta generación de códigos de autenticación.
  - **1era parte: Generación de códigos dinámicos**: El sistema debe generar códigos únicos para cada intento de autenticación.
  - **2da parte: Expiración de códigos MFA**: Un código generado debe expirar después de cierto tiempo, evitando su reutilización.

### **E-commerce (Python - pytest)**
- **test_inventory.py**: Evalúa la gestión de inventario y la reserva de productos.
  - **1eraparte: Reserva exitosa de stock**: Un usuario que compra un producto con suficiente stock disponible debe poder reservarlo exitosamente.
  - **2da parte: Reserva fallida por falta de stock**: Si un usuario intenta reservar más unidades de las disponibles, la operación debe fallar y el stock permanecer inalterado.

- **test_purchase.py**: Garantiza que las compras se registren correctamente.
  - **1era parte: Descuento de stock tras compra exitosa**: Cuando un usuario finaliza una compra, el stock del producto debe disminuir en la cantidad correspondiente.
  - **2da parte: Prevención de compras sin stock**: Si un producto no tiene disponibilidad, el sistema debe evitar que la compra se complete.
