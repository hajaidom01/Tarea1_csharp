using System;

namespace Tarea1
{
    public class DatosTrabajador
    {
        public void CapturarDatos()
        {
            Trabajador trabajador = new Trabajador();

            try
            {
                Console.WriteLine("Capture el nombre.");
                trabajador.Nombre = Console.ReadLine();
                Console.WriteLine("Capture los días trabjados.");
                trabajador.DiasTrabajados = int.Parse(Console.ReadLine());
                Console.WriteLine("Capture el sueldo diario.");
                trabajador.SueldoDiario = decimal.Parse(Console.ReadLine());
            }
            catch 
            {

                Console.WriteLine("Ocurrió un error, revise la información capturada.");
                Console.WriteLine("Fin del programa.");
                return;
            }

            trabajador.SueldoSemanal = trabajador.DiasTrabajados * trabajador.SueldoDiario;

            Console.WriteLine($"El sueldo de {trabajador.Nombre} por {trabajador.DiasTrabajados} días es {trabajador.SueldoSemanal}.");
            Console.WriteLine("Presione cualquier tecla para terminar.");
            Console.ReadKey();
        }
    }

    public class Trabajador
    {
        public string Nombre { get; set; }
        public decimal SueldoDiario { get; set; }
        public int DiasTrabajados { get; set; }
        public decimal SueldoSemanal { get; set; }
    }
}
