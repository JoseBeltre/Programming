using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tCENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\r\n\r\n\tJosé Luis Beltre Cordero\r\n\tNO. #2\r\n\tPROFESOR: JOSE SIERRA\r\n\tFECHA: 02/12/2022\r\n\tImprimir los números del 50 al 100 (while) (2 P)");
            Console.WriteLine("===========================================================================================");

            int num = 50;
            while (num <= 100) {
                Console.WriteLine("The current number is " + num);
                num++;
            }
            Console.ReadKey();

        }
    }
}
