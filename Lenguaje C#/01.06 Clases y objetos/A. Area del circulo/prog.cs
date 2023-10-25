
using System;
class Principal {
  static void Main() {
    int radio;
    double area;
    Circulo fig, llanta; // Crea el objeto circulo
   
    radio = int.Parse(Console.ReadLine());
    fig = new Circulo(); // Asigna memoria
    //fig.CambiarRadio(radio); // establece el radio
    fig.Radio = radio;
    //area = fig.ObtenerArea(); // Obtiene el area
    Console.WriteLine("{0:F2}",fig.Area);
   }
  class Circulo{
      private int radio ;
       // Propiedad Radio
        public int Radio
        {
            set {
                if (value > 0)
                    radio = value;
            }
            get {
                return radio;
            }
        }
        // Propiedad Area
        public double Area
        {
            get {
                return ObtenerArea();
            }
        }



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