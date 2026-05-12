using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ex01.Domain;

public class ViajeCargaGeneral: Viaje
{
    public new List<Carga> Cargas { get; } = [];
}

public class ViajePerecederos: Viaje
{
    public new List<CargaPerecedera> Cargas { get; } = [];
}