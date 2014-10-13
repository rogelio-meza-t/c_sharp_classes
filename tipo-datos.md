[&laquo; Indice](README.md)
## Tipos de datos

C# es de tipado estático, esto quiere decir que las variables deben ser declaradas antes de ser usadas. También, esto quiere decir que cada variable debe llevar consigo un tipo de dato que almacenará.

Los tipos de datos que soporta C# se consideran por valor y referencia. Los tipos por valor son los que almacenan directamente un valor, mientras que los tipos por referencia almacenan la dirección de memoria de un valor.

Los tipos de datos por valor soportados por C# son:

|Tipo	|Tamaño		|Valores	|
|-------|-----------|-----------|
|sbyte	|8 bit		|	-128 a 127|
|byte	|8 bit		|	0 a 255|
|short	|16 bit		|	-32,768 a 32,767|
|ushort	|16 bit		|	0 a 65,535|
|int	|32 bit		|	-2,147,483,648 a 2,147,483,647|
|uint	|32 bit		|	0 a 4,294,967,295|
|long	|64 bit		|	-9,223,372,036,854,775,808 a 9,223,372,036,854,775,807|
|ulong	|64 bit		|	0 a 18,446,744,073,709,551,615|
|char	|16 bit		|	0 a 65535|
|float	|32 bit		|	-1.5 x 1045 a 3.4 x 1038|
|double	|64 bit		|	-5 x 10324 a 1.7 x 10308|
|decimal|128 bit	|	-1028 a 7.9 x 1028|
|bool	|---		|	true o false|

Al usar una variable se puede declarar y asignarle un valor en la misma línea o bien declarar la variable y mas adelante asignarle un valor. Veamos algunos casos.

```csharp
using System;
namespace DataTypes
{
	class DataExample
	{
		public static void Main()
		{
			int entero; 				//variable de tipo entero, sólo se declara.

			double con_decimal = 0.1; 	//se declara y asigna un valor en la misma línea
			double otro_decimal = 1D	//otra forma de declarar un double

			float un_float = 0.1;		//tipo float
			float otro_float = 2F		//también se puede declara de esta forma

			bool booleano = true;		//las opciones son true o false

			entero = 1;					//asigna un valor a una variable antes declarada
		}
	}	
}
```

Los datos por referencia, como se explicó antes son aquellos que almacenan la dirección de memoria de un valor. Los más comunes son *object*, *dynamic* y *string*.

El tipo `object` es un alias de `System.Object`. A este tipo de variables se les puede asignar cualquier tipo de valor, por lo tanto se puede convertir una dato por valor a tipo *object*, procedimiento que se conoce como **boxing** o viceversa, procedimiento que se conoce como **unboxing**. El *unboxing* de un *object* no puede ser directo, sino que necesita convertirse antes de asignarse.

```csharp
double radio = 12.3;

object objeto = radio;		//ejemplo de boxing
radio = (double) objeto;	//ejemplo de unboxing
```

Los datos de tipo `string` en tanto almacenan cadenas de caracteres. Para declarar una variable se puede usar `string` o `String` ya que el primero es un alias del segundo. Las variables de tipo `string` pueden ser asignadas usando literales, de dos formas: entre commillas y con el caracter `@`. La diferencia de usar el segundo método para asignar string es que los caracteres hexadecimal, Unicode o precedidos con `\` no serán procesados.

```csharp
string hola_1 = "Hola \t Mundo"; 		//asigna: Hola    Mundo
string hola_2 = @"Hola \t Mundo";		//asigna: Hola \t Mundo
```