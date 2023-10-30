using System;
class HelloWorld {
  static void Main() {

        int i;
        
        try {
            Console.Write("Escriba un numero: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i);
        }    
        catch (FormatException error ){
            Console.WriteLine("Error en el format de entrada");
        }
        catch (OverflowException error ){
            Console.WriteLine("Error, el numero es muy grande");
        }
        catch (Exception error ){
            Console.WriteLine("Error: {0}", error.Message);
        }
  }
}