[&laquo; Indice](README.md)
## Conocimientos Previos

C# es un lenguaje de programación orientado a objetos, en el cual todo está empaquetado en clases incluso los tipos básicos como `int` y `string` heredan desde la clase `System.Object`

### Estructura básica
Un programa básico escrito en C# consta de las siguientes partes:
* Declaracion del `namespace`
* Una `clase`
* Métodos y atributos
* Bloques de código
* Comentarios

###Hola Mundo
Un ejemplo básico de un programa escrito en C# sería

```csharp
using System;
namespace EjemploHolaMundo
{
   class HolaMundo
   {
      static void Main(string[] args)
      {
         /* este es un comentario */
         Console.WriteLine("Hola Mundo");
      }
   }
}
```

El resultado de la ejecución del programa anterior es:
```
Hola Mundo
```

Analizando el código podemos encontrar algunos elementos básicos:

* La primera línea incluye la palabra clave `using`, que es usada para incluir al namespace `System` en el programa. Por lo general un programa incluye varias de éstas líneas agregando distintos namespaces al programa.
* Lo siguiente que aparece es la declaración del `namespace`. El `namespace` es un conjunto o colección de clases. En este caso, el `namespace` *EjemploHolaMundo* contiene la clase *HolaMundo*.
* Para declarar una clase se usa la palabra reservada `class`. Una clase tiene los métodos y atributos que serán usados por el programa. Por lo general una clase puede tener mas de un método y/o atributos.
* El único método de la clase *HolaMundo* es `Main`, que es el punto de partida para todos los programas escritos en C#.
* La línea `Console.WriteLine` muestra el mensaje *Hola Mundo* en la pantalla de la terminal.

### Datos importantes
* C# es `case sensitive`, osea hace diferencias estre mayúsculas y minúsculas.
* Todas las declaraciones y expresiones terminan con un *punto y coma*.
* La ejecución de un programa siempre comienza desde el método *Main*.
* El nombre del archivo puede ser distinto al de la clase. Tienen la extension `.cs`

### Compilación y ejecución
Para compilar un programa usando mono debes usar `mcs`, algunos ejemplos básicos:

```
mcs miprograma.cs
```
> Se compilará el archivo `miprograma.cs` y generará un archivo ejecutable llamado `miprograma.exe`

```
mcs miprograma.cs miprigrama1.cs
```
> Se compilan los archivos `miprograma.cs` y `miprograma1.cs` y se generará un archivo con el nombre `miprograma1.exe`. La regla es que por defecto el nombre del archivo ejecutable será el mismo que el primer archivo que se está compilando, sin importar si ese archivo tiene o no el método *Main*.

```
mcs miprograma.cs miprigrama1.cs -out:programa.exe
```
> Se compilan los archivos `miprograma.cs` y `miprograma1.cs` y se generará un archivo con el nombre `programa.exe`. El *flag* `out` sirve para indicar el nombre del ejecutable que se generará.

Para la mayoría de los casos, para ejecutar un programa escrito en C# bastará con poner
```
mono miprograma.exe
```