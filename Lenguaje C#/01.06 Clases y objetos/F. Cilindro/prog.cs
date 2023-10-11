
using System;
class Principal {
  static void Main() {
   Cilindro objCilindro;
   double radio, altura;

   radio = double.Parse(Console.ReadLine());
   altura = double.Parse(Console.ReadLine());
   
   objCilindro = new Cilindro();

   objCilindro.dimension(radio, altura);


   Console.WriteLine (objCilindro.Area());
   Console.WriteLine (objCilindro.Volumen());
    

   
  }
  
}
class Cilindro {
  private double radio, altura;
  private const double PI = 3.1416;

  public void dimension(double radio, double altura){
    this.radio = radio;
    this.altura = altura;
  }
  public double Area(){
    double area;
    area = PI * radio * radio;
    return area;
  }
  public double Volumen(){
      double volumen;
      volumen = PI * radio * radio * altura;
      return volumen;
  }





}