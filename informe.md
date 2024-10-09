1. Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color). Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.  
Se ha utilizado un int público para que se pueda modificar el númnero de frames desde el editor.  
![Ejercicio 1](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej1.gif)  
***
2. Crea una escena simple en la que ubiques un plano y sobre él un cubo, una esfera y un cilindro. Cada uno de los objetos debe estar en un color diferente. En la consola cada objeto debe mostrar su nombre.  
![Ejercicio 2](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej2.gif)  
***
3. Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:
La magnitud de cada uno de ellos. 
El ángulo que forman
La distancia entre ambos.
Un mensaje indicando qué vector está a una altura mayor.
Muestra en el inspector cada uno de esos valores.  
Se han utilizado las funciones Angle y Distance para los dos primeros y para lo último se han comparado las y.  
![Ejercicio 3](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej3.gif)
***
4. Muestra en pantalla el vector con la posición de la esfera.  
He utilizado la función OnGUI añadiendo una etiqueta (label) que tiene un rectángulo con la información de la posición.  
![Ejercicio 4](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej4.gif)  
***
5. Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.  
Para esto se ha utilizado la función Distance de Vector3 y para encontrar cada objeto se ha usado el método Find.  
![Ejercicio 5](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej5.gif)  
***
6. Selecciona tres posiciones en tu escena a través de un objeto invisible (marcador) que incluya 3 vectores numéricos para configurar posiciones en las que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora. Estos vectores representan un desplazamiento respecto a la posición original del objeto. Crea un script que ubique en las posiciones configuradas cuando el usuario pulse la barra espaciadora.  
Se ha utiliza el método Find para obtener cada uno de los objetos y la función GetAxis para obtener si un usario ha pulsado la tecla espacio. Además, se han puesto 3 Vector3 públicos para que puedan ser editados desde el inspector.  
![Ejercicio 6](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej6.gif)  
***
7. Cambia el color del cilindro cuando el usuario pulse la tecla C, cambia el color del cubo cuando el usuario pulse la flecha arriba.  
Para obtener cuando se han pulsado las teclas he usado GetKeyDown y para recuperar el Renderer he usado GetComponent<Renderer>().  
![Ejercicio 7](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej7.gif)  
***
8. Agrega 5 esferas más en la escena. Crea un grupo de 2 , asígnales la misma etiqueta para indicar esferas de tipo 1 y a las restantes otra etiqueta diferente a ésta para indicar esferas de grupo 2. En la escena también habrá un cubo. Implementa un script que aumente la altura de la esfera de tipo 2 más cercana al cubo. Cambia el color de la más lejana cuando el jugador pulsa la tecla espacio.  
Para este ejercicio he creado una escena nueva con 5 esferas y un cubo, para su mejor visualización le he asignado un color a las esferas de tipo 1 y otro color para las de tipo 2. En el Start calculo mediante un for la esfera con menor y mayor distancia al cubo para, posteriormente, cambiarle la posción a la más cercana y esperar a que se pulse el espacio para cambiarle el color a la más lejana (ambas de tipo 2).  
![Ejercicio 8](https://github.com/AdrianMoraRodriguez/p02_II_Adrian_Mora_rodriguez/blob/main/Multimedia/ej8.gif)