[30/10/2010]

	* cambio en logica de venta (se agrega tarjeta/emisor)
	* Se agregaron validaciones por regex (mail, cuit, tels)
	* Se solucionó bug en baja de prod.

[31/10/2012]

	* Se actualiza especificacion de Locaciones (faltan Diagramas de secuencia)	

[2/11/2012]
	
	* Se actualiza la especificaci�n de Eventos
	* Se agreg� confirmaci�n de baja de Evento
	* Se agreg� formulario que muestra mails de clientes en cancelaci�n de evento.

	* TODO: Eventos deberia tener DVH

	* Se actualiza especificaci�n de Clientes (Se saca DV)
	* Se agreg� confirmaci�n de baja de Cliente

	* Se actualiza especificaci�n de Productores (DV lo saco ?)
	* Se actualiza la bitacora de Cliente y Productor, al crear o modificar guardaba en la bitacora  encriptado.

	* TODO: Ver especificacion de gesti�n de cuenta corriente

	* TODO: (DONE) Si hay una sola promoci�n con el medio de pago (tar/emisor) se selecciona automaticamente. Si es m�s de una disponible, el usuario la selecciona (PERO SIEMPRE DEBE SELECCIONAR UNA). ESTO DEBE QUEDAR REGISTRADO EN LA BITACORA

[6/11/2012]

	* se actualiza especificacion de promociones (sacar DVH? )

[9/11/2012]

	* se modifica la espcificaci�n de la bit�cora, se agrega la posibilidad de filtrar por fecha en la bit�cora.
	* ventas -> se filtra por la fecha para solo vender eventos a realizarse en el d�a de hoy o futuro
	* TODO (DONE): ver que al cargar un evento la cantidad en el stock le suma uno a la cantidad de entradas.
	* Se gener� el form de stock, verificar la forma que muestra los datos.

[12/11/2012]

	* Se prob� correr en otra pc, se solucion� el problema de que si no hab�a conexi�n a la db pinchaba al cerrar la ventana principal

	* Se modifica la descripci�n de los DV
	* TODO: revisar especificaciones...(d�gitos verificadores)
	* Se modifica especificaciones y diagramas de Acceso / encriptaci�n / Backup
 

	
[19/11/2012]
	
	* especificaciones de RBAC 
	* [TODO] no permitir referencias circulares en alta / mod
	* Complete FamiliaDAL / Familia /BEFamilia / permisos( en las 3 capas)
	* verifique las clases tag / idioma en las 3 capas


[20/11/2012]
	
	* actualice especificaciones de multiidioma / rbac (finalizadas)
	* 

----------------
Comienzo con segunda revisi�n (negocio)
[21/11/2012]
Locaci�n	OK (saque campos extras y modifiqu� SPs)
Evento OK (verifiqu� SD/UC le saque el DV)
Cliente OK (verifiqu� SD/UC le saque el DV)

Productores OK
[22/11/2012]
ventas especificaci�n ok
reportes OK
Stock OK

