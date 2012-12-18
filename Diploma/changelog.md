[30/10/2010]

	* cambio en logica de venta (se agrega tarjeta/emisor)
	* Se agregaron validaciones por regex (mail, cuit, tels)
	* Se solucionÃ³ bug en baja de prod.

[31/10/2012]

	* Se actualiza especificacion de Locaciones (faltan Diagramas de secuencia)	

[2/11/2012]
	
	* Se actualiza la especificación de Eventos
	* Se agregó confirmación de baja de Evento
	* Se agregó formulario que muestra mails de clientes en cancelación de evento.

	* TODO: Eventos deberia tener DVH

	* Se actualiza especificación de Clientes (Se saca DV)
	* Se agregó confirmación de baja de Cliente

	* Se actualiza especificación de Productores (DV lo saco ?)
	* Se actualiza la bitacora de Cliente y Productor, al crear o modificar guardaba en la bitacora  encriptado.

	* TODO: Ver especificacion de gestión de cuenta corriente

	* TODO: (DONE) Si hay una sola promoción con el medio de pago (tar/emisor) se selecciona automaticamente. Si es más de una disponible, el usuario la selecciona (PERO SIEMPRE DEBE SELECCIONAR UNA). ESTO DEBE QUEDAR REGISTRADO EN LA BITACORA

[6/11/2012]

	* se actualiza especificacion de promociones (sacar DVH? )

[9/11/2012]

	* se modifica la espcificación de la bitácora, se agrega la posibilidad de filtrar por fecha en la bitácora.
	* ventas -> se filtra por la fecha para solo vender eventos a realizarse en el día de hoy o futuro
	* TODO (DONE): ver que al cargar un evento la cantidad en el stock le suma uno a la cantidad de entradas.
	* Se generó el form de stock, verificar la forma que muestra los datos.

[12/11/2012]

	* Se probó correr en otra pc, se solucionó el problema de que si no había conexión a la db pinchaba al cerrar la ventana principal

	* Se modifica la descripción de los DV
	* TODO: revisar especificaciones...(dígitos verificadores)
	* Se modifica especificaciones y diagramas de Acceso / encriptación / Backup
 

	
[19/11/2012]
	
	* especificaciones de RBAC 
	* [TODO] no permitir referencias circulares en alta / mod
	* Complete FamiliaDAL / Familia /BEFamilia / permisos( en las 3 capas)
	* verifique las clases tag / idioma en las 3 capas


[20/11/2012]
	
	* actualice especificaciones de multiidioma / rbac (finalizadas)
	* 

----------------
Comienzo con segunda revisión (negocio)
[21/11/2012]
Locación	OK (saque campos extras y modifiqué SPs)
Evento OK (verifiqué SD/UC le saque el DV)
Cliente OK (verifiqué SD/UC le saque el DV)

Productores OK
[22/11/2012]
ventas especificación ok
reportes OK
Stock OK

