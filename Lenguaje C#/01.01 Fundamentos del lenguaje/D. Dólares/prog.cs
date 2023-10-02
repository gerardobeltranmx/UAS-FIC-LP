
using System;
class Principal {
  static void Main() {

    int numDolares, valorDolar, pesosEquivalentes ;

    numDolares = int.Parse(Console.ReadLine());
    valorDolar = int.Parse(Console.ReadLine());
    pesosEquivalentes = numDolares * valorDolar;

    Console.WriteLine(pesosEquivalentes);
  }
}