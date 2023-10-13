
using System;
class Principal {
  static void Main() {
    int radio;
    double area;
    Circulo fig, llanta; // Crea el objeto circulo
   
    radio = int.Parse(Console.ReadLine());
    fig = new Circulo(); // Asigna memoria
    //fig.CambiarRadio(radio); // establece el radio
    area = fig.ObtenerArea(); // Obtiene el area
    Console.WriteLine("{0:F2}",area);

   }

  class Circulo{
      private int radio ;


      public int ObtenerRadio(){
          return radio;
      }
      public void CambiarRadio(int radio){
        this.radio = radio;
      }
      public double ObtenerArea(){
        double area;
        area = 3.14159 * radio * radio; 
        return area;
      }
  }

}