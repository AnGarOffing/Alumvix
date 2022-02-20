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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMensualView));
            this.pnlReporteGeneral = new System.Windows.Forms.Panel();
            this.lblTituloDetalleTiposGastosRM = new System.Windows.Forms.Label();
            this.lstvGastosPeriodo = new System.Windows.Forms.ListView();
            this.columnaTipoGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalTipoGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportarReporteMensualAExcel = new System.Windows.Forms.Button();
            this.pnlSuperiorReporteMensualView = new System.Windows.Forms.Panel();
            this.btnCerrarSesionReporteMensual = new System.Windows.Forms.PictureBox();
            this.btnMinimizarReporteMensualView = new System.Windows.Forms.PictureBox();
            this.btnCerrarReporteMensualView = new System.Windows.Forms.PictureBox();
            this.lblTituloReporteMensual = new System.Windows.Forms.Label();
            this.gbTituloGastosDelMes = new System.Windows.Forms.GroupBox();
            this.lblTotalContratos = new System.Windows.Forms.Label();
            this.txtCantidadContratos = new System.Windows.Forms.TextBox();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.txtTotalVentas = new System.Windows.Forms.TextBox();
            this.txtTotalGastos = new System.Windows.Forms.TextBox();
            this.lblUtilidadGeneral = new System.Windows.Forms.Label();
            this.txtUtilidadGeneral = new System.Windows.Forms.TextBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.pnlReporteGeneral.SuspendLayout();
            this.pnlSuperiorReporteMensualView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionReporteMensual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarReporteMensualView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarReporteMensualView)).BeginInit();
            this.gbTituloGastosDelMes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReporteGeneral
            // 
            this.pnlReporteGeneral.Controls.Add(this.lblTituloDetalleTiposGastosRM);
            this.pnlReporteGeneral.Controls.Add(this.lstvGastosPeriodo);
            this.pnlReporteGeneral.Controls.Add(this.btnExportarReporteMensualAExcel);
            this.pnlReporteGeneral.Controls.Add(this.pnlSuperiorReporteMensualView);
            this.pnlReporteGeneral.Controls.Add(this.gbTituloGastosDelMes);
            this.pnlReporteGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlReporteGeneral.Name = "pnlReporteGeneral";
            this.pnlReporteGeneral.Size = new System.Drawing.Size(831, 495);
            this.pnlReporteGeneral.TabIndex = 45;
            // 
            // lblTituloDetalleTiposGastosRM
            // 
            this.lblTituloDetalleTiposGastosRM.AutoSize = true;
            this.lblTituloDetalleTiposGastosRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleTiposGastosRM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloDetalleTiposGastosRM.Location = new System.Drawing.Point(510, 138);
            this.lblTituloDetalleTiposGastosRM.Name = "lblTituloDetalleTiposGastosRM";
            this.lblTituloDetalleTiposGastosRM.Size = new System.Drawing.Size(221, 29);
            this.lblTituloDetalleTiposGastosRM.TabIndex = 61;
            this.lblTituloDetalleTiposGastosRM.Text = "Detalle de Gastos";
            // 
            // lstvGastosPeriodo
            // 
            this.lstvGastosPeriodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGasto,
            this.columnaTotalTipoGasto});
            this.lstvGastosPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosPeriodo.FullRowSelect = true;
            this.lstvGastosPeriodo.HideSelection = false;
            this.lstvGastosPeriodo.Location = new System.Drawing.Point(435, 182);
            this.lstvGastosPeriodo.MultiSelect = false;
            this.lstvGastosPeriodo.Name = "lstvGastosPeriodo";
            this.lstvGastosPeriodo.Size = new System.Drawing.Size(376, 275);
            this.lstvGastosPeriodo.TabIndex = 60;
            this.lstvGastosPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvGastosPeriodo.View = System.Windows.Forms.View.Details;
            // 
            // columnaTipoGasto
            // 
            this.columnaTipoGasto.Text = "Tipo de Gasto";
            this.columnaTipoGasto.Width = 205;
            // 
            // columnaTotalTipoGasto
            // 
            this.columnaTotalTipoGasto.Text = "Total";
            this.columnaTotalTipoGasto.Width = 189;
            // 
            // btnExportarReporteMensualAExcel
            // 
            this.btnExportarReporteMensualAExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportarReporteMensualAExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarReporteMensualAExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarReporteMensualAExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnExportarReporteMensualAExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarReporteMensualAExcel.Image")));
            this.btnExportarReporteMensualAExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarReporteMensualAExcel.Location = new System.Drawing.Point(368, 78);
            this.btnExportarReporteMensualAExcel.Name = "btnExportarReporteMensualAExcel";
            this.btnExportarReporteMensualAExcel.Size = new System.Drawing.Size(123, 44);
            this.btnExportarReporteMensualAExcel.TabIndex = 59;
            this.btnExportarReporteMensualAExcel.Text = "Exportar";
            this.btnExportarReporteMensualAExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarReporteMensualAExcel.UseVisualStyleBackColor = true;
            // 
            // pnlSuperiorReporteMensualView
            // 
            this.pnlSuperiorReporteMensualView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorReporteMensualView.Controls.Add(this.btnCerrarSesionReporteMensual);
            this.pnlSuperiorReporteMensualView.Controls.Add(this.btnMinimizarReporteMensualView);
            this.pnlSuperiorReporteMensualView.Controls.Add(this.btnCerrarReporteMensualView);
            this.pnlSuperiorReporteMensualView.Controls.Add(this.lblTituloReporteMensual);
            this.pnlSuperiorReporteMensualView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorReporteMensualView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorReporteMensualView.Name = "pnlSuperiorReporteMensualView";
            this.pnlSuperiorReporteMensualView.Size = new System.Drawing.Size(831, 59);
            this.pnlSuperiorReporteMensualView.TabIndex = 50;
            // 
            // btnCerrarSesionReporteMensual
            // 
            this.btnCerrarSesionReporteMensual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesionReporteMensual.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesionReporteMensual.Image")));
            this.btnCerrarSesionReporteMensual.Location = new System.Drawing.Point(710, 11);
            this.btnCerrarSesionReporteMensual.Name = "btnCerrarSesionReporteMensual";
            this.btnCerrarSesionReporteMensual.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarSesionReporteMensual.TabIndex = 55;
            this.btnCerrarSesionReporteMensual.TabStop = false;
            // 
            // btnMinimizarReporteMensualView
            // 
            this.btnMinimizarReporteMensualView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarReporteMensualView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarReporteMensualView.Image")));
            this.btnMinimizarReporteMensualView.Location = new System.Drawing.Point(752, 13);
            this.btnMinimizarReporteMensualView.Name = "btnMinimizarReporteMensualView";
            this.btnMinimizarReporteMensualView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarReporteMensualView.TabIndex = 54;
            this.btnMinimizarReporteMensualView.TabStop = false;
            // 
            // btnCerrarReporteMensualView
            // 
            this.btnCerrarReporteMensualView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarReporteMensualView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarReporteMensualView.Image")));
            this.btnCerrarReporteMensualView.Location = new System.Drawing.Point(794, 13);
            this.btnCerrarReporteMensualView.Name = "btnCerrarReporteMensualView";
            this.btnCerrarReporteMensualView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarReporteMensualView.TabIndex = 53;
            this.btnCerrarReporteMensualView.TabStop = false;
            // 
            // lblTituloReporteMensual
            // 
            this.lblTituloReporteMensual.AutoSize = true;
            this.lblTituloReporteMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporteMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloReporteMensual.Location = new System.Drawing.Point(276, 13);
            this.lblTituloReporteMensual.Name = "lblTituloReporteMensual";
            this.lblTituloReporteMensual.Size = new System.Drawing.Size(284, 29);
            this.lblTituloReporteMensual.TabIndex = 44;
            this.lblTituloReporteMensual.Text = "REPORTE: MES - AÑO";
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
            this.gbTituloGastosDelMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.gbTituloGastosDelMes.Location = new System.Drawing.Point(21, 138);
            this.gbTituloGastosDelMes.Name = "gbTituloGastosDelMes";
            this.gbTituloGastosDelMes.Size = new System.Drawing.Size(384, 319);
            this.gbTituloGastosDelMes.TabIndex = 48;
            this.gbTituloGastosDelMes.TabStop = false;
            this.gbTituloGastosDelMes.Text = "Datos del mes";
            // 
            // lblTotalContratos
            // 
            this.lblTotalContratos.AutoSize = true;
            this.lblTotalContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContratos.Location = new System.Drawing.Point(20, 68);
            this.lblTotalContratos.Name = "lblTotalContratos";
            this.lblTotalContratos.Size = new System.Drawing.Size(234, 24);
            this.lblTotalContratos.TabIndex = 21;
            this.lblTotalContratos.Text = "Cantidad de Contratos =";
            // 
            // txtCantidadContratos
            // 
            this.txtCantidadContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadContratos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtCantidadContratos.Location = new System.Drawing.Point(260, 68);
            this.txtCantidadContratos.Name = "txtCantidadContratos";
            this.txtCantidadContratos.Size = new System.Drawing.Size(76, 29);
            this.txtCantidadContratos.TabIndex = 22;
            this.txtCantidadContratos.Text = "***************";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(56, 191);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(173, 24);
            this.lblTotalGastos.TabIndex = 26;
            this.lblTotalGastos.Text = "Total de Gastos =";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtTotalVentas.Location = new System.Drawing.Point(235, 131);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(121, 29);
            this.txtTotalVentas.TabIndex = 25;
            this.txtTotalVentas.Text = "***************";
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtTotalGastos.Location = new System.Drawing.Point(234, 191);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(122, 29);
            this.txtTotalGastos.TabIndex = 27;
            this.txtTotalGastos.Text = "***************";
            // 
            // lblUtilidadGeneral
            // 
            this.lblUtilidadGeneral.AutoSize = true;
            this.lblUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadGeneral.Location = new System.Drawing.Point(51, 254);
            this.lblUtilidadGeneral.Name = "lblUtilidadGeneral";
            this.lblUtilidadGeneral.Size = new System.Drawing.Size(177, 24);
            this.lblUtilidadGeneral.TabIndex = 28;
            this.lblUtilidadGeneral.Text = "Utilidad General =";
            // 
            // txtUtilidadGeneral
            // 
            this.txtUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtUtilidadGeneral.Location = new System.Drawing.Point(234, 254);
            this.txtUtilidadGeneral.Name = "txtUtilidadGeneral";
            this.txtUtilidadGeneral.Size = new System.Drawing.Size(122, 29);
            this.txtUtilidadGeneral.TabIndex = 29;
            this.txtUtilidadGeneral.Text = "***************";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(55, 131);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(174, 24);
            this.lblTotalVentas.TabIndex = 24;
            this.lblTotalVentas.Text = "Total de Ventas =";
            // 
            // ReporteMensualView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(832, 496);
            this.Controls.Add(this.pnlReporteGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteMensualView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteMensualView";
            this.pnlReporteGeneral.ResumeLayout(false);
            this.pnlReporteGeneral.PerformLayout();
            this.pnlSuperiorReporteMensualView.ResumeLayout(false);
            this.pnlSuperiorReporteMensualView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionReporteMensual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarReporteMensualView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarReporteMensualView)).EndInit();
            this.gbTituloGastosDelMes.ResumeLayout(false);
            this.gbTituloGastosDelMes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReporteGeneral;
        public System.Windows.Forms.Label lblTituloReporteMensual;
        public System.Windows.Forms.Label lblUtilidadGeneral;
        public System.Windows.Forms.TextBox txtUtilidadGeneral;
        public System.Windows.Forms.Label lblTotalGastos;
        public System.Windows.Forms.TextBox txtTotalGastos;
        public System.Windows.Forms.Label lblTotalVentas;
        public System.Windows.Forms.TextBox txtTotalVentas;
        public System.Windows.Forms.Label lblTotalContratos;
        public System.Windows.Forms.TextBox txtCantidadContratos;
        public System.Windows.Forms.GroupBox gbTituloGastosDelMes;
        public System.Windows.Forms.PictureBox btnMinimizarReporteMensualView;
        public System.Windows.Forms.PictureBox btnCerrarReporteMensualView;
        public System.Windows.Forms.PictureBox btnCerrarSesionReporteMensual;
        public System.Windows.Forms.Button btnExportarReporteMensualAExcel;
        public System.Windows.Forms.ListView lstvGastosPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTipoGasto;
        private System.Windows.Forms.ColumnHeader columnaTotalTipoGasto;
        public System.Windows.Forms.Label lblTituloDetalleTiposGastosRM;
        public System.Windows.Forms.Panel pnlSuperiorReporteMensualView;
    }
}