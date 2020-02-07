using System;

namespace numeros_invertidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros invertidos \n");

            int num1, num2, num3;
            Console.WriteLine("Numero invertido");
            num1 = Convert.ToInt32(Console.ReadLine());

            string num = num1.ToString();//RECORDAR PARA CONVERTIR UN INT PARA STRING PRIMERO TENGO QUE DECLARAR EL STRING QUE QUIERO
            char[] invertir = num.ToCharArray();
            Array.Reverse(invertir);

            Console.WriteLine(invertir);
            Console.ReadKey();

            
         }
    }
}
