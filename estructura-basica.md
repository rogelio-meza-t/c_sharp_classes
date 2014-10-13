[&laquo; Indice](README.md)
## Estructura Básica

C# es un lenguaje orientado a objetos, en donde básicamente hay interacción entre clases, que pueden ser del mismo tipo o pueden estar dentro del mismo contexto.

Teniendo en cuenta el siguiente ejemplo

```csharp
using System;
/*
	clase que permite calcular area y perimetro de un circulo
*/
using System;
namespace Poligonos{
    class Circulo{
        double radio;
        
        public double CalcularArea(){
        	//retorna el área del circulo
            return Math.PI * Math.Pow(radio, 2);
        }
        
        public double CalcularPerimetro(){
            return 2*Math.PI*radio;
        }
        
        public void SetValoresDefecto(){
            radio = 1.5;
        }
        
        public void SetValores(double radio){
            this.radio = radio;
        }
    }    
}
```
*Código* [circulo.cs](../master/session_01/circulo.cs)

Se puede ver que hay varios elementos en común con otros lenguajes de programacion orientados a objetos, lo que se puede observar en el código anterior es lo siguiente:

### Using
La palabra reservada *using* se utilizar para incluir *namespaces* dentro de un programa. Se puede usar multiples veces dentro de un programa como también no usarla. El ejemplo anterior utiliza `using System`, lo cual está indicando al programa que incluya las clases del namespace `System`

### Namespace
El *namespace* se utiliza para agrupar clases dentro de un mismo contexto. En el ejemplo, se está haciendo referencia que la clase `Circulo` está dentro del *namespace* `Poligonos`, por lo cual eventualmente podrían haber otras clases dentro del mismo namespace.

### Class
Es la palabra reservada para declarar las clases, sólo se puede declarar una clase por vez dentro de la misma instruccion.

### Comentarios
Los comentarios en C# no son distintos a la mayoría de los lenguajes. El compilador ignora los comentarios y no son incluidos en la compilación, por lo que su unica función es informativa. Existen dos tipos de comentarios:
* **Multilinea** se empieza con `/*` y termina con `*/`. Se puede usar saltos de linea sin necesidad de encerrar el comentario de nuevo, por ejemplo:
```
/*hola,
soy un comentario
chao!
*/
```
* **Una linea** Se empieza con los caracteres `//` y todo lo que esté en esa linea será un comentario, por lo cual si se requiere escribir otra línea de comentario, se debe escribir el doble slash de nuevo, por ejemplo:
```
// hola, soy un comentario
// y ahora estoy en un línea nueva
```

### Atributos
Son usados para guardar datos de la clase. Pueden ser sólo de un tipo que no cambia con el tiempo. En el ejemplo anterior la clase `Circulo` tiene un atributo *radio* de tipo `double` que se mantendrá inalterable, no así su valor que puede ir cambiando.

### Métodos
Son funciones que pertenecen a la clase y se declaran e implementan dentro de la misma. En el ejemplo anterior, `CalcularArea` es un método de la clase `Circulo`

## Actividad
En el directorio [session_01](../master/session_01/) hay un ejemplo de como un programa interactúa con varias clases. Siguiendo el ejemplo 1, están las clases *Circulo*, *Rectangulo* y *Triangulo* que implementan métodos para calcular área y perímetro. en el archivo `main.cs` está la clase que inicia el programa.

Para compilar hay que ejecutar el siguiente comando:

```
mcs circulo.cs rectangulo.cs triangulo.cs main.cs -out:poligonos
```

y el siguiente para ejecutar el programa

```
mono poligonos
```