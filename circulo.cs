using System;

namespace Poligonos{
    class Circulo{
        double radio;
        
        public double CalcularArea(){
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
