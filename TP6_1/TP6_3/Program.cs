using System;

namespace TP6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, resultado = 0;
            int num2, num3;
            
            Console.WriteLine("--- CALCULADORA MEJORADA ---\n");
            Console.WriteLine("Ingrese un numero con decimales: ");
            num1 = Double.Parse(Console.ReadLine());

            resultado = Math.Abs(num1);
            Console.WriteLine("\nEl valor absoluto del numero: " + num1 + " es: " + resultado);
            resultado = Math.Pow(num1, 2);
            Console.WriteLine("El cuadrado del numero: " + num1 + " es: " + resultado);
            resultado = Math.Sqrt(num1);
            Console.WriteLine("La raiz cuadrada del numero: " + num1 + " es: " + resultado);
            resultado = Math.Sin(num1);
            Console.WriteLine("El seno del numero: " + num1 + " es: " + resultado);
            resultado = Math.Cos(num1);
            Console.WriteLine("El coseno del numero: " + num1 + " es: " + resultado);
            resultado = Math.Truncate(num1);
            Console.WriteLine("La parte entera del numero: " + num1 + " es: " + resultado);

            Console.WriteLine("\nIngrese dos numeros enteros");
            Console.WriteLine("Primer numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo numero: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEl maximo de los 2 numeros ingresados es: " + Math.Max(num2, num3));
            Console.WriteLine("El minimo de los 2 numeros ingresados es: " + Math.Min(num2, num3));
        }
    }
}
