using System;
class HelloWorld {
  static void Main() {

        int a, b, c;
        
        try {
            Console.Write("Escriba un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escriba otro numero: ");
            b = int.Parse(Console.ReadLine());
            
            c = a / b;

            Console.WriteLine(c);

        }    
        catch (FormatException error ){
            Console.WriteLine("Error en el format de entrada");
        }
        catch (OverflowException error ){
            Console.WriteLine("Error, el numero es muy grande");
        }
         catch (DivideByZeroException error ){
            Console.WriteLine("El segundo valor debe ser mayor que cero");
        }
        catch (Exception error ){
            Console.WriteLine("Error: {0}", error.Message);
        }
  }
}