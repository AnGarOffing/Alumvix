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
            this.lstvResumenContratos = new System.Windows.Forms.ListView();
            this.columnaFechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaNombreCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaNumeroFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTipoFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblCantidadContabilidad = new System.Windows.Forms.Label();
            this.txtCantidadContabilidad = new System.Windows.Forms.TextBox();
            this.lblTotalContabilidad = new System.Windows.Forms.Label();
            this.txtCantidadReserva = new System.Windows.Forms.TextBox();
            this.txtTotalContabilidad = new System.Windows.Forms.TextBox();
            this.lblTotalReserva = new System.Windows.Forms.Label();
            this.txtTotalReserva = new System.Windows.Forms.TextBox();
            this.lblCantidadReserva = new System.Windows.Forms.Label();
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
            this.pnlReporteGeneral.Controls.Add(this.lstvResumenContratos);
            this.pnlReporteGeneral.Controls.Add(this.lblTituloDetalleTiposGastosRM);
            this.pnlReporteGeneral.Controls.Add(this.lstvGastosPeriodo);
            this.pnlReporteGeneral.Controls.Add(this.btnExportarReporteMensualAExcel);
            this.pnlReporteGeneral.Controls.Add(this.pnlSuperiorReporteMensualView);
            this.pnlReporteGeneral.Controls.Add(this.gbTituloGastosDelMes);
            this.pnlReporteGeneral.Location = new System.Drawing.Point(0, 0);
            this.pnlReporteGeneral.Name = "pnlReporteGeneral";
            this.pnlReporteGeneral.Size = new System.Drawing.Size(1150, 565);
            this.pnlReporteGeneral.TabIndex = 45;
            // 
            // lstvResumenContratos
            // 
            this.lstvResumenContratos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaFechaInicio,
            this.columnaNombreCliente,
            this.columnaNumeroFactura,
            this.columnaTipoFactura,
            this.columnaValor,
            this.columnaCategoria});
            this.lstvResumenContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvResumenContratos.FullRowSelect = true;
            this.lstvResumenContratos.HideSelection = false;
            this.lstvResumenContratos.Location = new System.Drawing.Point(12, 296);
            this.lstvResumenContratos.MultiSelect = false;
            this.lstvResumenContratos.Name = "lstvResumenContratos";
            this.lstvResumenContratos.Size = new System.Drawing.Size(1126, 258);
            this.lstvResumenContratos.TabIndex = 62;
            this.lstvResumenContratos.UseCompatibleStateImageBehavior = false;
            this.lstvResumenContratos.View = System.Windows.Forms.View.Details;
            // 
            // columnaFechaInicio
            // 
            this.columnaFechaInicio.Text = "Fecha Inicio";
            this.columnaFechaInicio.Width = 230;
            // 
            // columnaNombreCliente
            // 
            this.columnaNombreCliente.Text = "Cliente";
            this.columnaNombreCliente.Width = 244;
            // 
            // columnaNumeroFactura
            // 
            this.columnaNumeroFactura.Text = "# Factura";
            this.columnaNumeroFactura.Width = 120;
            // 
            // columnaTipoFactura
            // 
            this.columnaTipoFactura.Text = "TipoFactura";
            this.columnaTipoFactura.Width = 191;
            // 
            // columnaValor
            // 
            this.columnaValor.Text = "Valor";
            this.columnaValor.Width = 98;
            // 
            // columnaCategoria
            // 
            this.columnaCategoria.Text = "Categoria";
            this.columnaCategoria.Width = 237;
            // 
            // lblTituloDetalleTiposGastosRM
            // 
            this.lblTituloDetalleTiposGastosRM.AutoSize = true;
            this.lblTituloDetalleTiposGastosRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleTiposGastosRM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloDetalleTiposGastosRM.Location = new System.Drawing.Point(757, 90);
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
            this.lstvGastosPeriodo.Location = new System.Drawing.Point(762, 122);
            this.lstvGastosPeriodo.MultiSelect = false;
            this.lstvGastosPeriodo.Name = "lstvGastosPeriodo";
            this.lstvGastosPeriodo.Size = new System.Drawing.Size(376, 168);
            this.lstvGastosPeriodo.TabIndex = 60;
            this.lstvGastosPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvGastosPeriodo.View = System.Windows.Forms.View.Details;
            // 
            // columnaTipoGasto
            // 
            this.columnaTipoGasto.Text = "Tipo de Gasto";
            this.columnaTipoGasto.Width = 226;
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
            this.btnExportarReporteMensualAExcel.Location = new System.Drawing.Point(1015, 72);
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
            this.pnlSuperiorReporteMensualView.Size = new System.Drawing.Size(1150, 59);
            this.pnlSuperiorReporteMensualView.TabIndex = 50;
            // 
            // btnCerrarSesionReporteMensual
            // 
            this.btnCerrarSesionReporteMensual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesionReporteMensual.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesionReporteMensual.Image")));
            this.btnCerrarSesionReporteMensual.Location = new System.Drawing.Point(1033, 13);
            this.btnCerrarSesionReporteMensual.Name = "btnCerrarSesionReporteMensual";
            this.btnCerrarSesionReporteMensual.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarSesionReporteMensual.TabIndex = 55;
            this.btnCerrarSesionReporteMensual.TabStop = false;
            // 
            // btnMinimizarReporteMensualView
            // 
            this.btnMinimizarReporteMensualView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarReporteMensualView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarReporteMensualView.Image")));
            this.btnMinimizarReporteMensualView.Location = new System.Drawing.Point(1075, 15);
            this.btnMinimizarReporteMensualView.Name = "btnMinimizarReporteMensualView";
            this.btnMinimizarReporteMensualView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarReporteMensualView.TabIndex = 54;
            this.btnMinimizarReporteMensualView.TabStop = false;
            // 
            // btnCerrarReporteMensualView
            // 
            this.btnCerrarReporteMensualView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarReporteMensualView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarReporteMensualView.Image")));
            this.btnCerrarReporteMensualView.Location = new System.Drawing.Point(1117, 15);
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
            this.lblTituloReporteMensual.Location = new System.Drawing.Point(440, 13);
            this.lblTituloReporteMensual.Name = "lblTituloReporteMensual";
            this.lblTituloReporteMensual.Size = new System.Drawing.Size(284, 29);
            this.lblTituloReporteMensual.TabIndex = 44;
            this.lblTituloReporteMensual.Text = "REPORTE: MES - AÑO";
            // 
            // gbTituloGastosDelMes
            // 
            this.gbTituloGastosDelMes.Controls.Add(this.lblCantidadContabilidad);
            this.gbTituloGastosDelMes.Controls.Add(this.txtCantidadContabilidad);
            this.gbTituloGastosDelMes.Controls.Add(this.lblTotalContabilidad);
            this.gbTituloGastosDelMes.Controls.Add(this.txtCantidadReserva);
            this.gbTituloGastosDelMes.Controls.Add(this.txtTotalContabilidad);
            this.gbTituloGastosDelMes.Controls.Add(this.lblTotalReserva);
            this.gbTituloGastosDelMes.Controls.Add(this.txtTotalReserva);
            this.gbTituloGastosDelMes.Controls.Add(this.lblCantidadReserva);
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
            this.gbTituloGastosDelMes.Location = new System.Drawing.Point(12, 78);
            this.gbTituloGastosDelMes.Name = "gbTituloGastosDelMes";
            this.gbTituloGastosDelMes.Size = new System.Drawing.Size(728, 212);
            this.gbTituloGastosDelMes.TabIndex = 48;
            this.gbTituloGastosDelMes.TabStop = false;
            this.gbTituloGastosDelMes.Text = "Datos del mes";
            // 
            // lblCantidadContabilidad
            // 
            this.lblCantidadContabilidad.AutoSize = true;
            this.lblCantidadContabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadContabilidad.Location = new System.Drawing.Point(386, 38);
            this.lblCantidadContabilidad.Name = "lblCantidadContabilidad";
            this.lblCantidadContabilidad.Size = new System.Drawing.Size(232, 24);
            this.lblCantidadContabilidad.TabIndex = 30;
            this.lblCantidadContabilidad.Text = "Cantidad Contabilidad =";
            // 
            // txtCantidadContabilidad
            // 
            this.txtCantidadContabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadContabilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtCantidadContabilidad.Location = new System.Drawing.Point(626, 38);
            this.txtCantidadContabilidad.Name = "txtCantidadContabilidad";
            this.txtCantidadContabilidad.Size = new System.Drawing.Size(76, 29);
            this.txtCantidadContabilidad.TabIndex = 31;
            this.txtCantidadContabilidad.Text = "***************";
            // 
            // lblTotalContabilidad
            // 
            this.lblTotalContabilidad.AutoSize = true;
            this.lblTotalContabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContabilidad.Location = new System.Drawing.Point(422, 128);
            this.lblTotalContabilidad.Name = "lblTotalContabilidad";
            this.lblTotalContabilidad.Size = new System.Drawing.Size(196, 24);
            this.lblTotalContabilidad.TabIndex = 34;
            this.lblTotalContabilidad.Text = "Total Contabilidad =";
            // 
            // txtCantidadReserva
            // 
            this.txtCantidadReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtCantidadReserva.Location = new System.Drawing.Point(626, 81);
            this.txtCantidadReserva.Name = "txtCantidadReserva";
            this.txtCantidadReserva.Size = new System.Drawing.Size(96, 29);
            this.txtCantidadReserva.TabIndex = 33;
            this.txtCantidadReserva.Text = "***************";
            // 
            // txtTotalContabilidad
            // 
            this.txtTotalContabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalContabilidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtTotalContabilidad.Location = new System.Drawing.Point(626, 125);
            this.txtTotalContabilidad.Name = "txtTotalContabilidad";
            this.txtTotalContabilidad.Size = new System.Drawing.Size(96, 29);
            this.txtTotalContabilidad.TabIndex = 35;
            this.txtTotalContabilidad.Text = "***************";
            // 
            // lblTotalReserva
            // 
            this.lblTotalReserva.AutoSize = true;
            this.lblTotalReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReserva.Location = new System.Drawing.Point(462, 169);
            this.lblTotalReserva.Name = "lblTotalReserva";
            this.lblTotalReserva.Size = new System.Drawing.Size(156, 24);
            this.lblTotalReserva.TabIndex = 36;
            this.lblTotalReserva.Text = "Total Reserva =";
            // 
            // txtTotalReserva
            // 
            this.txtTotalReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtTotalReserva.Location = new System.Drawing.Point(626, 169);
            this.txtTotalReserva.Name = "txtTotalReserva";
            this.txtTotalReserva.Size = new System.Drawing.Size(96, 29);
            this.txtTotalReserva.TabIndex = 37;
            this.txtTotalReserva.Text = "***************";
            // 
            // lblCantidadReserva
            // 
            this.lblCantidadReserva.AutoSize = true;
            this.lblCantidadReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadReserva.Location = new System.Drawing.Point(426, 81);
            this.lblCantidadReserva.Name = "lblCantidadReserva";
            this.lblCantidadReserva.Size = new System.Drawing.Size(192, 24);
            this.lblCantidadReserva.TabIndex = 32;
            this.lblCantidadReserva.Text = "Cantidad Reserva =";
            // 
            // lblTotalContratos
            // 
            this.lblTotalContratos.AutoSize = true;
            this.lblTotalContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalContratos.Location = new System.Drawing.Point(20, 38);
            this.lblTotalContratos.Name = "lblTotalContratos";
            this.lblTotalContratos.Size = new System.Drawing.Size(234, 24);
            this.lblTotalContratos.TabIndex = 21;
            this.lblTotalContratos.Text = "Cantidad de Contratos =";
            // 
            // txtCantidadContratos
            // 
            this.txtCantidadContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadContratos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtCantidadContratos.Location = new System.Drawing.Point(260, 38);
            this.txtCantidadContratos.Name = "txtCantidadContratos";
            this.txtCantidadContratos.Size = new System.Drawing.Size(76, 29);
            this.txtCantidadContratos.TabIndex = 22;
            this.txtCantidadContratos.Text = "***************";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(56, 125);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(173, 24);
            this.lblTotalGastos.TabIndex = 26;
            this.lblTotalGastos.Text = "Total de Gastos =";
            // 
            // txtTotalVentas
            // 
            this.txtTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtTotalVentas.Location = new System.Drawing.Point(235, 81);
            this.txtTotalVentas.Name = "txtTotalVentas";
            this.txtTotalVentas.Size = new System.Drawing.Size(121, 29);
            this.txtTotalVentas.TabIndex = 25;
            this.txtTotalVentas.Text = "***************";
            // 
            // txtTotalGastos
            // 
            this.txtTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGastos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtTotalGastos.Location = new System.Drawing.Point(234, 125);
            this.txtTotalGastos.Name = "txtTotalGastos";
            this.txtTotalGastos.Size = new System.Drawing.Size(122, 29);
            this.txtTotalGastos.TabIndex = 27;
            this.txtTotalGastos.Text = "***************";
            // 
            // lblUtilidadGeneral
            // 
            this.lblUtilidadGeneral.AutoSize = true;
            this.lblUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadGeneral.Location = new System.Drawing.Point(51, 169);
            this.lblUtilidadGeneral.Name = "lblUtilidadGeneral";
            this.lblUtilidadGeneral.Size = new System.Drawing.Size(177, 24);
            this.lblUtilidadGeneral.TabIndex = 28;
            this.lblUtilidadGeneral.Text = "Utilidad General =";
            // 
            // txtUtilidadGeneral
            // 
            this.txtUtilidadGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidadGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.txtUtilidadGeneral.Location = new System.Drawing.Point(234, 169);
            this.txtUtilidadGeneral.Name = "txtUtilidadGeneral";
            this.txtUtilidadGeneral.Size = new System.Drawing.Size(122, 29);
            this.txtUtilidadGeneral.TabIndex = 29;
            this.txtUtilidadGeneral.Text = "***************";
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.AutoSize = true;
            this.lblTotalVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVentas.Location = new System.Drawing.Point(55, 81);
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
            this.ClientSize = new System.Drawing.Size(1150, 566);
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
        public System.Windows.Forms.Label lblCantidadContabilidad;
        public System.Windows.Forms.TextBox txtCantidadContabilidad;
        public System.Windows.Forms.Label lblTotalContabilidad;
        public System.Windows.Forms.TextBox txtCantidadReserva;
        public System.Windows.Forms.TextBox txtTotalContabilidad;
        public System.Windows.Forms.Label lblTotalReserva;
        public System.Windows.Forms.TextBox txtTotalReserva;
        public System.Windows.Forms.Label lblCantidadReserva;
        public System.Windows.Forms.ListView lstvResumenContratos;
        private System.Windows.Forms.ColumnHeader columnaFechaInicio;
        private System.Windows.Forms.ColumnHeader columnaNombreCliente;
        private System.Windows.Forms.ColumnHeader columnaNumeroFactura;
        private System.Windows.Forms.ColumnHeader columnaTipoFactura;
        private System.Windows.Forms.ColumnHeader columnaValor;
        private System.Windows.Forms.ColumnHeader columnaCategoria;
    }
}