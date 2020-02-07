using System;

namespace Todos_los_numeros_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprime todos los numeros impares desde el 1 hasta el numero digitado \n");

            int a,b,c;

            b = Convert.ToInt32(Console.ReadLine());
            for(c=0; b>=c;c--) {
                a = b % 2; //Cuando utilizamos este simbolo de % estamos pidiendo el sobrante de un division y a partir de ese sobrante
                //ejecutamos la formula para saber si un numero es par o impar.
                if (a == 1)
                {
                    Console.Write(b+",");
                }
                b--; 
                

            }


            Console.ReadKey();
        }
    }
}
