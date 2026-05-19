using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ex01.Domain;

internal delegate int Operacion(int numero1, int numero2);

internal class Operaciones
{
    public int Sumar(int numero1, int numero2)
    {
        return numero1 + numero2;
    }

    public int RealizarOperacion(Operacion operacion)
    {
        return operacion(10, 2);
    }
}
