namespace Alumvix.View.Gasto
{
    partial class GastosContratosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GastosContratosView));
            this.lblListadoGastosContratos = new System.Windows.Forms.Label();
            this.lstvGastosContratos = new System.Windows.Forms.ListView();
            this.columnaFechaGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTipoGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFacturaProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaNumeroContrato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDescripcionGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSuperiorGastosContratosView = new System.Windows.Forms.Panel();
            this.btnCerrarSesionGastosContratos = new System.Windows.Forms.PictureBox();
            this.btnMinimizarGastosContratosView = new System.Windows.Forms.PictureBox();
            this.btnCerrarGastosContratosView = new System.Windows.Forms.PictureBox();
            this.lblFiltarPorMesGI = new System.Windows.Forms.Label();
            this.cbSeleccionarMesGI = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarAnioGI = new System.Windows.Forms.Label();
            this.cbSeleccionarAnioGI = new System.Windows.Forms.ComboBox();
            this.pnlSuperiorGastosContratosView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionGastosContratos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarGastosContratosView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGastosContratosView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoGastosContratos
            // 
            this.lblListadoGastosContratos.AutoSize = true;
            this.lblListadoGastosContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoGastosContratos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblListadoGastosContratos.Location = new System.Drawing.Point(472, 15);
            this.lblListadoGastosContratos.Name = "lblListadoGastosContratos";
            this.lblListadoGastosContratos.Size = new System.Drawing.Size(330, 29);
            this.lblListadoGastosContratos.TabIndex = 44;
            this.lblListadoGastosContratos.Text = "GASTOS DE CONTRATOS";
            // 
            // lstvGastosContratos
            // 
            this.lstvGastosContratos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaFechaGasto,
            this.columnaTipoGasto,
            this.columnaValorGasto,
            this.columnaProveedor,
            this.columnaFacturaProveedor,
            this.columnaNumeroContrato,
            this.columnaCliente,
            this.columnaDescripcionGasto});
            this.lstvGastosContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosContratos.FullRowSelect = true;
            this.lstvGastosContratos.HideSelection = false;
            this.lstvGastosContratos.Location = new System.Drawing.Point(14, 109);
            this.lstvGastosContratos.MultiSelect = false;
            this.lstvGastosContratos.Name = "lstvGastosContratos";
            this.lstvGastosContratos.Size = new System.Drawing.Size(1272, 429);
            this.lstvGastosContratos.TabIndex = 42;
            this.lstvGastosContratos.UseCompatibleStateImageBehavior = false;
            this.lstvGastosContratos.View = System.Windows.Forms.View.Details;
            // 
            // columnaFechaGasto
            // 
            this.columnaFechaGasto.Text = "Fecha";
            this.columnaFechaGasto.Width = 220;
            // 
            // columnaTipoGasto
            // 
            this.columnaTipoGasto.Text = "Tipo";
            this.columnaTipoGasto.Width = 200;
            // 
            // columnaValorGasto
            // 
            this.columnaValorGasto.Text = "Valor";
            this.columnaValorGasto.Width = 95;
            // 
            // columnaProveedor
            // 
            this.columnaProveedor.Text = "Proveedor";
            this.columnaProveedor.Width = 184;
            // 
            // columnaFacturaProveedor
            // 
            this.columnaFacturaProveedor.Text = "Factura";
            this.columnaFacturaProveedor.Width = 92;
            // 
            // columnaNumeroContrato
            // 
            this.columnaNumeroContrato.Text = "# Contrato";
            this.columnaNumeroContrato.Width = 87;
            // 
            // columnaCliente
            // 
            this.columnaCliente.Text = "Cliente";
            this.columnaCliente.Width = 202;
            // 
            // columnaDescripcionGasto
            // 
            this.columnaDescripcionGasto.Text = "Descripcion";
            this.columnaDescripcionGasto.Width = 350;
            // 
            // pnlSuperiorGastosContratosView
            // 
            this.pnlSuperiorGastosContratosView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorGastosContratosView.Controls.Add(this.btnCerrarSesionGastosContratos);
            this.pnlSuperiorGastosContratosView.Controls.Add(this.btnMinimizarGastosContratosView);
            this.pnlSuperiorGastosContratosView.Controls.Add(this.btnCerrarGastosContratosView);
            this.pnlSuperiorGastosContratosView.Controls.Add(this.lblListadoGastosContratos);
            this.pnlSuperiorGastosContratosView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorGastosContratosView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorGastosContratosView.Name = "pnlSuperiorGastosContratosView";
            this.pnlSuperiorGastosContratosView.Size = new System.Drawing.Size(1298, 59);
            this.pnlSuperiorGastosContratosView.TabIndex = 45;
            // 
            // btnCerrarSesionGastosContratos
            // 
            this.btnCerrarSesionGastosContratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesionGastosContratos.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesionGastosContratos.Image")));
            this.btnCerrarSesionGastosContratos.Location = new System.Drawing.Point(1178, 12);
            this.btnCerrarSesionGastosContratos.Name = "btnCerrarSesionGastosContratos";
            this.btnCerrarSesionGastosContratos.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarSesionGastosContratos.TabIndex = 49;
            this.btnCerrarSesionGastosContratos.TabStop = false;
            // 
            // btnMinimizarGastosContratosView
            // 
            this.btnMinimizarGastosContratosView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarGastosContratosView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarGastosContratosView.Image")));
            this.btnMinimizarGastosContratosView.Location = new System.Drawing.Point(1221, 15);
            this.btnMinimizarGastosContratosView.Name = "btnMinimizarGastosContratosView";
            this.btnMinimizarGastosContratosView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarGastosContratosView.TabIndex = 46;
            this.btnMinimizarGastosContratosView.TabStop = false;
            // 
            // btnCerrarGastosContratosView
            // 
            this.btnCerrarGastosContratosView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarGastosContratosView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarGastosContratosView.Image")));
            this.btnCerrarGastosContratosView.Location = new System.Drawing.Point(1263, 15);
            this.btnCerrarGastosContratosView.Name = "btnCerrarGastosContratosView";
            this.btnCerrarGastosContratosView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarGastosContratosView.TabIndex = 45;
            this.btnCerrarGastosContratosView.TabStop = false;
            // 
            // lblFiltarPorMesGI
            // 
            this.lblFiltarPorMesGI.AutoSize = true;
            this.lblFiltarPorMesGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltarPorMesGI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblFiltarPorMesGI.Location = new System.Drawing.Point(10, 70);
            this.lblFiltarPorMesGI.Name = "lblFiltarPorMesGI";
            this.lblFiltarPorMesGI.Size = new System.Drawing.Size(49, 24);
            this.lblFiltarPorMesGI.TabIndex = 53;
            this.lblFiltarPorMesGI.Text = "Mes";
            // 
            // cbSeleccionarMesGI
            // 
            this.cbSeleccionarMesGI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSeleccionarMesGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarMesGI.FormattingEnabled = true;
            this.cbSeleccionarMesGI.Location = new System.Drawing.Point(65, 70);
            this.cbSeleccionarMesGI.Name = "cbSeleccionarMesGI";
            this.cbSeleccionarMesGI.Size = new System.Drawing.Size(131, 28);
            this.cbSeleccionarMesGI.TabIndex = 52;
            // 
            // lblSeleccionarAnioGI
            // 
            this.lblSeleccionarAnioGI.AutoSize = true;
            this.lblSeleccionarAnioGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarAnioGI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblSeleccionarAnioGI.Location = new System.Drawing.Point(223, 70);
            this.lblSeleccionarAnioGI.Name = "lblSeleccionarAnioGI";
            this.lblSeleccionarAnioGI.Size = new System.Drawing.Size(54, 24);
            this.lblSeleccionarAnioGI.TabIndex = 55;
            this.lblSeleccionarAnioGI.Text = "Año:";
            // 
            // cbSeleccionarAnioGI
            // 
            this.cbSeleccionarAnioGI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSeleccionarAnioGI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarAnioGI.FormattingEnabled = true;
            this.cbSeleccionarAnioGI.Location = new System.Drawing.Point(283, 70);
            this.cbSeleccionarAnioGI.Name = "cbSeleccionarAnioGI";
            this.cbSeleccionarAnioGI.Size = new System.Drawing.Size(145, 28);
            this.cbSeleccionarAnioGI.TabIndex = 54;
            // 
            // GastosContratosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1298, 550);
            this.Controls.Add(this.lblSeleccionarAnioGI);
            this.Controls.Add(this.cbSeleccionarAnioGI);
            this.Controls.Add(this.lblFiltarPorMesGI);
            this.Controls.Add(this.cbSeleccionarMesGI);
            this.Controls.Add(this.pnlSuperiorGastosContratosView);
            this.Controls.Add(this.lstvGastosContratos);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GastosContratosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastoInternoView";
            this.pnlSuperiorGastosContratosView.ResumeLayout(false);
            this.pnlSuperiorGastosContratosView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionGastosContratos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarGastosContratosView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGastosContratosView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblListadoGastosContratos;
        public System.Windows.Forms.ListView lstvGastosContratos;
        private System.Windows.Forms.ColumnHeader columnaFechaGasto;
        private System.Windows.Forms.ColumnHeader columnaTipoGasto;
        private System.Windows.Forms.ColumnHeader columnaValorGasto;
        private System.Windows.Forms.ColumnHeader columnaProveedor;
        public System.Windows.Forms.PictureBox btnMinimizarGastosContratosView;
        public System.Windows.Forms.PictureBox btnCerrarGastosContratosView;
        public System.Windows.Forms.PictureBox btnCerrarSesionGastosContratos;
        public System.Windows.Forms.Panel pnlSuperiorGastosContratosView;
        private System.Windows.Forms.Label lblFiltarPorMesGI;
        public System.Windows.Forms.ComboBox cbSeleccionarMesGI;
        private System.Windows.Forms.Label lblSeleccionarAnioGI;
        public System.Windows.Forms.ComboBox cbSeleccionarAnioGI;
        private System.Windows.Forms.ColumnHeader columnaFacturaProveedor;
        private System.Windows.Forms.ColumnHeader columnaNumeroContrato;
        private System.Windows.Forms.ColumnHeader columnaCliente;
        private System.Windows.Forms.ColumnHeader columnaDescripcionGasto;
    }
}