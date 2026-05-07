namespace Dsw2026Ex01.Views
{
    partial class ListarVehiculosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgVehiculos = new DataGridView();
            patenteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehiculoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sucursalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacidadCargaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kmPorLitroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            litrosExtraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kmARecorrerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vehiculoViewModelBindingSource = new BindingSource(components);
            pConsumos = new Panel();
            lblTotalCombustible = new Label();
            lblTotalElectricos = new Label();
            lblCombustible = new Label();
            lblElectricos = new Label();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoViewModelBindingSource).BeginInit();
            pConsumos.SuspendLayout();
            SuspendLayout();
            // 
            // dgVehiculos
            // 
            dgVehiculos.AllowUserToAddRows = false;
            dgVehiculos.AllowUserToDeleteRows = false;
            dgVehiculos.AutoGenerateColumns = false;
            dgVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVehiculos.Columns.AddRange(new DataGridViewColumn[] { patenteDataGridViewTextBoxColumn, vehiculoDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, sucursalDataGridViewTextBoxColumn, capacidadCargaDataGridViewTextBoxColumn, kmPorLitroDataGridViewTextBoxColumn, anioDataGridViewTextBoxColumn, litrosExtraDataGridViewTextBoxColumn, kmARecorrerDataGridViewTextBoxColumn });
            dgVehiculos.DataSource = vehiculoViewModelBindingSource;
            dgVehiculos.Location = new Point(12, 12);
            dgVehiculos.Name = "dgVehiculos";
            dgVehiculos.ReadOnly = true;
            dgVehiculos.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgVehiculos.RowTemplate.Height = 30;
            dgVehiculos.Size = new Size(984, 187);
            dgVehiculos.TabIndex = 0;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            patenteDataGridViewTextBoxColumn.DataPropertyName = "Patente";
            patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            patenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            vehiculoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            vehiculoDataGridViewTextBoxColumn.HeaderText = "Vehículo";
            vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            vehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            sucursalDataGridViewTextBoxColumn.DataPropertyName = "Sucursal";
            sucursalDataGridViewTextBoxColumn.HeaderText = "Sucursal";
            sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadCargaDataGridViewTextBoxColumn
            // 
            capacidadCargaDataGridViewTextBoxColumn.DataPropertyName = "CapacidadCarga";
            capacidadCargaDataGridViewTextBoxColumn.HeaderText = "Cap.Carga";
            capacidadCargaDataGridViewTextBoxColumn.Name = "capacidadCargaDataGridViewTextBoxColumn";
            capacidadCargaDataGridViewTextBoxColumn.ReadOnly = true;
            capacidadCargaDataGridViewTextBoxColumn.Width = 85;
            // 
            // kmPorLitroDataGridViewTextBoxColumn
            // 
            kmPorLitroDataGridViewTextBoxColumn.DataPropertyName = "KmPorLitro";
            kmPorLitroDataGridViewTextBoxColumn.HeaderText = "Km/L";
            kmPorLitroDataGridViewTextBoxColumn.Name = "kmPorLitroDataGridViewTextBoxColumn";
            kmPorLitroDataGridViewTextBoxColumn.ReadOnly = true;
            kmPorLitroDataGridViewTextBoxColumn.Width = 80;
            // 
            // anioDataGridViewTextBoxColumn
            // 
            anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            anioDataGridViewTextBoxColumn.HeaderText = "Año";
            anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            anioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // litrosExtraDataGridViewTextBoxColumn
            // 
            litrosExtraDataGridViewTextBoxColumn.DataPropertyName = "LitrosExtra";
            litrosExtraDataGridViewTextBoxColumn.HeaderText = "L.Extra";
            litrosExtraDataGridViewTextBoxColumn.Name = "litrosExtraDataGridViewTextBoxColumn";
            litrosExtraDataGridViewTextBoxColumn.ReadOnly = true;
            litrosExtraDataGridViewTextBoxColumn.Width = 80;
            // 
            // kmARecorrerDataGridViewTextBoxColumn
            // 
            kmARecorrerDataGridViewTextBoxColumn.DataPropertyName = "KmARecorrer";
            kmARecorrerDataGridViewTextBoxColumn.HeaderText = "Km a Rec.";
            kmARecorrerDataGridViewTextBoxColumn.Name = "kmARecorrerDataGridViewTextBoxColumn";
            kmARecorrerDataGridViewTextBoxColumn.ReadOnly = true;
            kmARecorrerDataGridViewTextBoxColumn.Width = 85;
            // 
            // vehiculoViewModelBindingSource
            // 
            vehiculoViewModelBindingSource.DataSource = typeof(Dsw2026Ex01.Views.VehiculoViewModel);
            // 
            // pConsumos
            // 
            pConsumos.BackColor = Color.Teal;
            pConsumos.Controls.Add(this.lblTotalCombustible);
            pConsumos.Controls.Add(lblTotalElectricos);
            pConsumos.Controls.Add(lblCombustible);
            pConsumos.Controls.Add(lblElectricos);
            pConsumos.Location = new Point(328, 228);
            pConsumos.Name = "pConsumos";
            pConsumos.Size = new Size(668, 100);
            pConsumos.TabIndex = 1;
            // 
            // lblConsumoCombustible
            // 
            lblTotalCombustible.AutoSize = true;
            lblTotalCombustible.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCombustible.ForeColor = Color.White;
            lblTotalCombustible.Location = new Point(308, 60);
            lblTotalCombustible.Name = "lblConsumoCombustible";
            lblTotalCombustible.Size = new Size(71, 21);
            lblTotalCombustible.TabIndex = 3;
            lblTotalCombustible.Text = "00 Litros";
            // 
            // lblConsumoElectricos
            // 
            lblTotalElectricos.AutoSize = true;
            lblTotalElectricos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalElectricos.ForeColor = Color.White;
            lblTotalElectricos.Location = new Point(308, 24);
            lblTotalElectricos.Name = "lblConsumoElectricos";
            lblTotalElectricos.Size = new Size(63, 21);
            lblTotalElectricos.TabIndex = 2;
            lblTotalElectricos.Text = "00 KwH";
            // 
            // lblCombustible
            // 
            lblCombustible.AutoSize = true;
            lblCombustible.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCombustible.ForeColor = Color.White;
            lblCombustible.Location = new Point(27, 60);
            lblCombustible.Name = "lblCombustible";
            lblCombustible.Size = new Size(275, 21);
            lblCombustible.TabIndex = 1;
            lblCombustible.Text = "Total consumo Vehículos Combustible:";
            // 
            // lblElectricos
            // 
            lblElectricos.AutoSize = true;
            lblElectricos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblElectricos.ForeColor = Color.White;
            lblElectricos.Location = new Point(27, 24);
            lblElectricos.Name = "lblElectricos";
            lblElectricos.Size = new Size(252, 21);
            lblElectricos.TabIndex = 0;
            lblElectricos.Text = "Total consumo Vehículos Eléctricos:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.AntiqueWhite;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(88, 256);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(155, 53);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Consumos";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 388);
            Controls.Add(btnCalcular);
            Controls.Add(pConsumos);
            Controls.Add(dgVehiculos);
            Name = "FormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listar Vehículos";
            ((System.ComponentModel.ISupportInitialize)dgVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)vehiculoViewModelBindingSource).EndInit();
            pConsumos.ResumeLayout(false);
            pConsumos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgVehiculos;
        private BindingSource vehiculoViewModelBindingSource;
        private DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacidadCargaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kmPorLitroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn litrosExtraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kmARecorrerDataGridViewTextBoxColumn;
        private Panel pConsumos;
        private Label lblElectricos;
        private Button btnCalcular;
        private Label lblTotalCombustible;
        private Label lblTotalElectricos;
        private Label lblCombustible;
    }
}