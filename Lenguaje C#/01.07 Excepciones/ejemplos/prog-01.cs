using System;
class HelloWorld {
  static void Main() {

        int i;
        
        try {
            Console.Write("Escriba un numero: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i);
        }    
        catch (Exception error ){
            Console.WriteLine(error.Message);
        }

  }
}