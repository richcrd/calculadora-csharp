using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("=========================");
            Console.WriteLine("-------CALCULADORA-------");
            Console.WriteLine("=========================");
            Console.WriteLine("\nPor favor ingrese el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPor favor ingrese el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Que tipo de operacion desea realizar?");
            Console.WriteLine("Por favor ingrese:" +
                "\n 1 para suma" +
                "\n 2 para resta" +
                "\n 3 para multiplicacion" +
                "\n 4 para division" +
                "\n 5 para salir");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            switch (respuesta)
            {
                case 1: respuesta = num1 + num2;
                    break;
                case 2:
                    respuesta = num1 - num2;
                    break;
                case 3:
                    respuesta = num1 * num2;
                    break;
                case 4:
                    respuesta = num1 / num2;
                    break;
                default:
                    break;
            }
            Console.WriteLine("El resultado es: " + respuesta);
            Console.ReadKey();
        }
    }
}
