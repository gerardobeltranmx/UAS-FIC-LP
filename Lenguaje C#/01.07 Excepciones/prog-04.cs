
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
                if (value >= 0)
                    radio = value;
                else 
                    throw new CirculoException();    
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

        public Circulo(double radio){
            
            if (radio>=0)
            this.radio = radio;
            else
             throw CirculoException();

        }
        public Circulo(){
            this.radio = 0;
        }

      public int ObtenerRadio(){
          return radio;
      }
      public void CambiarRadio(int radio){
        if (radio >= 0)
            this.radio = radio;
        else
            throw  new CirculoException();   

      }
      public double ObtenerArea(){
        double area;
        area = 3.14159 * radio * radio; 
        return area;
      }
  }

}


class CirculoException : ApplicationException
    {

        public CirculoException(): base("Radio fuera de rango...")
        {

        }

    }
