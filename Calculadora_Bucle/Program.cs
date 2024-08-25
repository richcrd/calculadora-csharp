using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operador;
            double num1, num2, resultado;

            Console.WriteLine("=========================");
            Console.WriteLine("-------CALCULADORA-------");
            Console.WriteLine("=========================");
            do
            {
                Console.WriteLine("\nPor favor ingrese el primer numero");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\nPor favor ingrese el segundo numero");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el operador (+,-,*,/)");
                operador = Convert.ToChar(Console.ReadLine());
                switch (operador)
                {
                    case '+':
                        resultado = num1 + num2;
                        break;
                    case '-':
                        resultado = num1 - num2;
                        break;
                    case '*':
                        resultado = num1 * num2;
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir por cero");
                            continue; // Vuelve al inicio del bucle sin ejecutar el siguiente bloque de codigo
                        }
                        break;
                    default:
                        Console.WriteLine("Operador no valido");
                        continue;
                }
                Console.WriteLine("El resultado es: " + resultado);
                Console.WriteLine("Desea realizar otra operacion? (S/N)");
                string respuesta2 = Console.ReadLine();
            } while (Console.ReadLine().ToUpper() == "S");
            
            Console.ReadKey();
        }
    }
}
