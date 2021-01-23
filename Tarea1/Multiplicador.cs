using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tarea1
{
    public class Multiplicador
    {
        public void TablaDeMultiplicar()
        {
            Console.WriteLine("Capture el número a multiplicar.");

            string numero = Console.ReadLine();

            Regex reg = new Regex("^[0-9]+$");

            if (!reg.IsMatch(numero))
            {
                Console.WriteLine("El caracter seleccionado no es un número.");
                Console.WriteLine("Fin del programa");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"La tabla de multiplicar seleccionada es la tabla del {numero}\n\n");
                int nBase = int.Parse(numero);

                for (int i = 1; i <= 10; i++)
                {
                    int resultado = i * nBase;
                    Console.WriteLine($"{nBase} * {i} = {resultado}");
                }

                
            }
            Console.ReadKey();
        }
    }
}
