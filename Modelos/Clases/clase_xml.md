Fecha: 24/10/2012

Tema: xml

Parcial 7/10
	temas:
			ado (acceso a datos)
			dispositivos moviles
			xml


---
MODELO XML.NET

{
	"System.xml": [
								{
								"xmlReader (Abstracta)": [
															{"xmlTextReader": "puede leer datos de distintas procedencias"},
															{"xmlNodeReader": ""},
															{"xmlValidatingReader":"permite validar documentos y/o fragmentos"},
															"Usos-> xmlreader para comprobar que el formato de la DTD sea correcto"
														 ]
								},
								{
								"xmlWriter (Abstracta)":[
														{"xmlTextWriter": [ 
																								{"metodos": "close, flush, WriteAttributes"},
																								{"propiedades": "WriteState"}
																								]
														}
														]
								},
								{
								"xmlNode": [
														{"xmlDocument": "Estructura un documento xml deacuerdo a DOM"},
														{"xmlDataDocument": "Permite que los datos estructurados se almacenen, recuperen y manipulen mediante un dataset re..."}
													 ]
								},
								{
								"xPathDocument": [
																	{"xslTransform": "transforma dats xml mediante hojas de estilo XSLT"},
																	{"xPathNavigator": "Proporciona los metodos requeridos para implementar consultas de xPath en cualquier almacen de datos "},
																	"Permite parsear XML, su carga completa al documento"
																	]
								}
									]

}

-------------


