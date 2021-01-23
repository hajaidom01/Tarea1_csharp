using System;

namespace Tarea1
{
    class Program
    {
        protected Program()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("Ejercicio 1: (pulse 1)");
            Console.WriteLine("Ejercicio 2: (pulse 2)");
            Console.WriteLine("Ejercicio 3: (pulse 3)");
            Console.WriteLine("Ejercicio 4: (pulse 4)");
            Console.WriteLine("Ejercicio 5: (pulse 5)");

            string opcion = Console.ReadLine();


            switch (opcion)
            {
                case "1":
                    NumeroMayor mayor = new NumeroMayor();
                    Console.Clear();
                    mayor.ObtenerMayor();
                    break;
                case "2":
                    DatosTrabajador datos = new DatosTrabajador();
                    Console.Clear();
                    datos.CapturarDatos();
                    break;
                case "3":
                    DiaSemana dia = new DiaSemana();
                    Console.Clear();
                    dia.ObtenerDia();
                    break;
                case "4":
                    ProgramaMenu menu = new ProgramaMenu();
                    Console.Clear();
                    menu.Menu();
                    break;
                case "5":
                    Multiplicador mult = new Multiplicador();
                    mult.TablaDeMultiplicar();
                    break;
                default:
                    Console.WriteLine("Opcion invalida.");
                    Console.ReadKey();
                    break;
            }


        }
    }
}
