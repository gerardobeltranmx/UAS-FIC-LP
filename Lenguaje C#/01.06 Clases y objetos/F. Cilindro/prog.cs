using System;
class Principal {
  static void Main() {
   Cilindro objCilindro;
   double radio, altura;

   radio = double.Parse(Console.ReadLine());
   altura = double.Parse(Console.ReadLine());

   objCilindro = new Cilindro(radio, altura);
   //objCilindro.dimension(radio, altura);

   Console.WriteLine (objCilindro.Area());
   Console.WriteLine (objCilindro.Volumen());
  }
}
class Cilindro {
  private double radio, altura;
  private const double PI = 3.1416;
  
  
  public Cilindro(){
      this.radio = 10;
      this.altura = 20;
  }

  public Cilindro(double radio, double altura){
      this.radio = radio;
      this.altura = altura;
  }

  public void dimension(double radio, double altura){
    this.radio = radio;
    this.altura = altura;
  }
  public double Area(){
    double area;
    area = 2* PI * radio * radio + 2 * PI * radio * radio;
    return area;
  }
  public double Volumen(){
      double volumen;
      volumen = PI * radio * radio * altura;
      return volumen;
  }





}