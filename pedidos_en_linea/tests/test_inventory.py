import sys
import os
import pytest

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))
# Importamos las clases a probar
from pedidos_en_linea.compra import Compra 
from pedidos_en_linea.inventario import Inventario

## Verificar si las reservas en stock de los pedidos
def test_reserva_stock():
    inventario = Inventario()
    inventario.agregar_producto("Laptop", 10)
    
    #Verificar si la reserva de laptop es la adecuada y cuantas quedan disponibles
    assert inventario.reserva_stock("Laptop", 1) == True
    assert inventario.conseguir_stock("Laptop") == 9

## Verificar si las reservas en stock falle o hay insuficientes equipos en el inventario
def test_reserva_stock_insufficiente():
    inventario = Inventario()
    inventario.agregar_producto("Laptop", 1)

    assert inventario.reserva_stock("Laptop", 2) == False


### **Comercio electronico en Linea (Python - pytest)**
## - test_inventory.py**: Evalúa la gestión de inventario y la reserva de productos.
## - **1era parte: Reserva exitosa de stock**: Un usuario que compra un producto con suficiente stock disponible debe poder reservarlo exitosamente.
## - **2da parte: Reserva fallida por falta de stock**: Si un usuario intenta reservar más unidades de las disponibles, la operación debe fallar y el stock permanecer inalterado.