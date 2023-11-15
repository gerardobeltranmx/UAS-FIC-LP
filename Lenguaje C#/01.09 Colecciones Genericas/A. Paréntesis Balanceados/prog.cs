
using System;
using System.Collections.Generic;
class Principal {
  static void Main() {
   
   Stack <char> pila  = new Stack <char>();
   string cadena;
   char car, simbolo; 
   bool error = false;
   cadena = Console.ReadLine();


   for (int i=0; i < cadena.Length && error==false ; i++ ){

        car = cadena[i];

        if (car=='{' || car=='[' || car == '(' ){
            pila.Push(car);
        }
        else {
            simbolo = pila.Pop();

            switch (simbolo){
               case '{' :
                  if (car!='}') error= true;  
                  break;
               case '[':
                  if (car!=']') error= true;
                  break;
               case '(':
                  if (car!=')') error= true;  
                  break;  
                
            }
        }
   } 


    if (pila.Count == 0 && error == false)
        Console.WriteLine("SI");
    else 
        Console.WriteLine("NO");    

 
   
  }
}