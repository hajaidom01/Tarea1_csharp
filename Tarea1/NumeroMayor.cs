using System;
using System.Collections.Generic;
using System.Linq;

namespace Tarea1
{
    public class NumeroMayor
    {
        public void ObtenerMayor()
        {
            List<int> numeros = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Capture el número {i + 1}");
                string valor = Console.ReadLine();

                if (!string.IsNullOrEmpty(valor))
                {
                    try
                    {
                        numeros.Add(int.Parse(valor));
                    }
                    catch
                    {

                        Console.WriteLine("Error al capturar los números (Solo se permiten valores numéricos).");
                        Console.WriteLine("Fin del programa.");
                        Console.ReadKey();
                        return;
                    }
                }
            }

            string mayor = numeros.OrderByDescending(x => x).FirstOrDefault().ToString();

            Console.WriteLine($"El número mayor es {mayor}");
            Console.WriteLine("Presione cualquier tecla para terminar.");
            Console.ReadKey();

        }
    }
}
