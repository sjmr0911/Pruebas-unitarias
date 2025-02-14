import sys
import os
import pytest

sys.path.insert(0, os.path.abspath(os.path.join(os.path.dirname(__file__), '..')))
# Clases a probar
from pedidos_en_linea.inventario import Inventario
from inventario import Inventario
from compra import Compra
from pedidos_en_linea.compra import Compra

## Verificar si la compra fue exitosa
def test_efectivo_compra():
    inventario = Inventario()
    inventario.agregar_producto("Laptop", 10)
    
    purchase = Compra(inventario)
    assert purchase.adquirir("Laptop", 2) == True
    assert inventario.conseguir_stock("Laptop") == 8

## Verificar si en la compra hay insuficientes productos en stock
def test_compra_insufficiente_stock():
    inventario = Inventario()  
    inventario.agregar_producto("Laptop", 1)

    purchase = Compra(inventario)
    assert purchase.realizar_compra("Laptop", 2) == False



#- **test_purchase.py**: Garantiza que las compras se registren correctamente.
#  - **1era parte: Descuento de stock tras compra exitosa**: Cuando un usuario finaliza una compra, el stock del producto debe disminuir en la cantidad correspondiente.
#  - **2da parte: Prevención de compras sin stock**: Si un producto no tiene disponibilidad, el sistema debe evitar que la compra se complete.
