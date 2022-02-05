namespace Alumvix.View.Reporte
{
    partial class ReporteAnualView
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
            this.lstvGastosTotalesMensuales = new System.Windows.Forms.ListView();
            this.columnaTipoGastoPeriodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTituloGastosDelMes = new System.Windows.Forms.GroupBox();
            this.lblTotalContratos = new System.Windows.Forms.Label();
            this.txtCantidadContratos = new System.Windows.Forms.TextBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.lblUtilidadGeneral = new System.Windows.Forms.Label();
            this.txtUtilidadGeneral = new System.Windows.Forms.TextBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.btnDetalleGastos = new System.Windows.Forms.Button();
            this.lblTituloReporteAnual = new System.Windows.Forms.Label();
            this.lstvReporteMensualPorAnio = new System.Windows.Forms.ListView();
            this.columnaMes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalVentas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalGastos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaUtilidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTituloGastosDelMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstvGastosTotalesMensuales
            // 
            this.lstvGastosTotalesMensuales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGastoPeriodo,
            this.columnaTotalGasto});
            this.lstvGastosTotalesMensuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosTotalesMensuales.FullRowSelect = true;
            this.lstvGastosTotalesMensuales.HideSelection = false;
            this.lstvGastosTotalesMensuales.Location = new System.Drawing.Point(791, 125);
            this.lstvGastosTotalesMensuales.MultiSelect = false;
            this.lstvGastosTotalesMensuales.Name = "lstvGastosTotalesMensuales";
            this.lstvGastosTotalesMensuales.Size = new System.Drawing.Size(376, 434);
            this.lstvGastosTotalesMensuales.TabIndex = 53;
            this.lstvGastosTotalesMensuales.UseCompatibleStateImageBehavior = false;
            this.lstvGastosTotalesMensuales.View = System.Windows.Forms.View.Details;
            // 
            // columnaTipoGastoPeriodo
            // 
            this.columnaTipoGastoPeriodo.Text = "Tipo de gasto";
            this.columnaTipoGastoPeriodo.Width = 223;
            // 
            // columnaTotalGasto
            // 
            this.columnaTotalGasto.Text = "Total";
            this.columnaTotalGasto.Width = 141;
            // 
            // gbTituloGastosDelMes
            // 
            this.gbTituloGastosDelMes.Controls.Add(this.lblTotalContratos);
            this.gbTituloGastosDelMes.Controls.Add(this.txtCantidadContratos);
            this.gbTituloGastosDelMes.Controls.Add(this.lblTotalGastos);
            this.gbTituloGastosDelMes.Controls.Add(this.txtTotalVentas);
            this.gbTituloGastosDelMes.Controls.Add(this.txtTotalGastos);
            this.gbTituloGastosDelMes.Controls.Add(this.lblUtilidadGeneral);
            this.gbTituloGastosDelMes.Controls.Add(this.txtUtilidadGeneral);
            this.gbTituloGastosDelMes.Controls.Add(this.lblTotalVentas);
            this.gbTituloGastosDelMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTituloGastosDelMes.Location = new System.Drawing.Point(14, 86);
            this.gbTituloGastosDelMes.Name = "gbTituloGastosDelMes";
            this.gbTituloGastosDelMes.Size = new System.Drawing.Size(757, 191);
            this.gbTituloGastosDelMes.TabIndex = 52;
            this.gbTituloGastosDelMes.TabStop = false;
            this.gbTituloGastosDelMes.Text = "Datos del año";
            // 
            // lblTotalContratos
            // 
            this.lblTotalContratos.AutoSize = true;
            this.lblTotalContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContratos.Location = new System.Drawing.Point(22, 67);
            this.lblTotalContratos.Name = "lblTotalContratos";
            this.lblTotalContratos.Size = new System.Drawing.Size(222, 24);
            this.lblTotalContratos.TabIndex = 21;
            this.lblTotalContratos.Text = "Cantidad de Contratos:";
            // 
            // txtCantidadContratos
            // 
            this.txtCantidadContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadContratos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCantidadContratos.Location = new System.Drawing.Point(259, 69);
            this.txtCantidadContratos.Name = "txtCantidadContratos";
            this.txtCantidadContratos.Size = new System.Drawing.Size(76, 29);
            this.txtCantidadContratos.TabIndex = 22;
            this.txtCantidadContratos.Text = "***************";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(410, 72);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(161, 24);
            this.lblTotalGastos.TabIndex = 26;
            this.lblTotalGastos.Text = "Total de Gastos:";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalVentas.Location = new System.Drawing.Point(235, 127);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(121, 29);
            this.txtTotalVentas.TabIndex = 25;
            this.txtTotalVentas.Text = "***************";
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGastos.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtTotalGastos.Location = new System.Drawing.Point(577, 72);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(122, 29);
            this.txtTotalGastos.TabIndex = 27;
            this.txtTotalGastos.Text = "***************";
            // 
            // lblUtilidadGeneral
            // 
            this.lblUtilidadGeneral.AutoSize = true;
            this.lblUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadGeneral.Location = new System.Drawing.Point(406, 133);
            this.lblUtilidadGeneral.Name = "lblUtilidadGeneral";
            this.lblUtilidadGeneral.Size = new System.Drawing.Size(165, 24);
            this.lblUtilidadGeneral.TabIndex = 28;
            this.lblUtilidadGeneral.Text = "Utilidad General:";
            // 
            // txtUtilidadGeneral
            // 
            this.txtUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadGeneral.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtUtilidadGeneral.Location = new System.Drawing.Point(577, 133);
            this.txtUtilidadGeneral.Name = "txtUtilidadGeneral";
            this.txtUtilidadGeneral.Size = new System.Drawing.Size(122, 29);
            this.txtUtilidadGeneral.TabIndex = 29;
            this.txtUtilidadGeneral.Text = "***************";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(67, 127);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(162, 24);
            this.lblTotalVentas.TabIndex = 24;
            this.lblTotalVentas.Text = "Total de Ventas:";
            // 
            // btnDetalleGastos
            // 
            this.btnDetalleGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleGastos.Location = new System.Drawing.Point(892, 81);
            this.btnDetalleGastos.Name = "btnDetalleGastos";
            this.btnDetalleGastos.Size = new System.Drawing.Size(174, 38);
            this.btnDetalleGastos.TabIndex = 51;
            this.btnDetalleGastos.Text = "Detalle de Gastos";
            this.btnDetalleGastos.UseVisualStyleBackColor = true;
            // 
            // lblTituloReporteAnual
            // 
            this.lblTituloReporteAnual.AutoSize = true;
            this.lblTituloReporteAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporteAnual.Location = new System.Drawing.Point(469, 26);
            this.lblTituloReporteAnual.Name = "lblTituloReporteAnual";
            this.lblTituloReporteAnual.Size = new System.Drawing.Size(206, 29);
            this.lblTituloReporteAnual.TabIndex = 50;
            this.lblTituloReporteAnual.Text = "REPORTE: AÑO";
            // 
            // lstvReporteMensualPorAnio
            // 
            this.lstvReporteMensualPorAnio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaMes,
            this.columnaTotalVentas,
            this.columnaTotalGastos,
            this.columnaUtilidad});
            this.lstvReporteMensualPorAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvReporteMensualPorAnio.FullRowSelect = true;
            this.lstvReporteMensualPorAnio.HideSelection = false;
            this.lstvReporteMensualPorAnio.Location = new System.Drawing.Point(14, 283);
            this.lstvReporteMensualPorAnio.MultiSelect = false;
            this.lstvReporteMensualPorAnio.Name = "lstvReporteMensualPorAnio";
            this.lstvReporteMensualPorAnio.Size = new System.Drawing.Size(759, 276);
            this.lstvReporteMensualPorAnio.TabIndex = 54;
            this.lstvReporteMensualPorAnio.UseCompatibleStateImageBehavior = false;
            this.lstvReporteMensualPorAnio.View = System.Windows.Forms.View.Details;
            // 
            // columnaMes
            // 
            this.columnaMes.Text = "Mes";
            this.columnaMes.Width = 205;
            // 
            // columnaTotalVentas
            // 
            this.columnaTotalVentas.Text = "Ventas";
            this.columnaTotalVentas.Width = 189;
            // 
            // columnaTotalGastos
            // 
            this.columnaTotalGastos.Text = "Gastos";
            this.columnaTotalGastos.Width = 172;
            // 
            // columnaUtilidad
            // 
            this.columnaUtilidad.Text = "Utilidad";
            this.columnaUtilidad.Width = 189;
            // 
            // ReporteAnualView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 571);
            this.Controls.Add(this.lstvReporteMensualPorAnio);
            this.Controls.Add(this.lstvGastosTotalesMensuales);
            this.Controls.Add(this.gbTituloGastosDelMes);
            this.Controls.Add(this.btnDetalleGastos);
            this.Controls.Add(this.lblTituloReporteAnual);
            this.Name = "ReporteAnualView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteAnual";
            this.gbTituloGastosDelMes.ResumeLayout(false);
            this.gbTituloGastosDelMes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lstvGastosTotalesMensuales;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTotalGasto;
        public System.Windows.Forms.GroupBox gbTituloGastosDelMes;
        public System.Windows.Forms.Label lblTotalContratos;
        public System.Windows.Forms.TextBox txtCantidadContratos;
        public System.Windows.Forms.Label lblTotalGastos;
        public System.Windows.Forms.TextBox txtTotalVentas;
        public System.Windows.Forms.TextBox txtTotalGastos;
        public System.Windows.Forms.Label lblUtilidadGeneral;
        public System.Windows.Forms.TextBox txtUtilidadGeneral;
        public System.Windows.Forms.Label lblTotalVentas;
        public System.Windows.Forms.Button btnDetalleGastos;
        public System.Windows.Forms.Label lblTituloReporteAnual;
        public System.Windows.Forms.ListView lstvReporteMensualPorAnio;
        private System.Windows.Forms.ColumnHeader columnaMes;
        private System.Windows.Forms.ColumnHeader columnaTotalVentas;
        private System.Windows.Forms.ColumnHeader columnaTotalGastos;
        private System.Windows.Forms.ColumnHeader columnaUtilidad;
    }
}