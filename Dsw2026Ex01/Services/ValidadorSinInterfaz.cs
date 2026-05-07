namespace Dsw2026Ex01.Services;
using Dsw2026Ex01.Domain;

public class Validador
{
    /// <summary>
    /// Valida múltiples objetos de diferentes tipos.
    /// </summary>
    public List<string> ValidarMultiplesObjetos(params object[] objetos)
    {
        var errores = new List<string>();

        if (objetos == null || objetos.Length == 0)
        {
            errores.Add("No se proporcionaron objetos para validar");
            return errores;
        }

        foreach (var obj in objetos)
        {
            if (obj is Vehiculo vehiculo)
            {
                var erroresVehiculo = ValidarVehiculo(vehiculo);
                if (erroresVehiculo.Count > 0)
                {
                    errores.Add($"[Vehículo {vehiculo.Patente}]:");
                    errores.AddRange(erroresVehiculo);
                }
            }
            else if (obj is Sucursal sucursal)
            {
                var erroresSucursal = ValidarSucursal(sucursal);
                if (erroresSucursal.Count > 0)
                {
                    errores.Add($"[Sucursal {sucursal.Codigo}]:");
                    errores.AddRange(erroresSucursal);
                }
            }
            else if (obj is Responsable responsable)
            {
                var erroresResponsable = ValidarResponsable(responsable);
                if (erroresResponsable.Count > 0)
                {
                    errores.Add($"[Responsable {responsable.Nombre}]:");
                    errores.AddRange(erroresResponsable);
                }
            }
            else
            {
                errores.Add($"Tipo no soportado: {obj.GetType().Name}");
            }
        }
        return errores;
    }

    private List<string> ValidarVehiculo(Vehiculo vehiculo)
    {
        var errores = new List<string>();

        if (string.IsNullOrWhiteSpace(vehiculo.Patente))
        {
            errores.Add("Patente no puede estar vacía");
        }
        else if (vehiculo.Patente.Length < 6)
        {
            errores.Add("Patente debe tener al menos 6 caracteres");
        }

        if (vehiculo.Anio < 1950 || vehiculo.Anio > DateTime.Now.Year + 1)
        {
            errores.Add($"Año inválido: {vehiculo.Anio} (debe estar entre 1950 y {DateTime.Now.Year + 1})");
        }

        if (vehiculo.CapacidadCarga <= 0)
        {
            errores.Add($"Capacidad de carga debe ser mayor a 0");
        }

        if (string.IsNullOrWhiteSpace(vehiculo.Marca))
        {
            errores.Add("Marca no puede estar vacía");
        }

        if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
        {
            errores.Add("Modelo no puede estar vacío");
        }

        return errores;
    }

    private List<string> ValidarSucursal(Sucursal sucursal)
    {
        var errores = new List<string>();

        if (string.IsNullOrWhiteSpace(sucursal.Codigo))
        {
            errores.Add("Código no puede estar vacío");
        }
        else if (sucursal.Codigo.Length < 5)
        {
            errores.Add("Código debe tener al menos 5 caracteres");
        }

        if (string.IsNullOrWhiteSpace(sucursal.Direccion))
        {
            errores.Add("Dirección no puede estar vacía");
        }

        if (string.IsNullOrWhiteSpace(sucursal.Ciudad))
        {
            errores.Add("Ciudad no puede estar vacía");
        }

        if (sucursal.Responsable == null)
        {
            errores.Add("La sucursal debe tener un responsable asignado");
        }

        return errores;
    }

    private List<string> ValidarResponsable(Responsable responsable)
    {
        var errores = new List<string>();

        if (string.IsNullOrWhiteSpace(responsable.Nombre))
        {
            errores.Add("Nombre no puede estar vacío");
        }

        if (string.IsNullOrWhiteSpace(responsable.Documento))
        {
            errores.Add("Documento no puede estar vacío");
        }
        else if (!EsDocumentoValido(responsable.Documento))
        {
            errores.Add($"Documento inválido: {responsable.Documento} (debe ser numérico y entre 7-8 dígitos)");
        }

        if (string.IsNullOrWhiteSpace(responsable.Telefono))
        {
            errores.Add("Teléfono no puede estar vacío");
        }
        else if (responsable.Telefono.Length < 10)
        {
            errores.Add("Teléfono debe tener al menos 10 dígitos");
        }

        return errores;
    }

    private bool EsDocumentoValido(string documento)
    {
        // Validación simple: solo números, entre 7 y 8 dígitos
        return documento.All(char.IsDigit) && documento.Length >= 7 && documento.Length <= 8;
    }

    /// <summary>
    /// Genera un reporte de validación.
    /// </summary>
    public string GenerarReporte(List<string> errores)
    {
        if (errores.Count == 0)
        {
            return "TODOS LOS OBJETOS SON VÁLIDOS";
        }

        string reporte = $"SE ENCONTRARON {errores.Count} ERROR(ES)\n\n";
        foreach (var error in errores)
        {
            reporte += $"{error}\n";
        }
        return reporte;
    }
}
