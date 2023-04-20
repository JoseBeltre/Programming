using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8vo_Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\t  .:CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA:.\r\n\r\n\t\tJosé Luis Beltre Cordero\r\n\t\t\tNO. #2\r\n\t\t PROFESOR: JOSE SIERRA\r\n\t\t  FECHA: 03/12/2022\r\n\r\n  El Centro Comercial CEPVA C X A requiere llevar el control de los ingresos y\r\n  egresos de la empresa. Se solicita un programa que acumule dichos ingresos\r\n  y retiros, que contabilice o cuente la cantidad de cada uno e imprima sus\r\n  resultados. Además, debe decir si el balance es acreedor o deudor. El\r\n  programa debe terminar su ejecución si el usuario escribe el código 0011\r\n  (10 P)");
            Console.WriteLine("===========================================================================================\r\n");

            int opcion;
            decimal ingresos = 0;
            decimal egresos = 0;
            decimal saldo;
            int contadorIngresos = 0;
            int contadorEgresos = 0;


            Console.WriteLine("¡Bienvenido! somos CEPVA CxA");
            do
            {
                Console.WriteLine("\t¿Qué desea hacer?\r\n  1. Ingresar\r\n  2. Egresar\r\n  3. Recuento/Historial\r\n 0011. Para salir del Programa\r\n");
                Console.Write("Ingrese una opción válida -> ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (opcion == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la opción 'Ingresar'");
                    Console.Write("   Ingrese la cantidad: ");
                    decimal nuevoIngreso = decimal.Parse(Console.ReadLine());
                    ingresos = ingresos + nuevoIngreso;
                    Console.WriteLine("Has ingresado: $" + String.Format(CultureInfo.InvariantCulture,"{0:0,0.00}", nuevoIngreso) + " DOP\r\n");
                    contadorIngresos++;
                    
                }
                else if( opcion == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Has seleccionado la opción 'Egresar'");
                    Console.Write("   Ingrese la cantidad: ");
                    decimal nuevoEgreso = decimal.Parse(Console.ReadLine());
                    egresos = egresos + nuevoEgreso;
                    Console.WriteLine("Has retirado: $" + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", nuevoEgreso) + " DOP\r\n");
                    contadorEgresos++;


                }
                else if(opcion == 3)
                {
                    Console.Clear();
                    decimal procesoSaldo = ingresos - egresos;
                    saldo = procesoSaldo;

                    Console.WriteLine("Has seleccionado la opción 'Recuento/Historial'");
                    Console.WriteLine("   Cantidad total Ingresada: $" + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", ingresos) + " DOP\r\n    Total de transacciones acreedoras realizadas: " + contadorIngresos + "\r\n");
                    Console.WriteLine("   Cantidad total Egresada/Retirada: $" + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", egresos) + " DOP\r\n    Total de transacciones deudoras realizadas: " + contadorEgresos + "\r\n");
                    Console.WriteLine("   Saldo actual: $" + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", saldo) + " DOP\r\n    Total de transacciones realizadas: " + (contadorEgresos + contadorIngresos) + "\r\n" );

                    if (saldo > 0)
                    {
                        Console.WriteLine("  Su balance es acreedor\r\n");
                    } else if(saldo < 0)
                    {
                        Console.WriteLine("  Su balance es deudor\r\n");
                    }
                    else
                    {
                        Console.WriteLine("  Su balance es nulo\r\n");
                    }

                } else if(opcion == 0011)
                {
                    Console.WriteLine("Has seleccionado la opción 'Salir del Programa'");
                } else
                {
                    Console.WriteLine("'" + opcion + "' No es un valor válido\r\n");
                }

            } while (opcion != 0011);
        }
    }
}
