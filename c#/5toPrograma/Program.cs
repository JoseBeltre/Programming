using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5toPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tCENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\r\n\r\n\tJosé Luis Beltre Cordero\r\n\tNO. #2\r\n\tPROFESOR: JOSE SIERRA\r\n\tFECHA: 02/12/2022\r\n\tImprimir los números del 1 al 100 que sean pares (while) (2 P)");
            Console.WriteLine("===========================================================================================");

            int counter = 0;
            while(counter++ <= 100) 
            {
                int module = counter % 2;
                if (module == 0)
                {
                    Console.WriteLine(counter);
                };
            };
            Console.ReadKey();
        }
    }
}
