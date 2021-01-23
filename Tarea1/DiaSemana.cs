using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    public class DiaSemana
    {
        public void ObtenerDia()
        {
            Console.WriteLine("Capture el numero del dia de la semana (1 al 7).");
            string dia = Console.ReadLine();

            switch (dia)
            {
                case "1":
                    dia = "domingo";
                    break;
                case "2":
                    dia = "lunes";
                    break;
                case "3":
                    dia = "martes";
                    break;
                case "4":
                    dia = "miercoles";
                    break;
                case "5":
                    dia = "jueves";
                    break;
                case "6":
                    dia = "viernes";
                    break;
                case "7":
                    dia = "sabado";
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no es valida.");
                    Console.WriteLine("Fin del programa.");
                    return;

            }

            Console.WriteLine($"El día seleccionado es : {dia}.");
            Console.ReadKey();
        }
    }
}
