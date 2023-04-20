using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9no_Programa2
{
    class Nomina
    {
        //Variables

        int opcion = 0;
        int contador = 0;

        //Escala anual ISR
        int escala1 = 416220;
        int escala2 = 624329;
        int escala3 = 867123;
        int montoEscala2Escala3 = 31216;
        int montoEscala3 = 79776;

        //Descuentos
        double AFP = 0.0287;
        double SFS = 0.0304; 

        //Vectores / Campos de la Nomina
        int[] codigo = new int[10];
        string[] nombres = new string[10];
        double[] sueldoBruto = new double[10];
        double[] vectorAFP = new double[10];
        double[] vectorSFS = new double[10];
        double[] totalImpuestos = new double[10];
        double[] vectorISR = new double[10];
        double[] totalDescuento = new double[10];
        double[] sueldoNeto = new double[10];

        //Espacios
        string[] nombresEspacios = new string[10];
        string[] sueldoBrutoEspacios = new string[10];
        string[] AFPEspacios = new string[10];
        string[] SFSEspacios = new string[10];
        string[] totalImpuestosEspacios = new string[10];
        string[] ISREspacios = new string[10];
        string[] totalDescuentoEspacios = new string[10];
        string[] sueldoNetoEspacios = new string[10];



        public void Menu()
        {
            //Mostrar menu
            Console.WriteLine("¿Qué desea hacer?\r\n 1. Agregar registro\r\n 2. Mostrar Nómina\r\n 0. Salir del Programa\r\n");
            //Pedir opcion
            Console.Write("--> ");
            opcion = int.Parse(Console.ReadLine());

        }


        public void AgregarRegistros() 
        {
            Console.Clear();
            string nombre;
            double sueldob;
            double totalAFPySFS;
            double sueldoDescuentadoAnual;

            //Pidiendo Nombre
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            //Pidiendo Sueldo
            Console.Write("Digite el sueldo del empleado " + nombre + ": ");
            sueldob = double.Parse(Console.ReadLine());

            //Agregando datos a los Vectores/Arreglos

            //Codigo
            codigo[contador] = contador + 1;

            //Nombres
            nombres[contador] = nombre;

            //Sueldo Bruto
            sueldoBruto[contador] = sueldob;

            //AFP
            vectorAFP[contador] = sueldob * AFP;

            //SFS
            vectorSFS[contador] = sueldob * SFS;

            //Total Impuestos AFP y SFS
            totalImpuestos[contador] = vectorAFP[contador] + vectorSFS[contador];

            //ISR
            totalAFPySFS = vectorAFP[contador] + vectorSFS[contador];
            sueldoDescuentadoAnual = (sueldob - totalAFPySFS) * 12;

            if (sueldoDescuentadoAnual < escala1)
            {
                vectorISR[contador] = 0;
            }
            else if (sueldoDescuentadoAnual > escala1 && sueldoDescuentadoAnual <= escala2)
            {
                vectorISR[contador] = ((sueldoDescuentadoAnual - escala1) * 0.15) / 12;
            }
            else if (sueldoDescuentadoAnual > escala2 && sueldoDescuentadoAnual <= escala3)
            {
                vectorISR[contador] = ((sueldoDescuentadoAnual - escala2) * 0.20 + montoEscala2Escala3) / 12;

            }
            else
            {
                vectorISR[contador] = ((sueldoDescuentadoAnual - escala3) * 0.25 + montoEscala3) / 12;

            }

            //Total Descuento
            totalDescuento[contador] = vectorAFP[contador] + vectorSFS[contador] + vectorISR[contador];

            //Sueldo Neto
            sueldoNeto[contador] = sueldoBruto[contador] - totalDescuento[contador];
            //Llamado al método para añadir espacios
            ContarEspacios();

            contador++;
        }

        //Método para añadir espacios
        public void ContarEspacios()
        {
            
            if (nombres[contador].Length < 30)
            {
                for (int i = nombres[contador].Length; i <= 30; i++)
                {
                    nombresEspacios[contador] += " ";
                }
            }

            string sueldoBrutoString = Convert.ToString(sueldoBruto[contador]);
            if (sueldoBrutoString.Length < 15)
            {
                for (int i = sueldoBrutoString.Length; i < 15; i++)
                {
                    sueldoBrutoEspacios[contador] += " ";
                }
            }

            string vectorAFPString = Convert.ToString(vectorAFP[contador]);
            if (vectorAFPString.Length < 15)
            {
                for (int i = vectorAFPString.Length; i < 15; i++)
                {
                    AFPEspacios[contador] += " ";
                }
            }
            string vectorSFSString = Convert.ToString(vectorSFS[contador]);
            if (vectorSFSString.Length < 15)
            {
                for (int i = vectorSFSString.Length; i < 15; i++)
                {
                    SFSEspacios[contador] += " ";
                }
            }string vectortotalImpuestosString = Convert.ToString(totalImpuestos[contador]);
            if (vectortotalImpuestosString.Length < 15)
            {
                for (int i = vectortotalImpuestosString.Length; i < 15; i++)
                {
                    totalImpuestosEspacios[contador] += " ";
                }
            }
            string vectorISRString = Convert.ToString(vectorISR[contador]);
            if (vectorISRString.Length < 15)
            {
                for (int i = vectorISRString.Length; i < 15; i++)
                {
                    ISREspacios[contador] += " ";
                }
            }
            string vectortotalString = Convert.ToString(totalDescuento[contador]);
            if (vectortotalString.Length < 15)
            {
                for (int i = vectortotalString.Length; i < 15; i++)
                {
                    totalDescuentoEspacios[contador] += " ";
                }
            }
            string vectorNetoString = Convert.ToString(sueldoNeto[contador]);
            if (vectorNetoString.Length < 15)
            {
                for (int i = vectorNetoString.Length; i < 15; i++)
                {
                    sueldoNetoEspacios[contador] += " ";
                }
            }



        }
        //Método para ver la tabla de la nómina
        public void MostrarTabla()
        {
            Console.Clear();
            
            Console.WriteLine("Centro Educativo CEPVA\r\nNómina de Empleados\r\nCorrespondiente al mes de Diciembre,2022\r\n(Valores en RD$)\r\n\r\n");
            Console.WriteLine("\t---------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\t|Codigo\t|            Nombres            | Sueldo  Bruto |      AFP      |      SFS      |      T.I      |      ISR      |  Total Desc.  |  Sueldo Neto  |");
            Console.WriteLine("\t---------------------------------------------------------------------------------------------------------------------------------------------------------");


            //Bucle For para mostrar la nómina cuantas veces se hayan ingresado registros
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("\t|" + codigo[i] + "\t|" + nombres[i] + nombresEspacios[i] + "|" +
                    sueldoBruto[i] + sueldoBrutoEspacios[i] + "|" +
                    vectorAFP[i] + AFPEspacios[i] + "|" +
                    vectorSFS[i] + SFSEspacios[i] + "|" +
                    totalImpuestos[i] + totalImpuestosEspacios[i] + "|" +
                    vectorISR[i] + ISREspacios[i] + "|" +
                    totalDescuento[i] + totalDescuentoEspacios[i] + "|" +
                    sueldoNeto[i] + sueldoNetoEspacios[i] + "|");

            };
            Console.WriteLine("\t---------------------------------------------------------------------------------------------------------------------------------------------------------\r\n");

        }

        //Método principal
        public void CorrerPrograma()
        {
            do
            {
                Menu();

                if (opcion == 1)
                {
                    AgregarRegistros();
                }
                else if (opcion == 2)
                {
                    MostrarTabla();
                }
                else if (opcion != 0)
                {
                    Console.WriteLine("Has ingresado un valor no valido");
                }
            } while (opcion != 0);
            
        }

        static void Main(string[] args)
        {
            //Encabezado
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\t  .:CENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA:.\r\n\r\n\t\tJosé Luis Beltre Cordero\r\n\t\t\tNO. #2\r\n\t\t PROFESOR: JOSE SIERRA\r\n\t\t  FECHA: 03/12/2022\r\n\r\n  Haciendo uso de VECTORES, CICLOS entre otros, realizar una nomina de\r\n  pago para 10 empleados donde se reflejen todos los cálculos y los\r\n  descuentos de ley. Ver imagen. (20 P)");
            Console.WriteLine("===========================================================================================\r\n");

            //Creacion de un objeto "Nomina"
            Nomina nom = new Nomina();
            //Llamando al metodo que comienza la ejecucion del programa
            nom.CorrerPrograma();

            
            //José Luis Beltre Cordero #2
        }
    }
}
