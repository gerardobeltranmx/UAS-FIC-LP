
using System;
class Principal {
  static void Main() {
    int num1, num2, suma;
    string linea;
    string [] datos;
    // entrada de los numeros
    linea = Console.ReadLine();
    // dividir linea en 2 numeros 
    datos = linea.Split(" ");
    // Convertir a numeros 
    num1 = int.Parse(datos[0]);
    num2 = int.Parse(datos[1]);
    suma = num1 + num2;
    Console.WriteLine(suma);
  }
}