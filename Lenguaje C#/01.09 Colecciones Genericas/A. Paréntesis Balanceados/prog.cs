
using System;
using System.collections;
class Principal {
  static void Main() {
   
   Stack pila <char> = new Stack <char>();
   string cadena;
   char car, simbolo; 
   bool error = false;
   cadena = Console.ReadLine();


   for (int i=0; i < cadena.Length and error==false ; i++ ){

        car = cadena[i];

        if (car=='{' or car=='[' or car == '(' ){
            pila.push(car);
        }
        else {
            simbolo = pila.pop();

            switch (simbolo){
               '{' :
                  if (car!='}') error= true;  
                  break;
                '[':
                  if (car!=']') error= true;
                  break;
                '(':
                  if (car!=')') error= true;      

            }
        }
   } 
    




   
  }
}