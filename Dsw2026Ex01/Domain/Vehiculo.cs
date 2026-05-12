namespace Dsw2026Ex01.Domain;

public abstract class Vehiculo : EntidadBase
{
    public string Patente { get; init; }
    public string Marca { get; init; }
    public string Modelo { get; init; }
    public int Anio { get; init; }
    public double CapacidadCarga { get; init; }
    public Sucursal Sucursal { get; init; }
    public VehiculoTipo Tipo { get; init; }
    public List<string> Choferes { get; private set; } = [];

    protected Vehiculo(VehiculoTipo tipo, string patente, string marca, string modelo, int anio, 
        double capacidadCarga, Sucursal sucursal, Guid? id = null): base(id)
    {
        Patente = patente;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        CapacidadCarga = capacidadCarga;
        Sucursal = sucursal;
        Tipo = tipo;
    }

    public abstract double CalcularConsumo(double kilometros);

    public bool EsDe(VehiculoTipo tipo)
    {
        return Tipo == tipo;
    }

    public void AgregarChoferes(string[] choferes)
    {
        foreach(var chofer in choferes)
        {
            Choferes.Add(chofer.ToUpper());
        }
    }

    public override string ToString()
    {
        return $"{Marca} {Modelo}";
    }
}
