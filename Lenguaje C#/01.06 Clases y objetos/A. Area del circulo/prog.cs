
using System;
class Principal {
  static void Main() {
   


   
  }

  class Circulo(){
      private int radio ;

      int ObtenerRadio(){
          return radio;
      }

      void CambiarRadio(int radio){
        this.radio = radio;
      }

      float ObtenerArea(){
        float area;
        area = 3.14159 * radio * radio; 
        return area;
      }

  }

}