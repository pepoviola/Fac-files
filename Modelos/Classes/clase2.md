# Modelos

## Clase 2

### Fecha: 22/8/2012


#### Temas:

+ Confiabilidad
+ Integridad
+ Disponibilidad





---

+ medidas de seguridad de caracter técnico
	identificacion y autenticación de los usuarios
	control de acceso
	control de flujo de la informacion
	confidencialidad
	integridad
	no repudio
	notorización: ofrecen confiabilidad mediante la certificación de la asociación entre individuos y claves públicas de cifrado
	auditoria

---

+ Mecanismos de protección
	autenticación
	control de accesos
	cifrado de datos
	funciones resumen :  garantiza la integridad de los datos
	firma digital :	garantiza el no repudio
	registro de auditoria : proporciona medidas de auditoria


---

+ Modelos de seguridad
	MAC : Mandatory Access Control
	DAC : Discretionary Access Control

	Control de acceso basado en roles RBAC, Role Based Access Control : Usa el concepto de rol para agrupar un conjunto de permisos
									    y un conjunto de usuarios  autorizados a ejercer dichos permisos.




	 El modelo de acceso MARAH (Modelo de acceso basado en roles para las aplicaciones hipermedias) tiene como principal característica que trabaja con conceptos del dominio de hipermedia, lo que permite a los diseñadores modelar el acceso al sistema al mismo tiempo que modelan al sistema en si. ESTA BASADO EN LA FILOSOFIA RBAC.

	Hipermedia, es crear metodologías de diseño orientado a objetos (OOHDM) 

---

+ Calidad en el desarrollo web

	madelo de calidad de Mc Call:
		Funcionalidad
		Fiabilidad
		Usabilidad
		Eficiencia
		Mantenibilidad
		Portabilidad
	

+ Calidad INterna: Se mide por las propiedades estáticas del código usando técnicas de inspección
+ Calidad Externa : Se mide por las propiedades dinámicas del código cuando ésta se ejecuta
+ Calidad en uso: se mide por el grado por el cual el software esta realizado en función de las necesidades del usuario en el entorno de trabajo para el que fue construido

---

+ Calidad en la web: Se basa en los fundamentos anteriores. Uno de los factores más importantes a la hora de la calidad web es la usabilidad.
		     ISO 9126-1 [15] define la usabilidad como la capacidad de un producto software de ser comprendido, aprendido, usado y ser atractivo para el usuario en condiciones especificas de uso.

---

+  la usabilidad es una cualidad abstracta por eso para poderla estudiar se la divide (Nielsen) en 5 atributos:
	Facilidad de aprendizaje
	Eficiencia
	Recuerdo en el tiempos
	Tasa de errores
	Satisfacción

---

+ 

[ preguntas parcial

	que es la refactorización
	cuales son los los beneficios y problemas
	que es la trazabilidad
	Describa una métrica de MOOSE (complejidad en el diseño OO)
	Describa una métrica de Brito e Abreu
	como es el modelo RBAC
	como es el modelo de Mc Call
	como es el modelo WQM
	Explique la diferencia entre accesibilidad y usabilidad

]


---

+ Metricas de calidad de uso

	Efectividad:
		Efectividad de tarea
		completitud de la tarea
		frecuencia de error

	Productividad:
		tiempo en llevar a cabo la tarea
		eficiencia de la tarea
		proporcion del tiempo productivo

	Seguridad:
		seguridad y salud del usuario
		seguridad de la gente afectada por el uso del sistema
		daños economicos

	satisfacción:
		escala de satisfacción
		cuestionario de satisfacción
		aceptación del producto

[PARA EL PARCIAL HAY QUE ELEGIR UNA DE CADA UNA DE LAS CATEGORIAS Y EXPLICARLA, SOLO UNA!!]


---

+ Accesibilidad

	Esta relacionado con las discapacidades que pueden ser:
		Visuales
		Auditivas
		Físicas
		Del habla: falta del habla
		Cognitivas: dislexia, problemas de memoria, déficit de atención
		Limitaciones físicas, sensoriales ó cognitivas ocacionadas por el envejecimiento

---

+ Que condiciones debe reunir
	Que propiedad es la que se quiere medir (coheción , acoplamiento, herencia ??)
	A que nivel se la quiere medir (variable, método, clase, sistema ??)
	En que etapa del ciclo de vida se hace la mediación (análisis, diseño, implementación, prueba)

---

+ Como se pueden clasificar las metricas?
	una forma es teniendo en cuenta las 4 dimensiones anteriores (metodo, clase, programa, sistema) y a esta clasificacion la llamamos "Segun nivel de granularidad"

	otra forma de clasificación es segun la etapa involucrada dentro del ciclo de vida

	y tamien segun el atributo (O.O) a medir tal como acoplamiento, complejidad de una clase, reutilización , coheción  y herencia.

	Por ejemplo AHF (Attribute hidden factor)
		Granularidad a nivel de  - clase y de sistema
		ciclo de vida		- implementación
		propiedad involucrada	- encapsulamiento



---

+ Una metrica debe ser:
	Simple
	Objetiva (todos debemos darle identico valor)
	facil de obtener 
	robusta (insensible a los cambios irrelevantes)
	valida (debe medir lo que se supone que mide)


+ Dos tipos de metricas

	Directa : para medir un atributo de una entidad solo precisan dicho atributo
	
	Indirecta : Para medir un atributo de una entidad debe combinar varias metricas directas,
		    es decir que necesitan varios atributos de una entidad para medir un atributo particular de dicha entidad


+ por ejemplo
	%enlaces_rotos = (nro_enlaces_rotos_int + nro_enlaces_rotos_ext) * 100 / nro_total_de_enlaces


---
+ Acerca de la teoría de las escalas

	cual es la mejor representación para el atributo que voy a medir???

	Nominal: No hay nocion de orden ni de magnitud. Por ejemplo la clacificación de los programas de soft según el lenguaje con el que está escrito : c++ , java, etc.

	Ratio: Admite cualquier operación aritmetica, por ej un programa es el doble de extenso que otro

	Ordinal: Clases ordenadas respecto del atributo. Por ej: usamos la complejidad de un programa respecto de otro como trivial, sencilla , moderna, muy compleja. Aquí no se puede afirmar que un prog es el doble que complejo del otro.

	Intervalo: conserva el orden y la diferencias. Admite sumas y restas pero no la multiplicación o división (ratios). Si hay 20 grados en bs. as. y 40 en la rioja y se incrementa en un grado en ambos lugares, pasara a haber 21 en bs. as. y 41 en la rioja. Pero no puedo decir que hay un 50% mas de calor en la rioja que en bs. as.

	Absoluta: El nro de fallos observados durante las pruebas de integración solo pude medirse contando el nro de fallos observados.
		  el: si un servidor falla dos veces la medicion es 2

---

 + Metrica: Proporcion de polimorfismo

	Es la proporcion entre el numero real de posibles situaciones polimorfas para una clase Ci y el máximo número posible de situaciones polimorfas en Ci.

	Es decir, es el número de métodos heredados redefinidos, dividido entre el máximo númemro de situaciones polimorfas distintas posibles

 	[ver ecuacion en carpeta]
	
---

Metricas Sencillas

	* cantidad de nodos muertos
	* cantidad de imagenes de un sitio que referencian a la propiedad ALT [texto alternativo de la imagen]
	* cantidad de imagenes de un sitio
	* porcentaje de presencia de la propiedad ALT [(cant ALT / cant total) * 100]
	* cantidad total de páginas de un sitio
	* Mantenimiento del color en los enlaces ( rojo para el que se visito, azul para el que no se visito)
	* Cantidad máxima de frames
	* Promedio de enlaces por página [total de enlaces / total de páginas]
	* Tamaño de una página [todos sus gráficos + texto ]

---

+ DIFERENCIA ESCENCIAL ENTRE CORBA Y WEBSERVICE

	Que uno esta orientado a objetos (corba) y el otro a servicios (web service)
	transferencia de datos (soap vs tcp)
	
