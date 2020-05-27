using System;

namespace TP6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numControl = 0, num1, num2, resultado;
            Console.WriteLine("--- CALCULADORA ---");

            while(numControl != 5)
            {
                Console.WriteLine("\nMarque 1 para sumar, 2 para restar, 3 para multiplicar o 4 para dividir: ");
                numControl = Convert.ToInt32(Console.ReadLine());

                switch (numControl)
                {
                    case 1:
                        Console.WriteLine("\n--- SUMA ---\n");
                        Console.WriteLine("Ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resultado = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: " + resultado + "\n");
                        Console.WriteLine("¿Desea realizar otra operacion? Si(1) o No(5)");
                        numControl = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("\n--- RESTA ---\n");
                        Console.WriteLine("Ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resultado = num1 - num2;
                        Console.WriteLine("El resultado de la resta es: " + resultado + "\n");
                        Console.WriteLine("¿Desea realizar otra operacion? Si(1) o No(5)");
                        numControl = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("\n--- MULTIPLICACION ---\n");
                        Console.WriteLine("Ingrese el primer numero: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        resultado = num1 * num2;
                        Console.WriteLine("El resultado de la multiplicacion es: " + resultado + "\n");
                        Console.WriteLine("¿Desea realizar otra operacion? Si(1) o No(5)");
                        numControl = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("\n--- DIVISION ---\n");
                        Console.WriteLine("Ingrese el dividendo: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el divisor: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("El resultado de la division es: " + resultado + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Error, el divisor no puede ser 0.\n");
                        }
                        Console.WriteLine("¿Desea realizar otra operacion? Si(1) o No(5)");
                        numControl = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
        }
    }
}
