
using System;
class Principal {
  static void Main() {
    int N;
    string linea;
    string []datos;  
    N = int.Parse(Console.ReadLine());

    linea = Console.ReadLine() ;

    datos = linea.Split(" ");

    for (int i=N-1; i>=0; i--)
        Console.Write("{0} ", datos[i]);
  
  }
}