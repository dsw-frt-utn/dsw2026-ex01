using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ex01.Domain;

public class CargaPerecedera : Carga
{
    public double TemperaturaMaxima { get; set; }
    public double TemperaturaMinima { get; set; }
}
