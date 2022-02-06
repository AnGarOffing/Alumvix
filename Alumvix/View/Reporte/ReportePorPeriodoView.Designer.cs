namespace Alumvix.View.Reporte
{
    partial class ReportePorPeriodoView
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
            this.lblFechaFinalReporte = new System.Windows.Forms.Label();
            this.lblFechaInicioReporte = new System.Windows.Forms.Label();
            this.dtpFechaInicioReporte = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinalReporte = new System.Windows.Forms.DateTimePicker();
            this.lblTituloReportePorPeriodo = new System.Windows.Forms.Label();
            this.btnConsultarReportePorPeriodo = new System.Windows.Forms.Button();
            this.lstvGastosTotalesPorPeriodo = new System.Windows.Forms.ListView();
            this.columnaTipoGastoPeriodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDetalleGastosPorPeriodo = new System.Windows.Forms.Button();
            this.gbCuentasPorPeriodo = new System.Windows.Forms.GroupBox();
            this.lblTotalContratos = new System.Windows.Forms.Label();
            this.txtCantidadContratos = new System.Windows.Forms.TextBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.lblUtilidadGeneral = new System.Windows.Forms.Label();
            this.txtUtilidadGeneral = new System.Windows.Forms.TextBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.gbCuentasPorPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFechaFinalReporte
            // 
            this.lblFechaFinalReporte.AutoSize = true;
            this.lblFechaFinalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinalReporte.Location = new System.Drawing.Point(414, 83);
            this.lblFechaFinalReporte.Name = "lblFechaFinalReporte";
            this.lblFechaFinalReporte.Size = new System.Drawing.Size(127, 24);
            this.lblFechaFinalReporte.TabIndex = 53;
            this.lblFechaFinalReporte.Text = "Fecha Final:";
            // 
            // lblFechaInicioReporte
            // 
            this.lblFechaInicioReporte.AutoSize = true;
            this.lblFechaInicioReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioReporte.Location = new System.Drawing.Point(137, 83);
            this.lblFechaInicioReporte.Name = "lblFechaInicioReporte";
            this.lblFechaInicioReporte.Size = new System.Drawing.Size(135, 24);
            this.lblFechaInicioReporte.TabIndex = 52;
            this.lblFechaInicioReporte.Text = "Fecha Inicial:";
            // 
            // dtpFechaInicioReporte
            // 
            this.dtpFechaInicioReporte.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaInicioReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicioReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicioReporte.Location = new System.Drawing.Point(278, 81);
            this.dtpFechaInicioReporte.Name = "dtpFechaInicioReporte";
            this.dtpFechaInicioReporte.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaInicioReporte.TabIndex = 51;
            // 
            // dtpFechaFinalReporte
            // 
            this.dtpFechaFinalReporte.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaFinalReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinalReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinalReporte.Location = new System.Drawing.Point(547, 83);
            this.dtpFechaFinalReporte.Name = "dtpFechaFinalReporte";
            this.dtpFechaFinalReporte.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaFinalReporte.TabIndex = 50;
            // 
            // lblTituloReportePorPeriodo
            // 
            this.lblTituloReportePorPeriodo.AutoSize = true;
            this.lblTituloReportePorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReportePorPeriodo.Location = new System.Drawing.Point(230, 19);
            this.lblTituloReportePorPeriodo.Name = "lblTituloReportePorPeriodo";
            this.lblTituloReportePorPeriodo.Size = new System.Drawing.Size(364, 31);
            this.lblTituloReportePorPeriodo.TabIndex = 54;
            this.lblTituloReportePorPeriodo.Text = "REPORTE POR PERIODO";
            // 
            // btnConsultarReportePorPeriodo
            // 
            this.btnConsultarReportePorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReportePorPeriodo.Location = new System.Drawing.Point(155, 142);
            this.btnConsultarReportePorPeriodo.Name = "btnConsultarReportePorPeriodo";
            this.btnConsultarReportePorPeriodo.Size = new System.Drawing.Size(101, 38);
            this.btnConsultarReportePorPeriodo.TabIndex = 56;
            this.btnConsultarReportePorPeriodo.Text = "Consultar";
            this.btnConsultarReportePorPeriodo.UseVisualStyleBackColor = true;
            // 
            // lstvGastosTotalesPorPeriodo
            // 
            this.lstvGastosTotalesPorPeriodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGastoPeriodo,
            this.columnaTotalGasto});
            this.lstvGastosTotalesPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosTotalesPorPeriodo.FullRowSelect = true;
            this.lstvGastosTotalesPorPeriodo.HideSelection = false;
            this.lstvGastosTotalesPorPeriodo.Location = new System.Drawing.Point(415, 201);
            this.lstvGastosTotalesPorPeriodo.MultiSelect = false;
            this.lstvGastosTotalesPorPeriodo.Name = "lstvGastosTotalesPorPeriodo";
            this.lstvGastosTotalesPorPeriodo.Size = new System.Drawing.Size(376, 288);
            this.lstvGastosTotalesPorPeriodo.TabIndex = 58;
            this.lstvGastosTotalesPorPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvGastosTotalesPorPeriodo.View = System.Windows.Forms.View.Details;
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
            // btnDetalleGastosPorPeriodo
            // 
            this.btnDetalleGastosPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleGastosPorPeriodo.Location = new System.Drawing.Point(517, 142);
            this.btnDetalleGastosPorPeriodo.Name = "btnDetalleGastosPorPeriodo";
            this.btnDetalleGastosPorPeriodo.Size = new System.Drawing.Size(174, 38);
            this.btnDetalleGastosPorPeriodo.TabIndex = 57;
            this.btnDetalleGastosPorPeriodo.Text = "Detalle de Gastos";
            this.btnDetalleGastosPorPeriodo.UseVisualStyleBackColor = true;
            // 
            // gbCuentasPorPeriodo
            // 
            this.gbCuentasPorPeriodo.Controls.Add(this.lblTotalContratos);
            this.gbCuentasPorPeriodo.Controls.Add(this.txtCantidadContratos);
            this.gbCuentasPorPeriodo.Controls.Add(this.lblTotalGastos);
            this.gbCuentasPorPeriodo.Controls.Add(this.txtTotalVentas);
            this.gbCuentasPorPeriodo.Controls.Add(this.txtTotalGastos);
            this.gbCuentasPorPeriodo.Controls.Add(this.lblUtilidadGeneral);
            this.gbCuentasPorPeriodo.Controls.Add(this.txtUtilidadGeneral);
            this.gbCuentasPorPeriodo.Controls.Add(this.lblTotalVentas);
            this.gbCuentasPorPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCuentasPorPeriodo.Location = new System.Drawing.Point(12, 187);
            this.gbCuentasPorPeriodo.Name = "gbCuentasPorPeriodo";
            this.gbCuentasPorPeriodo.Size = new System.Drawing.Size(384, 302);
            this.gbCuentasPorPeriodo.TabIndex = 59;
            this.gbCuentasPorPeriodo.TabStop = false;
            this.gbCuentasPorPeriodo.Text = "Datos del periodo";
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
            this.txtCantidadContratos.Location = new System.Drawing.Point(251, 67);
            this.txtCantidadContratos.Name = "txtCantidadContratos";
            this.txtCantidadContratos.Size = new System.Drawing.Size(76, 29);
            this.txtCantidadContratos.TabIndex = 22;
            this.txtCantidadContratos.Text = "***************";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(67, 188);
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
            this.txtTotalGastos.Location = new System.Drawing.Point(234, 188);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(122, 29);
            this.txtTotalGastos.TabIndex = 27;
            this.txtTotalGastos.Text = "***************";
            // 
            // lblUtilidadGeneral
            // 
            this.lblUtilidadGeneral.AutoSize = true;
            this.lblUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadGeneral.Location = new System.Drawing.Point(63, 249);
            this.lblUtilidadGeneral.Name = "lblUtilidadGeneral";
            this.lblUtilidadGeneral.Size = new System.Drawing.Size(165, 24);
            this.lblUtilidadGeneral.TabIndex = 28;
            this.lblUtilidadGeneral.Text = "Utilidad General:";
            // 
            // txtUtilidadGeneral
            // 
            this.txtUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadGeneral.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtUtilidadGeneral.Location = new System.Drawing.Point(234, 249);
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
            // ReportePorPeriodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 501);
            this.Controls.Add(this.gbCuentasPorPeriodo);
            this.Controls.Add(this.lstvGastosTotalesPorPeriodo);
            this.Controls.Add(this.btnDetalleGastosPorPeriodo);
            this.Controls.Add(this.btnConsultarReportePorPeriodo);
            this.Controls.Add(this.lblTituloReportePorPeriodo);
            this.Controls.Add(this.lblFechaFinalReporte);
            this.Controls.Add(this.lblFechaInicioReporte);
            this.Controls.Add(this.dtpFechaInicioReporte);
            this.Controls.Add(this.dtpFechaFinalReporte);
            this.Name = "ReportePorPeriodoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportePorPeriodoView";
            this.gbCuentasPorPeriodo.ResumeLayout(false);
            this.gbCuentasPorPeriodo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFechaFinalReporte;
        private System.Windows.Forms.Label lblFechaInicioReporte;
        public System.Windows.Forms.DateTimePicker dtpFechaInicioReporte;
        public System.Windows.Forms.DateTimePicker dtpFechaFinalReporte;
        private System.Windows.Forms.Label lblTituloReportePorPeriodo;
        public System.Windows.Forms.Button btnConsultarReportePorPeriodo;
        public System.Windows.Forms.ListView lstvGastosTotalesPorPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTotalGasto;
        public System.Windows.Forms.Button btnDetalleGastosPorPeriodo;
        public System.Windows.Forms.GroupBox gbCuentasPorPeriodo;
        public System.Windows.Forms.Label lblTotalContratos;
        public System.Windows.Forms.TextBox txtCantidadContratos;
        public System.Windows.Forms.Label lblTotalGastos;
        public System.Windows.Forms.TextBox txtTotalVentas;
        public System.Windows.Forms.TextBox txtTotalGastos;
        public System.Windows.Forms.Label lblUtilidadGeneral;
        public System.Windows.Forms.TextBox txtUtilidadGeneral;
        public System.Windows.Forms.Label lblTotalVentas;
    }
}