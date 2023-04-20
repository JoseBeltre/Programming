using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7mo_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\t  .:CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA:.\r\n\r\n\t\tJosé Luis Beltre Cordero\r\n\t\t\tNO. #2\r\n\t\t PROFESOR: JOSE SIERRA\r\n\t\t  FECHA: 03/12/2022\r\n\r\n  Haciendo uso de DO WHILE: escribir un programa que ingrese un valor del\r\n  1 hasta el 9,999. El programa debe decir de cuantas cifras en el valor\r\n  ingresado. Finalizar el programa si el usuario ingresa cualquier número\r\n  negativo. (10 P)");
            Console.WriteLine("===========================================================================================\r\n");

            int num;

            do
            {
                //Pidiendole el número al usuario
                Console.WriteLine(" .:Ingresa un número entre 1 y 9,999, si ingresas un número negativo el programa se cerrará:.");
                Console.Write("Aquí --> ");
                num = int.Parse(Console.ReadLine());

                //Convirtiendo el número de int a string para poder usar el método "Lenght"
                string numString = num.ToString();
                int numLength = numString.Length;

                Console.WriteLine();

                //Mensajes dependientes del número ingresado
                if (num < 0)
                {
                    Console.WriteLine("-> El número ingresado es negativo <-");
                }
                else if (num > 0 && num < 10000)
                {
                    Console.WriteLine("-> El número ingresado contiene: " + numLength + " dígitos <-");

                }
                else
                {
                    Console.WriteLine("-> El número ingresado supera el límite <-");
                }
                Console.WriteLine();
                //Condición para que se repita el bucle
            } while (num >= 0);
            Console.WriteLine("  .:Se ha cerrado el Programa:.");
            Console.ReadKey();
        
        
        }
    }
}
