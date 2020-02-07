using System;

namespace programa_numeropositivo_ycuenta_atras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que pide un numero entero positivo y que cuenta hacia atras \n");

            int a;
            Console.WriteLine("Digite un numero entero positivo");
            a = Convert.ToInt32(Console.ReadLine());
            
            while(a<1)
            { 
                Console.WriteLine("Debe digitar un numero que sea positivo, intente una vez mas");
                a = Convert.ToInt32(Console.ReadLine());
            }

            while (a >= 1)
            {
                
                if (a > 1)
                {
                    Console.Write(a + ",");
                    a--;
                    
                }
                else
                {
                    Console.Write(a);
                    break;
                }
                
            }
            
        Console.ReadKey();
        }
    }
}
