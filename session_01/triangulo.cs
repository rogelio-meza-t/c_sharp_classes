using System;

namespace Poligonos{
    class Triangulo{
        double largo;
        
        public double CalcularArea(){
            return (Math.Sqrt(3) / 4 ) * Math.Pow(largo, 2);
        }
        
        public double CalcularPerimetro(){
            return 3*largo;
        }
        
        public void SetValoresDefecto(){
            largo = 3.1;
        }
        
        public void SetValores(double largo){
            this.largo = largo;
        }
    }
}
