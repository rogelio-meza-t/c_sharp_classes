//namespace sirve para agrupar clases que están dentro del mismo contexto
namespace Poligonos{
    /*
     Este es un comentario
    */
    //comentario

    //se define una clase con la plabra reservada "class"
    class Rectangulo{

        //seteamos los atributos del objeto
        double largo;
        double ancho;
        
        //definimos un método que retorna el área del rectandulo
        public double CalcularArea(){
            return largo * ancho;
        }
        
        //definimos el método que retorna en perímetro del rectangulo.
        public double CalcularPerimetro(){
            //return 2*largo + 2*ancho;
            return 2*(largo + ancho);
        }
        
        public void SetValoresDefecto(){
            largo = 2.1;
            ancho = 1.3;
        }
        
        public void SetValores(double largo, double ancho){
            this.largo = largo;
            this.ancho = ancho;
        }
    }
}
