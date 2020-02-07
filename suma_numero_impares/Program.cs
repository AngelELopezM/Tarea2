using System;

namespace suma_numero_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula la suma de todos los numeros impares entre 1 y el numero digitado \n");

            int a, b, c,d;
            Console.WriteLine("digite el numero que desea");
            a = Convert.ToInt32(Console.ReadLine());

            c = a;//Aqui yo acumule el valor inicial de A, para entonces poder sumar el valos inicial
            //a los numero impares.
            
            while (a >= 1)//Aqui ejecute el bucle para que tome todos los numero impares desde el valor inicial de A hasta el 1
            {
                b = a % 2;
                switch (b)//Con este switch entonces dije que si al dividir a/2 el residue me daba 1, es porque el numero era impar
                {
                    case 1:
                        d = c +a;//aqui acumule en 'd' la suma del valor inicial de 'a' que acumule en 'c', mas todos los numero impares que puse en 'a'
                        Console.WriteLine(c+"+"+a+"="+d);
                        break;
                }
                a--;
            }
            Console.ReadKey();
        }
    }
}
