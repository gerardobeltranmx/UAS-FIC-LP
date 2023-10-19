
using System;
class Principal {
  static void Main() {
   
    Cilindro obj;

    obj = new Cilindro();

    obj.CambiarRadio(10);
    obj.CambiarAltura(20);

    Console.WriteLine(obj.ObtenerVolumen());

  }
}

class Circulo{

        private double radio;

        public void CambiarRadio(double r){
              radio=r;
        }
        public double ObtenerRadio(){
                return radio;
        }
        public double ObtenerArea(){
          return  3.1416*radio*radio;
        }
        public double ObtenerPerimetro(){
          return  3.1416*2*radio;
        }
}

class Cilindro:Circulo{

       private double altura;
                   
       public void CambiarAltura(double h){
              altura=h;
        }

      public double ObtenerAltura(){
          return altura;
      }

      public double ObtenerVolumen(){
           return ObtenerArea()*ObtenerAltura();
      }
}
    