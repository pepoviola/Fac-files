XML implementa a DOM a traves de XMLDocument.
Cuando un objeto XMLDocument se ha cargado en una aplicación este sera el encargado de organizar el contenido en forma de árbol. 

Mientras que XMLTextReader provee unicamente acceso al cursor XMLDocument provee acceso directo y rápido al Nodo.



1) cargamos el objeto XMLDocument a traves del XMLTextReader
2) Pedimos al dector Reader que ignore los espacios en blanco
3) Almacenamos el árbol del documento XML en una variable de session (la búsqueda se hará entre los nodos almacenados en la variable de session)
4) dejamos al cliente elegir producto y cantidad
5) buscamos ese producto en la variable de session, una vez allado cargamos su precio y mostramos el total del importe
