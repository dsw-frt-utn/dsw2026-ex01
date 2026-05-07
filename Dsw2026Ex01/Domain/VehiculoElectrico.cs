using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ex1.Domain;

public class VehiculoElectrico : Vehiculo
{
    public double KwhBase { get; init; }

    public VehiculoElectrico(string patente, string marca, string modelo, int anio, double capacidadCarga, 
        Sucursal sucursal, double kwhBase) : base(VehiculoTipo.Electrico, patente, marca, modelo, anio, capacidadCarga, sucursal)
    {
        KwhBase = kwhBase;
    }

    public override double CalcularConsumo(double kilometros)
    {
        double total = (kilometros / 100) * KwhBase;

        if (CapacidadCarga > 1200)
        {
            total = total * 1.15;
        }

        return total;
    }
}
