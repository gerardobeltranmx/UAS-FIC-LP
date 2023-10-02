
using System;
class Principal {
    static void Main() {
   
      int N;
      int [,] mat;
      bool enc=true; 
      string linea;
      string [] datos;
      // se establece tamaño a la matriz
      N = int.Parse(Console.ReadLine());
      mat = new int [N,N];
      // entrada de datos
      for (int i=0; i<N; i++){
          linea = Console.ReadLine();
          datos = linea.Split(" ");
        for (int j=0; j<N; j++){
          mat[i,j]=int.Parse(datos[j]);
        }
      }
      int valor = mat[0,0];
      for (int i=0; i<N && enc==true; i++){
          if (mat[i,i]!=valor){
             enc = false;
          }
      }
      if (enc==true)
          Console.WriteLine("SI");
      else
          Console.WriteLine("NO");    













   
  }
}