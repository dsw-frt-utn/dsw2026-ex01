using Dsw2026Ex01.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dsw2026Ex01.Views
{
    public partial class ListarVehiculosView : Form
    {
        private Controlador? _controlador = null;
        public ListarVehiculosView()
        {
            InitializeComponent();
            //_controlador = new Controlador();
            _controlador.ListarVehiculos();
        }

        public void ListarVehiculos(List<VehiculoViewModel> vehiculos)
        {
            vehiculoViewModelBindingSource.DataSource = vehiculos;
        }

        public void MostrarConsumos(double electricos, double combustible)
        {
            lblTotalCombustible.Text = $"{combustible:N2}";
            lblTotalElectricos.Text = $"{electricos:N2}";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var vehiculos = vehiculoViewModelBindingSource.List as List<VehiculoViewModel> ?? [];
            var vehiculosDict = new Dictionary<string, double>();
            foreach(var vehiculo in vehiculos)
            {
                vehiculosDict.Add(vehiculo.Patente, vehiculo.KmARecorrer);
            }
            _controlador.CalcularConsumos(vehiculosDict);
        }
    }
}
