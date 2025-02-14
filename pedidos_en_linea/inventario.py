class Inventario:
    def __init__(self):
        self.stock = {}

# Metodo para agregar productos al inventario
    def agregar_producto(self, nombre, cantidad):
        self.stock[nombre] = self.stock.get(nombre, 0) + cantidad

# Metodo para reservar stock, descontando las unidades si hay suficiente
    def reserva_stock(self, nombre, cantidad):
        if self.stock.get(nombre, 0) >= cantidad:
            self.stock[nombre] -= cantidad
            return True
        return False

## Metodo para ver la cantidad de producto disponibles
    def conseguir_stock(self, nombre):
        return self.stock.get(nombre, 0)
