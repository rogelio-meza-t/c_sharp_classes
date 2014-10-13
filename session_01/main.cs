using System;

namespace Poligonos{
    class MainClass{
        public static void Main(){
            Rectangulo r = new Rectangulo();
            r.SetValoresDefecto();
            
            Console.WriteLine("Area Defecto Rectangulo: " + r.CalcularArea());
            
            r.SetValores(2,1);
            Console.WriteLine("Area Seteada Rectangulo: "+r.CalcularArea());
            
            Console.WriteLine();
            
            Circulo c = new Circulo();
            c.SetValoresDefecto();
            Console.WriteLine("Area Defecto Circulo: " + c.CalcularArea());
            
            c.SetValores(2);
            Console.WriteLine("Area Seteada Circulo: "+c.CalcularArea());
            
            Console.WriteLine();
            
            Triangulo t = new Triangulo();
            t.SetValoresDefecto();
            Console.WriteLine("Area Defecto Triangulo: " + t.CalcularArea());
            
            t.SetValores(2);
            Console.WriteLine("Area Seteada Triangulo: "+t.CalcularArea());
            
        }
    }
}
