using System;

namespace Tarea1
{
    class ProgramaMenu
    {
        public void Menu()
        {
            bool salir = false;

            do
            {
                string opcion = "";
                Console.WriteLine("Registro de pagos de educación continua.");
                Console.WriteLine("1.Altas");
                Console.WriteLine("2.Bajas");
                Console.WriteLine("3.Actualizaciones");
                Console.WriteLine("4.Consultas");
                Console.WriteLine("");
                Console.WriteLine("9.Salir");

                Console.WriteLine("Seleccione la opcion deseada: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Seleccionó Alta");
                        break;
                    case "2":
                        Console.WriteLine("Seleccionó Bajas.");
                        break;
                    case "3":
                        Console.WriteLine("Seleccionó Actualizaciones.");
                        break;
                    case "4":
                        Console.WriteLine("Seleccionó Consultas.");
                        break;
                    case "9":
                        Console.WriteLine("Seleccionó Salir.");
                        Console.WriteLine("Fin del programa..");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción invalida.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (!salir);
        }
    }
}
