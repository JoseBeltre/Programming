using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tCENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\r\n\r\n\tJosé Luis Beltre Cordero\r\n\tNO. #2\r\n\tPROFESOR: JOSE SIERRA\r\n\tFECHA: 02/12/2022\r\n\tImprimir los números del 1 al 500 que solo sean múltiplos del 3 y 5. (2 P)");
            Console.WriteLine("===========================================================================================");

            int counter = 0;
            while (counter++ <= 500)
            {
                int module5 = counter % 5;
                int module3 = counter % 3;
                if (module5 == 0 && module3 == 0)
                {
                    Console.WriteLine(counter + " Es multiplo de 3 y 5");
                }
            }
            Console.ReadKey();
        }
    }
}
