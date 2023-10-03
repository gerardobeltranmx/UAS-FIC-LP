
using System;
class Principal {
  static void Main() {
    decimal saldo;
    CuentaBancaria micuenta = new CuentaBancaria( );
      micuenta.CambiarNombre("Juan Lopez");     
	  micuenta.Deposito(2000);
      micuenta.Retiro(5000); 
      saldo = micuenta.ObtenerSaldo();
      
      //micuenta.saldo = 1000000;
      Console.WriteLine(micuenta.ObtenerNombre());
      Console.WriteLine(saldo);
      
      
      
  }
}

class CuentaBancaria
{
  private decimal saldo;
  private string nombre;
  public void Retiro(decimal cantidad){ 
      
      if (cantidad<=saldo)
         	saldo-=cantidad;
      else
         Console.WriteLine("Saldo insuficiente!!!");
  }
  public void Deposito(decimal cantidad){ 
	saldo+=cantidad;
  }
  public decimal ObtenerSaldo( ){ 
	return saldo;
  }
  public void CambiarNombre(string nombre){
        
	 this.nombre = nombre;
    
    }
  public string ObtenerNombre(){
      return this.nombre;
  }     


}    

