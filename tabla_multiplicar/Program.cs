using System;

namespace tabla_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que muestre la tabla de multiplicar de un numero \n");

            int a, b;
            Console.WriteLine("Digite la tabla del numero que desea");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i <= 12; i++)
            {
                b = a * i;
                Console.WriteLine(a+"*"+i+"="+b);
            }
            Console.ReadKey();
        }
    }
}
