namespace Alumvix.View.Reporte
{
    partial class ReporteMensualView
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
            this.pnlReporteGeneral = new System.Windows.Forms.Panel();
            this.lstvGastosPeriodo = new System.Windows.Forms.ListView();
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
            this.lblTituloReporteMensual = new System.Windows.Forms.Label();
            this.pnlReporteGeneral.SuspendLayout();
            this.gbTituloGastosDelMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReporteGeneral
            // 
            this.pnlReporteGeneral.Controls.Add(this.lstvGastosPeriodo);
            this.pnlReporteGeneral.Controls.Add(this.gbTituloGastosDelMes);
            this.pnlReporteGeneral.Controls.Add(this.btnDetalleGastos);
            this.pnlReporteGeneral.Controls.Add(this.lblTituloReporteMensual);
            this.pnlReporteGeneral.Location = new System.Drawing.Point(12, 12);
            this.pnlReporteGeneral.Name = "pnlReporteGeneral";
            this.pnlReporteGeneral.Size = new System.Drawing.Size(821, 401);
            this.pnlReporteGeneral.TabIndex = 45;
            // 
            // lstvGastosPeriodo
            // 
            this.lstvGastosPeriodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGastoPeriodo,
            this.columnaTotalGasto});
            this.lstvGastosPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosPeriodo.FullRowSelect = true;
            this.lstvGastosPeriodo.HideSelection = false;
            this.lstvGastosPeriodo.Location = new System.Drawing.Point(429, 128);
            this.lstvGastosPeriodo.MultiSelect = false;
            this.lstvGastosPeriodo.Name = "lstvGastosPeriodo";
            this.lstvGastosPeriodo.Size = new System.Drawing.Size(376, 258);
            this.lstvGastosPeriodo.TabIndex = 49;
            this.lstvGastosPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvGastosPeriodo.View = System.Windows.Forms.View.Details;
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
            this.gbTituloGastosDelMes.Location = new System.Drawing.Point(21, 84);
            this.gbTituloGastosDelMes.Name = "gbTituloGastosDelMes";
            this.gbTituloGastosDelMes.Size = new System.Drawing.Size(384, 302);
            this.gbTituloGastosDelMes.TabIndex = 48;
            this.gbTituloGastosDelMes.TabStop = false;
            this.gbTituloGastosDelMes.Text = "Datos del mes";
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
            // btnDetalleGastos
            // 
            this.btnDetalleGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleGastos.Location = new System.Drawing.Point(520, 84);
            this.btnDetalleGastos.Name = "btnDetalleGastos";
            this.btnDetalleGastos.Size = new System.Drawing.Size(174, 38);
            this.btnDetalleGastos.TabIndex = 46;
            this.btnDetalleGastos.Text = "Detalle de Gastos";
            this.btnDetalleGastos.UseVisualStyleBackColor = true;
            // 
            // lblTituloReporteMensual
            // 
            this.lblTituloReporteMensual.AutoSize = true;
            this.lblTituloReporteMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporteMensual.Location = new System.Drawing.Point(284, 22);
            this.lblTituloReporteMensual.Name = "lblTituloReporteMensual";
            this.lblTituloReporteMensual.Size = new System.Drawing.Size(284, 29);
            this.lblTituloReporteMensual.TabIndex = 44;
            this.lblTituloReporteMensual.Text = "REPORTE: MES - AÑO";
            // 
            // ReporteMensualView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 428);
            this.Controls.Add(this.pnlReporteGeneral);
            this.Name = "ReporteMensualView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteMensualView";
            this.pnlReporteGeneral.ResumeLayout(false);
            this.pnlReporteGeneral.PerformLayout();
            this.gbTituloGastosDelMes.ResumeLayout(false);
            this.gbTituloGastosDelMes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReporteGeneral;
        public System.Windows.Forms.Button btnDetalleGastos;
        public System.Windows.Forms.Label lblTituloReporteMensual;
        public System.Windows.Forms.Label lblUtilidadGeneral;
        public System.Windows.Forms.TextBox txtUtilidadGeneral;
        public System.Windows.Forms.Label lblTotalGastos;
        public System.Windows.Forms.TextBox txtTotalGastos;
        public System.Windows.Forms.Label lblTotalVentas;
        public System.Windows.Forms.TextBox txtTotalVentas;
        public System.Windows.Forms.Label lblTotalContratos;
        public System.Windows.Forms.TextBox txtCantidadContratos;
        public System.Windows.Forms.ListView lstvGastosPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTotalGasto;
        public System.Windows.Forms.GroupBox gbTituloGastosDelMes;
    }
}