namespace Dsw2026Ex01.Domain;

public class CalculadoraCostos
{
    /// <summary>
    /// Calcula el consumo total de múltiples vehículos para una distancia determinada.
    /// Ejemplo de uso de params: permite pasar 1, 2, 3... o N vehículos como argumentos individuales.
    /// </summary>
    public double CalcularConsumoTotal(double kilometros, params Vehiculo[] vehiculos)
    {
        if (vehiculos == null || vehiculos.Length == 0)
        {
            return 0;
        }

        double consumoTotal = 0;
        foreach (var vehiculo in vehiculos)
        {
            consumoTotal += vehiculo.CalcularConsumo(kilometros);
        }
        return consumoTotal;
    }

    /// <summary>
    /// Compara la eficiencia de múltiples vehículos y retorna un reporte detallado.
    /// Demuestra cómo params simplifica pasar cantidades variables de parámetros.
    /// </summary>
    public string CompararEficiencia(double kilometros, params Vehiculo[] vehiculos)
    {
        if (vehiculos == null || vehiculos.Length == 0)
        {
            return "No hay vehículos para comparar.";
        }

        if (vehiculos.Length == 1)
        {
            double consumo = vehiculos[0].CalcularConsumo(kilometros);
            return $"Vehículo único: {vehiculos[0].Patente} - {vehiculos[0]}\n" +
                   $"Consumo para {kilometros} km: {consumo:F2} {ObtenerUnidadConsumo(vehiculos[0])}";
        }

        var resultados = new List<(Vehiculo vehiculo, double consumo)>();

        foreach (var vehiculo in vehiculos)
        {
            double consumo = vehiculo.CalcularConsumo(kilometros);
            resultados.Add((vehiculo, consumo));
        }

        // Ordenar por consumo (menor a mayor = más eficiente)
        resultados = resultados.OrderBy(r => r.consumo).ToList();

        string reporte = $"=== COMPARACIÓN DE EFICIENCIA ({kilometros} km) ===\n\n";

        for (int i = 0; i < resultados.Count; i++)
        {
            var (vehiculo, consumo) = resultados[i];
            string medalla = i == 0 ? "🥇 MÁS EFICIENTE" : i == resultados.Count - 1 ? "❌ MENOS EFICIENTE" : "";

            reporte += $"{i + 1}. {vehiculo.Patente} - {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.Tipo})\n";
            reporte += $"   Consumo: {consumo:F2} {ObtenerUnidadConsumo(vehiculo)} {medalla}\n";
            reporte += $"   Sucursal: {vehiculo.Sucursal.Ciudad}\n\n";
        }

        // Calcular diferencia entre el más y menos eficiente
        double diferencia = resultados.Last().consumo - resultados.First().consumo;
        double porcentaje = (diferencia / resultados.First().consumo) * 100;

        reporte += $"💡 El vehículo más eficiente consume {diferencia:F2} unidades menos ";
        reporte += $"(ahorro del {porcentaje:F1}%)";

        return reporte;
    }

    /// <summary>
    /// Encuentra el vehículo más económico de entre varios para un recorrido.
    /// Otro ejemplo práctico de params.
    /// </summary>
    public Vehiculo? ObtenerMasEficiente(double kilometros, params Vehiculo[] vehiculos)
    {
        if (vehiculos == null || vehiculos.Length == 0)
        {
            return null;
        }

        Vehiculo? masEficiente = null;
        double menorConsumo = double.MaxValue;

        foreach (var vehiculo in vehiculos)
        {
            double consumo = vehiculo.CalcularConsumo(kilometros);
            if (consumo < menorConsumo)
            {
                menorConsumo = consumo;
                masEficiente = vehiculo;
            }
        }

        return masEficiente;
    }

    /// <summary>
    /// Calcula el costo estimado para múltiples vehículos.
    /// </summary>
    public double CalcularCostoTotal(double kilometros, double precioUnitario, params Vehiculo[] vehiculos)
    {
        double consumoTotal = CalcularConsumoTotal(kilometros, vehiculos);
        return consumoTotal * precioUnitario;
    }

    /// <summary>
    /// Genera un resumen rápido de múltiples vehículos.
    /// </summary>
    public string GenerarResumen(params Vehiculo[] vehiculos)
    {
        if (vehiculos == null || vehiculos.Length == 0)
        {
            return "No hay vehículos para resumir.";
        }

        int electricos = vehiculos.Count(v => v.Tipo == VehiculoTipo.Electrico);
        int combustible = vehiculos.Count(v => v.Tipo == VehiculoTipo.Combustible);

        string resumen = $"=== RESUMEN DE FLOTA ===\n";
        resumen += $"Total de vehículos: {vehiculos.Length}\n";
        resumen += $"Eléctricos: {electricos}\n";
        resumen += $"Combustible: {combustible}\n\n";
        resumen += "Detalle:\n";

        foreach (var vehiculo in vehiculos)
        {
            resumen += $"- {vehiculo.Patente}: {vehiculo} [{vehiculo.Tipo}]\n";
        }

        return resumen;
    }

    private string ObtenerUnidadConsumo(Vehiculo vehiculo)
    {
        return vehiculo.Tipo == VehiculoTipo.Electrico ? "kWh" : "litros";
    }
}
