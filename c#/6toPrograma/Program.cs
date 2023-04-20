using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6toPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================================================================================");
            Console.WriteLine("\tCENTRO EDUCATIVO POLITECNICO VIRGEN DE LA ALTAGRACIA\r\n\r\n\t\tJosé Luis Beltre Cordero\r\n\t\t\tNO. #2\r\n\t\t PROFESOR: JOSE SIERRA\r\n\t\t  FECHA: 03/12/2022\r\n\r\n  Utilizando FOR, crear un programa que cargue 5 calificaciones de un alumno\r\n  por teclado y nos muestre el promedio. ¡Si el promedio es mayor o igual a\r\n  80 el programa debe decir: promovido exitosamente!, en caso contrario\r\n  debe decir: ¡Reprobado! (10 P )");
            Console.WriteLine("===========================================================================================");

            List<int> calificaciones = new List<int>();
            //Bucle para pedir calificaciones
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese la Calificación No." + i );
                calificaciones.Add(int.Parse(Console.ReadLine()));

            }
            //Mostrar las calificaciones por pantalla
            Console.WriteLine("\tCalificaciones\r\n" + "\t|" + calificaciones[0] + "|" + calificaciones[1] + "|" + calificaciones[2] + "|" + calificaciones[3] + "|" + calificaciones[4] + "|");
            
            //Variable para sacar el promedio
            int promedio = (calificaciones[0] + calificaciones[1] + calificaciones[2] + calificaciones[3] + calificaciones[4]) / 5;
            Console.WriteLine("Su promedio de Calificaciones es: " + promedio);

            //Validaciones para los mensajes dependientes del promedio
            if (promedio >= 80 && promedio <= 100)
            {
                Console.WriteLine("¡Promovido Exitosamente!");
            } else if (promedio >= 0 && promedio <= 79)
            {
                Console.WriteLine("¡Reprobado!");
            }
            //Con el debido respeto me tome la libertad de agregar otra condición para indicar al usuario si su promedio es incorrecto
            else
            {
                Console.WriteLine("Tu promedio es incorrecto, vuelve a ingresar valores válidos, Recuerda no se aceptan valores negativos ni por encima de 100");
            }

            Console.ReadKey();

        }
    }
}
