using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Dsw2026Ex01.Domain;

public class Viaje
{
    public DateTime Partida { get; set; }
    public DateTime Llegada { get; set; }
    public Ciudad? Origen { get; set; }
    public Ciudad? Destino { get; set; }
    public Vehiculo? Vehiculo { get; set; }
    public List<Carga> Cargas { get; } = [];
    public int Bultos => Cargas.Count;

    public double GetPesoTotal()
    {
        var total = 0D;
        foreach (var item in Cargas)
        {
            total += item.Peso;
        }
        return total;
    }

    public void AgregarCarga(Carga carga)
    {
        Cargas.Add(carga);
    }
}