# Programación II - Trabajos Prácticos

Este repositorio reúne la evolución de un sistema orientado a objetos para gestionar un catálogo de contenido audiovisual. La decisión de dominio elegida fue mantener una lógica centrada en películas y series, con actores asociados a las producciones, porque permite aplicar de forma natural los conceptos de clases, objetos, encapsulamiento, relaciones, herencia y polimorfismo a lo largo de los distintos trabajos prácticos.

## Objetivo del proyecto

El objetivo es ir construyendo, paso a paso, un modelo de dominio realista y ordenado:

- TP1: representar entidades del dominio mediante clases y objetos.
- TP2: encapsular datos, validar estados inválidos y relacionar clases.
- TP3: modelar una jerarquía real con herencia y demostrar polimorfismo.

La idea es que el mismo dominio se retome y evolucione, en lugar de empezar desde cero cada vez.

---

## Dominio elegido

Se trabajó con el concepto de contenido audiovisual, centrado principalmente en:

- Película
- Serie
- Actor
- Contenido audiovisual como concepto general

Esta elección permitió mantener una lógica coherente para todas las consignas: una película tiene un actor principal y una serie comparte la misma idea de ser un tipo de contenido que puede mostrarse de forma uniforme dentro del sistema.

---

## Estructura del repositorio

- TP1-ClasesObjetos/
  - Program.cs
  - Define la clase Pelicula y crea tres instancias con distintos valores.

- TP2-Encapsulamiento/
  - Actor.cs
  - Pelicula.cs
  - Program.cs
  - Se encapsulan los atributos, se valida información y se trabaja con una colección de películas.

- TP3-HerenciaPolimorfismo/
  - ContenidoAudioVisual.cs
  - Pelicula.cs
  - Serie.cs
  - Actor.cs
  - Program.cs
  - Se crea una jerarquía de herencia con contenido audiovisual como clase base abstracta.

---

## TP1 - Clases y objetos

### Decisión de diseño

Se eligió la clase Pelicula como punto de partida del dominio. Esto permitió introducir los conceptos básicos de POO sin complicar el modelo con demasiadas abstracciones.

### Atributos principales

La clase Pelicula incluye atributos como:

- Titulo
- Director
- Anio
- Duracion
- Puntaje

### Métodos relevantes

Se implementaron métodos que hacen más que devolver un dato:

- CalcularDuracionEnHoras()
- ObtenerPuntaje()
- MostrarInformacion()

Estos métodos transforman o interpretan los datos del objeto para producir información útil en consola.

### Ejemplo de uso

En TP1 se instancian tres objetos con datos distintos y se muestran sus resultados por pantalla. La idea es que cada objeto tenga un estado propio e independiente, aunque pertenezcan a la misma clase.

---

## TP2 - Encapsulamiento, relaciones y colecciones

### Encapsulamiento

La clase Pelicula se reestructura con atributos privados y propiedades con validación. Eso evita que se creen estados inválidos como:

- un título vacío
- una duración negativa o absurda
- un año fuera de rango

Además, la clase Actor se modela con validación del nombre para que no pueda quedar en blanco.

### Relación entre clases

La relación elegida es de asociación o agregación, según el caso de uso:

- una Pelicula tiene un Actor principal
- un Actor puede ser parte del contexto de varias películas

Esto representa una relación entre dos clases distinta a una herencia. No es una relación "es un", sino "tiene un".

### Enumeración

Se incorporó una enum llamada Genero para representdar categorías cerradas, como:

- Accion
- Comedia
- Drama
- Terror
- CienciaFiccion
- Romance

Esto evita que se carguen valores arbitrarios a mano.

### Colección

El programa usa una List<Pelicula> para almacenar múltiples objetos de la misma clase y recorrerlos sin depender de un único caso de prueba.

### Resultado del TP2

El sistema ya no solo crea un objeto aislado, sino que puede mantener varios registros, validar sus valores y representarlos en conjunto.

---

## TP3 - Herencia, abstracción y polimorfismo

### Jerarquía de clases

Se define la clase abstracta ContenidoAudiovisual como base común para todo contenido que pueda ser listado o mostrado de forma uniforme.

Las clases derivadas son:

- Pelicula : ContenidoAudiovisual
- Serie : ContenidoAudiovisual

### ¿Por qué es herencia real?

Porque ambas clases son variantes del mismo concepto general: un contenido audiovisual. La relación es genuina de tipo "es un":

- una Pelicula es un ContenidoAudiovisual
- una Serie es un ContenidoAudiovisual

No se fuerza una jerarquía cuando la relación en realidad es de composición o asociación; aquí sí existe una especialización válida.

### Método abstracto y polimorfismo

La clase base define un método abstracto:

- MostrarInformacion()

Cada clase hija implementa ese comportamiento de manera distinta:

- Pelicula muestra director, género, duración y puntaje.
- Serie muestra temporadas y año de estreno.

Luego se guarda todo en una List<ContenidoAudiovisual> y se recorre sin preguntar de qué tipo concreto es cada elemento. Eso demuestra polimorfismo.

### Manejo de excepciones

Se incorpora una validación de negocio en la clase Serie:

- una serie debe tener al menos 1 temporada

Si se intenta crear una serie con 0 o menos temporadas, se lanza una ArgumentException con un mensaje claro. Esto protege una regla del dominio y evita que el sistema quede en un estado inconsistente.

---

## Cómo ejecutar cada proyecto

Cada trabajo práctico es un proyecto independiente de .NET .NET y puede ejecutarse desde su carpeta correspondiente:

```bash
cd TP1-ClasesObjetos
dotnet run
```

```bash
cd TP2-Encapsulamiento
dotnet run
```

```bash
cd TP3-HerenciaPolimorfismo
dotnet run
```

## Archivos clave

- TP1-ClasesObjetos/Program.cs — introducción a clases y objetos.
- TP2-Encapsulamiento/Actor.cs — validación de un actor.
- TP2-Encapsulamiento/Pelicula.cs — encapsulamiento y enum de género.
- TP2-Encapsulamiento/Program.cs — manejo de colección de películas.
- TP3-HerenciaPolimorfismo/ContenidoAudioVisual.cs — base abstracta.
- TP3-HerenciaPolimorfismo/Pelicula.cs — clase derivada especializada.
- TP3-HerenciaPolimorfismo/Serie.cs — segunda clase derivada y validación de negocio.
- TP3-HerenciaPolimorfismo/Program.cs — recorrido polimórfico del catálogo.
