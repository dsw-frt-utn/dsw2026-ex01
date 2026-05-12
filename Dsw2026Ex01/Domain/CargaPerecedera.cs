using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ex01.Domain;

public class CargaPerecedera
{
    public string Codigo { get; set; } = string.Empty;
    public string? De { get; set; }
    public string? Para { get; set; }
    public double Peso { get; set; }
    public double TemperaturaMaxima { get; set; }
    public double TemperaturaMinima { get; set; }
}
