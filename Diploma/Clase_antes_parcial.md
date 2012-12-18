patrones de creacion
patrones de comportamiento (basados en polimorfismo)

---
Ejercicio:

Una empresa que hace pedido de ventas, estos pedidos dependiendo el monto que tengan los puede autorizar diferentes personas en la empresa


pedido valor <= 100 aprueba la secretaria
pedido valor > 101 <= 1000 aprueba el jefe de pedidos
pedido valor > 1001 <= 30000 aprueba el subgerente
pedido valor > 30000 aprueba el gerente

Se quiere realizar un sistema que sea muy flexible , en donde se pone el monto del pedido y me dice quien lo aprueba (y lo apruebe)
[me permita saber quien es el que lo tiene que aprobar]
en el caso de que sea la secretaria, la secretaria aprueba siempre (avisar que esta pre-aprobado)

---
Ejercicio 2

Una empresa se dedica a procesar acciones, las cuales tienen una sigla, un nombre y un valor de cotización.
existen muchas otras empresas que dependen de esta empresa para conocer el valor de las acciones que procesa y publica

se necesita un sistema que permita notificarle a cada una de las empresas que se suscriben a su servicio cuando las cotizacion de una
accion cambio

Las empresas que se suscriben pueden decidir si se suscriben solo a algunas acciones (lista de acciones de interes) o si se suscriben a todas
(la lista de acciones de interes vacia)

Emular el sistema a traves de 1 formulario de win con el maestro de acciones y 2 formularios de win que emulen 2 suscriptores.

