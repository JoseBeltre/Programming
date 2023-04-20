using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tCENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\r\n\r\n\tJosé Luis Beltre Cordero\r\n\tNO. #2\r\n\tPROFESOR: JOSE SIERRA\r\n\tFECHA: 02/12/2022\r\n\tCrear un programa que convierta UNA CANTIDAD DE SEGUNDOS en horas,\r\n\tminutos y segundos. (Salida: “5 H: 15 M: 4S”). (2 P)");
            Console.WriteLine("===========================================================================================");


            Console.WriteLine("Introduzca la cantidad de segundos a continuación: ");
            int cantidadSegundos = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad de segunddos ingresada es " + cantidadSegundos + "\r\n");
            int conversionMinutos = cantidadSegundos / 60;
            int segundos = cantidadSegundos % 60;
            int horas = conversionMinutos / 60;
            int minutos = conversionMinutos % 60;
            Console.WriteLine("Resulta en " + horas + "H: " + minutos + "M: " + segundos + "S");

            Console.ReadKey();
        }
    }
}
