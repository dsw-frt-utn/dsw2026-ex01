using Dsw2026Ex01.Data;
using Dsw2026Ex01.Domain;
using Dsw2026Ex01.Views;

namespace Dsw2026Ex01
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            Persistencia.InicializarDatos();

            var vehiculo = Persistencia.GetEntidad<Vehiculo>(new Guid("B3BBB9CA-072F-47A2-8CA1-A0105B155BF9"));
            Console.WriteLine("Vehículo Patente: {0}", vehiculo?.Patente);

            #region Escenario 0
            //Console.WriteLine("Escenario #0: Crear nuevo viaje");
            //var viaje = new Viaje
            //{
            //    Vehiculo = Persistencia.GetVehiculos()[0]
            //};
            //viaje.AgregarCarga(new Carga { Peso = 5 });
            //viaje.AgregarCarga(new Carga { Peso = 3 });
            //Console.WriteLine("Cantidad de bultos: {0}", viaje.Bultos);
            //Console.WriteLine("Peso total: {0}", viaje.GetPesoTotal());
            #endregion

            #region Escenario 1
            //Console.WriteLine("Escenario #1: Crear nuevo viaje");
            //var viaje = new Viaje
            //{
            //    Vehiculo = Persistencia.GetVehiculos()[0]
            //};
            //viaje.AgregarCarga(new Carga { Peso = 5 });
            //viaje.AgregarCarga(new CargaPerecedera { Peso = 3 });
            //Console.WriteLine("Cantidad de bultos: {0}", viaje.Bultos);
            //Console.WriteLine("Peso total: {0}", viaje.GetPesoTotal());
            #endregion

            #region Escenario 2
            //Console.WriteLine("Escenario #2: Crear nuevo viaje");
            //var viaje = new Viaje
            //{
            //    Vehiculo = Persistencia.GetVehiculos()[0]
            //};
            //viaje.AgregarCarga(new Carga { Peso = 5 });
            //viaje.AgregarCarga(new Carga { Peso = 3 });

            //Console.WriteLine("Cantidad de bultos: {0}", viaje.Bultos);
            //Console.WriteLine("Peso total: {0}", viaje.GetPesoTotal());
            #endregion

            #region Escenario 3
            //Console.WriteLine("Escenario #3: Crear nuevo viaje");
            //var viaje = new Viaje<>
            //{
            //    Vehiculo = Persistencia.GetVehiculos()[0]
            //};
            //viaje.AgregarCarga(new CargaPerecedera { Peso = 5 });
            //viaje.AgregarCarga(new CargaPerecedera { Peso = 3 });

            //Console.WriteLine("Cantidad de bultos: {0}", viaje.Bultos);
            //Console.WriteLine("Peso total: {0}", viaje.GetPesoTotal());
            #endregion

            Console.ReadLine();
        }
    }
}