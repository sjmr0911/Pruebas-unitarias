class Compra:
    def __init__(self, inventario):
        self.inventario = inventario
        self.carrito = {}

# Método para agregar productos al carrito
    def agregar_al_carrito(self, nombre, cantidad):
        stock_disponible = self.inventario.obtener_stock(nombre)
        # Si la cantidad solicitada es menor o igual al stock disponible
        if cantidad <= stock_disponible:
            self.carrito[nombre] = self.carrito.get(nombre, 0) + cantidad
            return True
        return False
# Realizar una compra, reservando en stock
    def realizar_compra(self, nombre, cantidad):
        if self.inventario.reserva_stock(nombre, cantidad):
            return True
        return False

# Método para adquirie productos y reservarlos
    def adquirir(self, producto, cantidad):
        if self.inventario.conseguir_stock(producto) >= cantidad:
            self.inventario.reserva_stock(producto, cantidad)
            return True
        return False

