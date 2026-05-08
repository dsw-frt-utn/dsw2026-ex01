using Dsw2026Ex01.Data;
using Dsw2026Ex01.Domain;

namespace Dsw2026Ex01.Views;

public class Controlador
{
    private readonly ConsoleView _vista;

    public Controlador(ConsoleView vista)
    {
        _vista = vista;
    }

    //Solo para ejemplificar params arrays
    public void AgregarChoferes()
    {
        var sucursal = Persistencia.GetSucursales()[0];
        var electrico = new VehiculoElectrico("AA000AA", "Ford", "E-Transit", 2021, 1200, sucursal, 14);
        var choferes = new[] { "Juan", "Luis", "Pedro" };
        electrico.AgregarChoferes(choferes);
    }

    public void ListarVehiculos()
    {
        List<VehiculoViewModel> vehiculos = [];
        foreach (Vehiculo vehiculo in Persistencia.GetVehiculos())
        {
            vehiculos.Add(new VehiculoViewModel(vehiculo));
        }
        _vista.ListarVehiculos(vehiculos);
    }

    public void CalcularConsumos(Dictionary<string, double> vehiculos)
    {
        double consumoElectricos = 0;
        double consumoCombustible = 0;
        foreach (KeyValuePair<string, double> entry in vehiculos)
        {
            double consumo = 0;
            Vehiculo? vehiculo = Persistencia.GetVehiculo(entry.Key);
            if (vehiculo != null)
            {
                consumo = vehiculo.CalcularConsumo(entry.Value);
                consumoElectricos += vehiculo.EsDe(VehiculoTipo.Electrico) ? consumo : 0;
                consumoCombustible += vehiculo.EsDe(VehiculoTipo.Combustible) ? consumo : 0;
            }
        }
        _vista.MostrarConsumos(consumoElectricos, consumoCombustible);
    }
}
