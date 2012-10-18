Fecha: 17/10/2012

Tema: Acceso a datos ADO

+ ADO.NET esta integrado al framework .NET

+	System.Data.SqlClient
		-	SqlConnection -> representa una conexión abierta de sql
		-	SqlCommand ->	representa una sentencia o sp sql
		- SqlDataReader -> representa los resultados de las consultas

---
Si tuvieramos que trabajar con otro tipo de base de datos, el namespace seria:
	- System.<data db> : -> 
													 * OleDBConnection
													 * OleDBCommand
													 * OleDBReader

---

EJ2:

	Recuperar un valor global
	4 funciones globales :
		count()
		max()
		avg()
		min()

En el ejercicio anterior usamos el datareader para representar los resultados de una consulta. 
Pero si solo debieramos recuperar el valor de una consulta el método ExecuteScalar()

---
EJ3:
	Hay dos controles textbox
	En el de arriba escribimos la sentencia sql y picamos en el boton executequery
	los resultados se deben ver en el formulario inferior
	
	Lo importante es hacer funcionar la prop. fieldcount del datareader.
	el mismo nos devuelve el nro de columnas representados por el datareader

	el bucle while ... end while itera todas las filas del reader
	tambien usa un bucle for .... next para hacer un bucle a traves de las columnas
	Añade el valor de cada columna de cada fila en un control textbox -> prop textmode ... multiline


---
EJ 4:
	Dado el apellido obtener que asignación dicta

---

EJ 5 :
actualizar la asignatura del profesor


---
ej:

	conex = .............
	strDelete = "delete profesor where apellido = @apellido"
	cmdDelete = new sqlcommand(strDelete,conex)
	cmdDelete.Parameters.Add("@apellido",txtApellido.text)
	conex.open()
	intDeleteCount = cmdDelete.ExecuteNonQuery()

---------------------------

	strInsert = "insert into Profesor (Apellido) values (@apellido)"
	cmdInsert = new SqlCommand(strInsert,conex)
	cmdInsert.Parameters.add("@apellido",txtApellido.text)



---

FECHAS

	24/10
	31/10

	7/11 Segndo parcial
	14/11 Recuperatorio del 1ro
	21/11 Recuperatorio del 2do
	28/11 entrega del tp (ws y xml)


----


+ TP

	autenticacion

	autorizacion
---
	digito verificador

		backup

		desloguearse

		modificar 1 o 2 tablas

		(me logueo como webmaster tiene que informar registro corruptos)

		restore

---
	compra trivial
	
		producto y precio final tiene que dar bien

	webservice orientado al cliente, una función que este asociada al negocio
	





