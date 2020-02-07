using System;

namespace numero_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de Fibonacci ");

            int rep, primer=0, anterior=1,final;
            Console.WriteLine("Digite cuantas veces quiere que se repita");
            rep = Convert.ToInt32(Console.ReadLine());
            for (int i=0; i<=rep;i++)
            {
                final = primer + anterior;
                
                Console.WriteLine(primer+"+"+anterior+"="+final);
                primer = anterior;
                anterior = final;
            }
            Console.ReadKey();

        }
    }
}
