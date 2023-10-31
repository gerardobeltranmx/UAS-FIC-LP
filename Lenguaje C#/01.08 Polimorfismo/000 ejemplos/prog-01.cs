
using System;
class Principal {
  static void Main() {
   figura obj;
      obj = new circulo(2);
      Console.WriteLine("El Área del Círculo es {0}", obj.Area ());

      obj = new cuadrado(5);
      Console.WriteLine("El Área del Cuadrado es {0}", obj.Area ());
  
  

      obj = new triangulo(5,20);
      Console.WriteLine("El Área del Triangulo es {0}", obj.Area ());
 
  }


}


class figura
{
    public virtual Double Area( )  
    { 
	    return 0;
    }
    public virtual Double Perimetro( ) 
    { 
	    return 0;
    } 
}


class cuadrado : figura {
        double lado;

        public cuadrado(double lado) {
            this.lado = lado;
        }
        public override double Area(){
            return lado * lado;
        }
        public override double Perimetro()
        {
            return 4 * lado;
        }
 }
class circulo : figura{
        double radio;

        public circulo(double radio)
        {
            this.radio = radio;
        }
        public override double Area ()
        {
            return 3.1416*radio*radio;
        }
        public override double Perimetro()
        {
            return 2*3.1416*radio ;
        }
  }
class triangulo: figura{
    private double _base, altura;
    
    public triangulo(double _base, double altura){
        this._base = _base;
        this.altura = altura;
    }
    public override Double Area()
    {
        return _base * altura /2;
    }
    public override Double Perimetro()
    {
        return 0;
    }




}