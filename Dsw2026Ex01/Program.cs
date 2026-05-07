using Dsw2026Ex01.Data;
using Dsw2026Ex01.Domain;
using Dsw2026Ex01.Services;

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
            DemostrarProblemaValidador();
        }

        static void DemostrarProblemaValidador()
        {
            Console.WriteLine("\n╔═══════════════════════════════════════════════════════════╗");
            Console.WriteLine("║   PROBLEMA: VALIDACIÓN DE MÚLTIPLES OBJETOS               ║");
            Console.WriteLine("╚═══════════════════════════════════════════════════════════╝\n");

            var validador = new Validador();
            var vehiculos = Persistencia.GetVehiculos();

            // Obtener algunos objetos para validar
            var v1 = vehiculos[0];
            var v2 = vehiculos[1];
            var sucursal = v1.Sucursal;
            var responsable = sucursal.Responsable;

            Console.WriteLine("═══════════════════════════════════════════════════════════");
            Console.WriteLine("EJEMPLO 1: Validar objetos de diferentes tipos mezclados");
            Console.WriteLine("═══════════════════════════════════════════════════════════\n");

            var errores1 = validador.ValidarMultiplesObjetos(v1, sucursal, responsable, v2);
            Console.WriteLine(validador.GenerarReporte(errores1));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            Console.WriteLine("\n═══════════════════════════════════════════════════════════");
            Console.WriteLine("EJEMPLO 2: ¿Qué pasa si agregamos un tipo no soportado?");
            Console.WriteLine("═══════════════════════════════════════════════════════════\n");

            var errores2 = validador.ValidarMultiplesObjetos(v1, "esto es un string", responsable);
            Console.WriteLine(validador.GenerarReporte(errores2));
            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();

            Console.WriteLine("\n═══════════════════════════════════════════════════════════");
            Console.WriteLine("EJEMPLO 3: Validar con datos inválidos");
            Console.WriteLine("═══════════════════════════════════════════════════════════\n");

            // Crear objetos con datos inválidos para mostrar validación
            var vehiculoInvalido = new VehiculoElectrico(
                patente: "AB", // Patente muy corta
                marca: "", // Marca vacía
                modelo: "Modelo",
                anio: 1800, // Año inválido
                capacidadCarga: -100, // Capacidad negativa
                sucursal: sucursal,
                kwhBase: 15
            );

            var responsableInvalido = new Responsable(
                nombre: "", // Nombre vacío
                documento: "123", // Documento muy corto
                telefono: "123" // Teléfono muy corto
            );

            var errores3 = validador.ValidarMultiplesObjetos(vehiculoInvalido, responsableInvalido);
            Console.WriteLine(validador.GenerarReporte(errores3));

            Console.WriteLine("Presiona Enter para finalizar...");
            Console.ReadLine();
        }
    }
}
