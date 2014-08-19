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
            
        }
    }
}
