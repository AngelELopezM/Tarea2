using System;

namespace Sumadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sumadora \n");
            int a, b, c, d;

            do
            {
                Console.WriteLine("Digite el primer digito");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite el segundo digito");
                b = Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine(a+"+"+b+"="+c);

                Console.WriteLine("Desea realizar otra suma?\n 1-Si \n 2-No");
                d = Convert.ToInt32(Console.ReadLine()); ;
                    
            }
            while (d==1);
        }
    }
}
