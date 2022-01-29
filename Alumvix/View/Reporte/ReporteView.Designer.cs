namespace Alumvix.View.Reporte
{
    partial class ReporteView
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
            this.gbPeriodicidad = new System.Windows.Forms.GroupBox();
            this.rbRangoDeFechas = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.pnlReporteGeneral = new System.Windows.Forms.Panel();
            this.lblTituloInformacionReporte = new System.Windows.Forms.Label();
            this.lblUtilidadGeneral = new System.Windows.Forms.Label();
            this.txtUtilidadGeneral = new System.Windows.Forms.TextBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            this.btnConsultarReporte = new System.Windows.Forms.Button();
            this.lblTituloReporteGeneral = new System.Windows.Forms.Label();
            this.dtpFechaFinalReporte = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicioReporte = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicioReporte = new System.Windows.Forms.Label();
            this.lblFechaFinalReporte = new System.Windows.Forms.Label();
            this.cbSeleccionarMes = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarMes = new System.Windows.Forms.Label();
            this.lblSeleccionarAnio = new System.Windows.Forms.Label();
            this.cbSeleccionarAnio = new System.Windows.Forms.ComboBox();
            this.btnDetalleDeGastos = new System.Windows.Forms.Button();
            this.gbPeriodicidad.SuspendLayout();
            this.pnlReporteGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeriodicidad
            // 
            this.gbPeriodicidad.Controls.Add(this.rbRangoDeFechas);
            this.gbPeriodicidad.Controls.Add(this.rbAnual);
            this.gbPeriodicidad.Controls.Add(this.rbMensual);
            this.gbPeriodicidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodicidad.Location = new System.Drawing.Point(21, 74);
            this.gbPeriodicidad.Name = "gbPeriodicidad";
            this.gbPeriodicidad.Size = new System.Drawing.Size(601, 64);
            this.gbPeriodicidad.TabIndex = 0;
            this.gbPeriodicidad.TabStop = false;
            this.gbPeriodicidad.Text = "PERIODICIDAD";
            // 
            // rbRangoDeFechas
            // 
            this.rbRangoDeFechas.AutoSize = true;
            this.rbRangoDeFechas.Location = new System.Drawing.Point(409, 24);
            this.rbRangoDeFechas.Name = "rbRangoDeFechas";
            this.rbRangoDeFechas.Size = new System.Drawing.Size(189, 24);
            this.rbRangoDeFechas.TabIndex = 2;
            this.rbRangoDeFechas.TabStop = true;
            this.rbRangoDeFechas.Text = "Por rango de fechas";
            this.rbRangoDeFechas.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(223, 24);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(73, 24);
            this.rbAnual.TabIndex = 1;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(15, 24);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(94, 24);
            this.rbMensual.TabIndex = 0;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // pnlReporteGeneral
            // 
            this.pnlReporteGeneral.Controls.Add(this.btnDetalleDeGastos);
            this.pnlReporteGeneral.Controls.Add(this.lblTituloInformacionReporte);
            this.pnlReporteGeneral.Controls.Add(this.lblUtilidadGeneral);
            this.pnlReporteGeneral.Controls.Add(this.txtUtilidadGeneral);
            this.pnlReporteGeneral.Controls.Add(this.lblTotalGastos);
            this.pnlReporteGeneral.Controls.Add(this.txtTotalGastos);
            this.pnlReporteGeneral.Controls.Add(this.lblTotalVentas);
            this.pnlReporteGeneral.Controls.Add(this.txtTotalVentas);
            this.pnlReporteGeneral.Controls.Add(this.lblTotalClientes);
            this.pnlReporteGeneral.Controls.Add(this.txtCantidadClientes);
            this.pnlReporteGeneral.Location = new System.Drawing.Point(21, 258);
            this.pnlReporteGeneral.Name = "pnlReporteGeneral";
            this.pnlReporteGeneral.Size = new System.Drawing.Size(904, 189);
            this.pnlReporteGeneral.TabIndex = 44;
            // 
            // lblTituloInformacionReporte
            // 
            this.lblTituloInformacionReporte.AutoSize = true;
            this.lblTituloInformacionReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInformacionReporte.Location = new System.Drawing.Point(23, 23);
            this.lblTituloInformacionReporte.Name = "lblTituloInformacionReporte";
            this.lblTituloInformacionReporte.Size = new System.Drawing.Size(285, 29);
            this.lblTituloInformacionReporte.TabIndex = 44;
            this.lblTituloInformacionReporte.Text = "Información de reporte:";
            // 
            // lblUtilidadGeneral
            // 
            this.lblUtilidadGeneral.AutoSize = true;
            this.lblUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadGeneral.Location = new System.Drawing.Point(510, 136);
            this.lblUtilidadGeneral.Name = "lblUtilidadGeneral";
            this.lblUtilidadGeneral.Size = new System.Drawing.Size(165, 24);
            this.lblUtilidadGeneral.TabIndex = 28;
            this.lblUtilidadGeneral.Text = "Utilidad General:";
            // 
            // txtUtilidadGeneral
            // 
            this.txtUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadGeneral.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtUtilidadGeneral.Location = new System.Drawing.Point(681, 136);
            this.txtUtilidadGeneral.Name = "txtUtilidadGeneral";
            this.txtUtilidadGeneral.Size = new System.Drawing.Size(198, 29);
            this.txtUtilidadGeneral.TabIndex = 29;
            this.txtUtilidadGeneral.Text = "***************";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(514, 76);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(161, 24);
            this.lblTotalGastos.TabIndex = 26;
            this.lblTotalGastos.Text = "Total de Gastos:";
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGastos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalGastos.Location = new System.Drawing.Point(681, 76);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(198, 29);
            this.txtTotalGastos.TabIndex = 27;
            this.txtTotalGastos.Text = "***************";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(71, 128);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(162, 24);
            this.lblTotalVentas.TabIndex = 24;
            this.lblTotalVentas.Text = "Total de Ventas:";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalVentas.Location = new System.Drawing.Point(239, 128);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(198, 29);
            this.txtTotalVentas.TabIndex = 25;
            this.txtTotalVentas.Text = "***************";
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalClientes.Location = new System.Drawing.Point(24, 73);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(209, 24);
            this.lblTotalClientes.TabIndex = 21;
            this.lblTotalClientes.Text = "Cantidad de Clientes:";
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadClientes.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCantidadClientes.Location = new System.Drawing.Point(239, 73);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.Size = new System.Drawing.Size(198, 29);
            this.txtCantidadClientes.TabIndex = 22;
            this.txtCantidadClientes.Text = "***************";
            // 
            // btnConsultarReporte
            // 
            this.btnConsultarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReporte.Location = new System.Drawing.Point(648, 91);
            this.btnConsultarReporte.Name = "btnConsultarReporte";
            this.btnConsultarReporte.Size = new System.Drawing.Size(117, 38);
            this.btnConsultarReporte.TabIndex = 45;
            this.btnConsultarReporte.Text = "Consultar";
            this.btnConsultarReporte.UseVisualStyleBackColor = true;
            // 
            // lblTituloReporteGeneral
            // 
            this.lblTituloReporteGeneral.AutoSize = true;
            this.lblTituloReporteGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporteGeneral.Location = new System.Drawing.Point(321, 18);
            this.lblTituloReporteGeneral.Name = "lblTituloReporteGeneral";
            this.lblTituloReporteGeneral.Size = new System.Drawing.Size(298, 31);
            this.lblTituloReporteGeneral.TabIndex = 23;
            this.lblTituloReporteGeneral.Text = "REPORTE GENERAL";
            // 
            // dtpFechaFinalReporte
            // 
            this.dtpFechaFinalReporte.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaFinalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinalReporte.Location = new System.Drawing.Point(511, 155);
            this.dtpFechaFinalReporte.Name = "dtpFechaFinalReporte";
            this.dtpFechaFinalReporte.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaFinalReporte.TabIndex = 46;
            // 
            // dtpFechaInicioReporte
            // 
            this.dtpFechaInicioReporte.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaInicioReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicioReporte.Location = new System.Drawing.Point(196, 155);
            this.dtpFechaInicioReporte.Name = "dtpFechaInicioReporte";
            this.dtpFechaInicioReporte.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaInicioReporte.TabIndex = 47;
            // 
            // lblFechaInicioReporte
            // 
            this.lblFechaInicioReporte.AutoSize = true;
            this.lblFechaInicioReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioReporte.Location = new System.Drawing.Point(55, 157);
            this.lblFechaInicioReporte.Name = "lblFechaInicioReporte";
            this.lblFechaInicioReporte.Size = new System.Drawing.Size(135, 24);
            this.lblFechaInicioReporte.TabIndex = 48;
            this.lblFechaInicioReporte.Text = "Fecha Inicial:";
            // 
            // lblFechaFinalReporte
            // 
            this.lblFechaFinalReporte.AutoSize = true;
            this.lblFechaFinalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalReporte.Location = new System.Drawing.Point(378, 155);
            this.lblFechaFinalReporte.Name = "lblFechaFinalReporte";
            this.lblFechaFinalReporte.Size = new System.Drawing.Size(127, 24);
            this.lblFechaFinalReporte.TabIndex = 49;
            this.lblFechaFinalReporte.Text = "Fecha Final:";
            // 
            // cbSeleccionarMes
            // 
            this.cbSeleccionarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarMes.FormattingEnabled = true;
            this.cbSeleccionarMes.Location = new System.Drawing.Point(233, 197);
            this.cbSeleccionarMes.Name = "cbSeleccionarMes";
            this.cbSeleccionarMes.Size = new System.Drawing.Size(145, 28);
            this.cbSeleccionarMes.TabIndex = 50;
            // 
            // lblSeleccionarMes
            // 
            this.lblSeleccionarMes.AutoSize = true;
            this.lblSeleccionarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarMes.Location = new System.Drawing.Point(55, 197);
            this.lblSeleccionarMes.Name = "lblSeleccionarMes";
            this.lblSeleccionarMes.Size = new System.Drawing.Size(172, 24);
            this.lblSeleccionarMes.TabIndex = 51;
            this.lblSeleccionarMes.Text = "Seleccionar mes:";
            // 
            // lblSeleccionarAnio
            // 
            this.lblSeleccionarAnio.AutoSize = true;
            this.lblSeleccionarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarAnio.Location = new System.Drawing.Point(426, 197);
            this.lblSeleccionarAnio.Name = "lblSeleccionarAnio";
            this.lblSeleccionarAnio.Size = new System.Drawing.Size(171, 24);
            this.lblSeleccionarAnio.TabIndex = 53;
            this.lblSeleccionarAnio.Text = "Seleccionar Año:";
            // 
            // cbSeleccionarAnio
            // 
            this.cbSeleccionarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarAnio.FormattingEnabled = true;
            this.cbSeleccionarAnio.Location = new System.Drawing.Point(603, 193);
            this.cbSeleccionarAnio.Name = "cbSeleccionarAnio";
            this.cbSeleccionarAnio.Size = new System.Drawing.Size(145, 28);
            this.cbSeleccionarAnio.TabIndex = 52;
            // 
            // btnDetalleDeGastos
            // 
            this.btnDetalleDeGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleDeGastos.Location = new System.Drawing.Point(705, 23);
            this.btnDetalleDeGastos.Name = "btnDetalleDeGastos";
            this.btnDetalleDeGastos.Size = new System.Drawing.Size(174, 38);
            this.btnDetalleDeGastos.TabIndex = 46;
            this.btnDetalleDeGastos.Text = "Detalle de Gastos";
            this.btnDetalleDeGastos.UseVisualStyleBackColor = true;
            // 
            // ReporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 466);
            this.Controls.Add(this.lblSeleccionarAnio);
            this.Controls.Add(this.cbSeleccionarAnio);
            this.Controls.Add(this.lblSeleccionarMes);
            this.Controls.Add(this.cbSeleccionarMes);
            this.Controls.Add(this.lblFechaFinalReporte);
            this.Controls.Add(this.lblFechaInicioReporte);
            this.Controls.Add(this.dtpFechaInicioReporte);
            this.Controls.Add(this.dtpFechaFinalReporte);
            this.Controls.Add(this.btnConsultarReporte);
            this.Controls.Add(this.pnlReporteGeneral);
            this.Controls.Add(this.gbPeriodicidad);
            this.Controls.Add(this.lblTituloReporteGeneral);
            this.Name = "ReporteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General";
            this.gbPeriodicidad.ResumeLayout(false);
            this.gbPeriodicidad.PerformLayout();
            this.pnlReporteGeneral.ResumeLayout(false);
            this.pnlReporteGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPeriodicidad;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.RadioButton rbRangoDeFechas;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.Panel pnlReporteGeneral;
        public System.Windows.Forms.Button btnConsultarReporte;
        public System.Windows.Forms.Label lblTituloInformacionReporte;
        public System.Windows.Forms.Label lblUtilidadGeneral;
        public System.Windows.Forms.TextBox txtUtilidadGeneral;
        public System.Windows.Forms.Label lblTotalGastos;
        public System.Windows.Forms.TextBox txtTotalGastos;
        public System.Windows.Forms.Label lblTotalVentas;
        public System.Windows.Forms.TextBox txtTotalVentas;
        public System.Windows.Forms.Label lblTotalClientes;
        public System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.Label lblTituloReporteGeneral;
        public System.Windows.Forms.DateTimePicker dtpFechaFinalReporte;
        public System.Windows.Forms.DateTimePicker dtpFechaInicioReporte;
        private System.Windows.Forms.Label lblFechaInicioReporte;
        private System.Windows.Forms.Label lblFechaFinalReporte;
        public System.Windows.Forms.ComboBox cbSeleccionarMes;
        private System.Windows.Forms.Label lblSeleccionarMes;
        private System.Windows.Forms.Label lblSeleccionarAnio;
        public System.Windows.Forms.ComboBox cbSeleccionarAnio;
        public System.Windows.Forms.Button btnDetalleDeGastos;
    }
}