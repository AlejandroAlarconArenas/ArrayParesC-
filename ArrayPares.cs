using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; // declaramos el array con el número de slots 

            for (int i = 0; i < 10; i++) //iniciamos bucle para rellenar array
            {
                Console.WriteLine("Introduce los valores del vector "); //Mostramos mensaje de introducir valores en array
                array[i] = int.Parse( Console.ReadLine());//introducimos los datos del array y los convertimos a INT
              
                }

            int contador = 0; //Declaramos la variable que va a contar cuantos números del bucle son pares

            for (int i = 0; i < 10; i++) //iniciamos bucle para pasar por todos los numeros del array 
            {

                if (array[i] % 2 == 0) contador++; //declaramos la condición, si el número del array %2 == 0 , variable contador ++
            }

            Console.WriteLine("Los números pares introducidos son: {0}", contador); //escribimos el valor de la variable contador
           
            
        

            

            




            
        }
    }
}





