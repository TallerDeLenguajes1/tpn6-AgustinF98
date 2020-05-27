using System;

namespace TP6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, numInvert = 0;
            Console.WriteLine("Ingrese un numero mayor a 0");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                while (num != 0)
                {
                    resto = num % 10;
                    num = num / 10;
                    numInvert = numInvert * 10 + resto;
                }

                Console.WriteLine("El numero ingresado invertido es: " + numInvert);
            }
            else
            {
                Console.WriteLine("error al invertir el numero, ingrese un numero mayor a 0");
            }
        }
    }
}
