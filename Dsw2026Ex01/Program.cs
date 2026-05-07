using Dsw2026Ex01.Data;
using Dsw2026Ex01.Domain;

namespace Dsw2026Ex01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Persistencia.InicializarDatos();
            DemostrarParamsArrays();
        }

        /// <summary>
        /// Método para demostrar el uso de params arrays con ejemplos prácticos.
        /// Puedes comentar/descomentar esta llamada en Main() según necesites.
        /// </summary>
        static void DemostrarParamsArrays()
        {
            Console.WriteLine("╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║      DEMOSTRACIÓN: PARAMS ARRAYS EN C#                    ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");

            var calculadora = new CalculadoraCostos();
            var vehiculos = Persistencia.GetVehiculos();

            // Ejemplo 1: Pasar UN solo vehículo
            Console.WriteLine("--- Ejemplo 1: Comparar UN vehículo ---");
            var v1 = vehiculos[0];
            Console.WriteLine(calculadora.CompararEficiencia(100, v1));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            // Ejemplo 2: Pasar DOS vehículos
            Console.WriteLine("\n--- Ejemplo 2: Comparar DOS vehículos ---");
            var v2 = vehiculos[1];
            Console.WriteLine(calculadora.CompararEficiencia(100, v1, v2));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            // Ejemplo 3: Pasar TODOS los vehículos
            Console.WriteLine("\n--- Ejemplo 3: Comparar TODOS los vehículos ---");
            // Aquí demostramos que podemos pasar cada vehículo como argumento individual
            Console.WriteLine(calculadora.CompararEficiencia(150, 
                vehiculos[0], vehiculos[1], vehiculos[2], vehiculos[3]));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            // Ejemplo 4: Usar un array existente (también funciona con params)
            Console.WriteLine("\n--- Ejemplo 4: Pasar un array completo ---");
            var todosLosVehiculos = Persistencia.GetVehiculos().ToArray();
            Console.WriteLine(calculadora.CompararEficiencia(200, todosLosVehiculos));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            // Ejemplo 5: Calcular consumo total
            Console.WriteLine("\n--- Ejemplo 5: Consumo total de múltiples vehículos ---");
            double consumoTotal = calculadora.CalcularConsumoTotal(100, v1, v2, vehiculos[2]);
            Console.WriteLine($"Consumo total de 3 vehículos en 100 km: {consumoTotal:F2} unidades");
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            // Ejemplo 6: Obtener el más eficiente
            Console.WriteLine("\n--- Ejemplo 6: Vehículo más eficiente ---");
            var masEficiente = calculadora.ObtenerMasEficiente(100, vehiculos[0], vehiculos[1], vehiculos[2], vehiculos[3]);
            if (masEficiente != null)
            {
                Console.WriteLine($"🏆 Vehículo más eficiente: {masEficiente.Patente} - {masEficiente}");
                Console.WriteLine($"   Consumo en 100 km: {masEficiente.CalcularConsumo(100):F2}");
            }
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            // Ejemplo 7: Resumen de flota
            Console.WriteLine("\n--- Ejemplo 7: Resumen de múltiples vehículos ---");
            Console.WriteLine(calculadora.GenerarResumen(v1, v2, vehiculos[2]));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            Console.WriteLine("\n╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║  FIN DE LA DEMOSTRACIÓN - Iniciando interfaz gráfica...   ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");
            Console.WriteLine("Presiona Enter para abrir la ventana...");
            Console.ReadLine();
        }
    }
}