using System.Windows.Forms;

namespace Alumvix.View.Gasto
{
    partial class DetalleGastoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleGastoView));
            this.lstvDetalleGastos = new System.Windows.Forms.ListView();
            this.columnaNumeroGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaNumeroFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTipoGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.btnIngresarGasto = new System.Windows.Forms.Button();
            this.pnlSuperiorDetalleGastoView = new System.Windows.Forms.Panel();
            this.btnMinimizarDetalleGastoView = new System.Windows.Forms.PictureBox();
            this.btnCerrarDetalleGastoView = new System.Windows.Forms.PictureBox();
            this.lblTituloDetalleGastosView = new System.Windows.Forms.Label();
            this.pnlSuperiorDetalleGastoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarDetalleGastoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarDetalleGastoView)).BeginInit();
            this.SuspendLayout();
            // 
            // lstvDetalleGastos
            // 
            this.lstvDetalleGastos.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lstvDetalleGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNumeroGasto,
            this.columnaNumeroFactura,
            this.columnaValorGasto,
            this.columnaFechaGasto,
            this.columnaTipoGasto,
            this.columnaProveedor,
            this.columnaDescripcion});
            this.lstvDetalleGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDetalleGastos.FullRowSelect = true;
            this.lstvDetalleGastos.HideSelection = false;
            this.lstvDetalleGastos.Location = new System.Drawing.Point(14, 111);
            this.lstvDetalleGastos.MultiSelect = false;
            this.lstvDetalleGastos.Name = "lstvDetalleGastos";
            this.lstvDetalleGastos.Size = new System.Drawing.Size(1263, 277);
            this.lstvDetalleGastos.TabIndex = 36;
            this.lstvDetalleGastos.UseCompatibleStateImageBehavior = false;
            this.lstvDetalleGastos.View = System.Windows.Forms.View.Details;
            // 
            // columnaNumeroGasto
            // 
            this.columnaNumeroGasto.Text = "#";
            this.columnaNumeroGasto.Width = 35;
            // 
            // columnaNumeroFactura
            // 
            this.columnaNumeroFactura.Text = "# Factura";
            this.columnaNumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaNumeroFactura.Width = 120;
            // 
            // columnaValorGasto
            // 
            this.columnaValorGasto.Text = "Valor";
            this.columnaValorGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaValorGasto.Width = 85;
            // 
            // columnaFechaGasto
            // 
            this.columnaFechaGasto.Text = "Fecha";
            this.columnaFechaGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaFechaGasto.Width = 270;
            // 
            // columnaTipoGasto
            // 
            this.columnaTipoGasto.Text = "Tipo de Gasto";
            this.columnaTipoGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaTipoGasto.Width = 250;
            // 
            // columnaProveedor
            // 
            this.columnaProveedor.Text = "Proveedor";
            this.columnaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaProveedor.Width = 159;
            // 
            // columnaDescripcion
            // 
            this.columnaDescripcion.Text = "Descripcion";
            this.columnaDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaDescripcion.Width = 350;
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGasto.FlatAppearance.BorderSize = 0;
            this.btnEliminarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGasto.Image")));
            this.btnEliminarGasto.Location = new System.Drawing.Point(1146, 68);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarGasto.TabIndex = 33;
            this.btnEliminarGasto.UseVisualStyleBackColor = false;
            // 
            // btnEditarGasto
            // 
            this.btnEditarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarGasto.FlatAppearance.BorderSize = 0;
            this.btnEditarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGasto.Image")));
            this.btnEditarGasto.Location = new System.Drawing.Point(1192, 68);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(30, 35);
            this.btnEditarGasto.TabIndex = 37;
            this.btnEditarGasto.UseVisualStyleBackColor = false;
            // 
            // btnIngresarGasto
            // 
            this.btnIngresarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarGasto.FlatAppearance.BorderSize = 0;
            this.btnIngresarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarGasto.Image")));
            this.btnIngresarGasto.Location = new System.Drawing.Point(1237, 66);
            this.btnIngresarGasto.Name = "btnIngresarGasto";
            this.btnIngresarGasto.Size = new System.Drawing.Size(37, 39);
            this.btnIngresarGasto.TabIndex = 42;
            this.btnIngresarGasto.UseVisualStyleBackColor = false;
            // 
            // pnlSuperiorDetalleGastoView
            // 
            this.pnlSuperiorDetalleGastoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorDetalleGastoView.Controls.Add(this.btnMinimizarDetalleGastoView);
            this.pnlSuperiorDetalleGastoView.Controls.Add(this.btnCerrarDetalleGastoView);
            this.pnlSuperiorDetalleGastoView.Controls.Add(this.lblTituloDetalleGastosView);
            this.pnlSuperiorDetalleGastoView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorDetalleGastoView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorDetalleGastoView.Name = "pnlSuperiorDetalleGastoView";
            this.pnlSuperiorDetalleGastoView.Size = new System.Drawing.Size(1291, 59);
            this.pnlSuperiorDetalleGastoView.TabIndex = 43;
            // 
            // btnMinimizarDetalleGastoView
            // 
            this.btnMinimizarDetalleGastoView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarDetalleGastoView.Image")));
            this.btnMinimizarDetalleGastoView.Location = new System.Drawing.Point(1215, 14);
            this.btnMinimizarDetalleGastoView.Name = "btnMinimizarDetalleGastoView";
            this.btnMinimizarDetalleGastoView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarDetalleGastoView.TabIndex = 43;
            this.btnMinimizarDetalleGastoView.TabStop = false;
            // 
            // btnCerrarDetalleGastoView
            // 
            this.btnCerrarDetalleGastoView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarDetalleGastoView.Image")));
            this.btnCerrarDetalleGastoView.Location = new System.Drawing.Point(1257, 14);
            this.btnCerrarDetalleGastoView.Name = "btnCerrarDetalleGastoView";
            this.btnCerrarDetalleGastoView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarDetalleGastoView.TabIndex = 42;
            this.btnCerrarDetalleGastoView.TabStop = false;
            // 
            // lblTituloDetalleGastosView
            // 
            this.lblTituloDetalleGastosView.AutoSize = true;
            this.lblTituloDetalleGastosView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDetalleGastosView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloDetalleGastosView.Location = new System.Drawing.Point(486, 12);
            this.lblTituloDetalleGastosView.Name = "lblTituloDetalleGastosView";
            this.lblTituloDetalleGastosView.Size = new System.Drawing.Size(313, 31);
            this.lblTituloDetalleGastosView.TabIndex = 40;
            this.lblTituloDetalleGastosView.Text = "LISTADO DE GASTOS";
            // 
            // DetalleGastoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1291, 396);
            this.Controls.Add(this.pnlSuperiorDetalleGastoView);
            this.Controls.Add(this.btnIngresarGasto);
            this.Controls.Add(this.btnEditarGasto);
            this.Controls.Add(this.lstvDetalleGastos);
            this.Controls.Add(this.btnEliminarGasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetalleGastoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleGastoView";
            this.pnlSuperiorDetalleGastoView.ResumeLayout(false);
            this.pnlSuperiorDetalleGastoView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarDetalleGastoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarDetalleGastoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lstvDetalleGastos;
        private System.Windows.Forms.ColumnHeader columnaNumeroGasto;
        private System.Windows.Forms.ColumnHeader columnaValorGasto;
        private System.Windows.Forms.ColumnHeader columnaFechaGasto;
        private System.Windows.Forms.ColumnHeader columnaTipoGasto;
        public System.Windows.Forms.Button btnEliminarGasto;
        public System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.ColumnHeader columnaNumeroFactura;
        private System.Windows.Forms.ColumnHeader columnaProveedor;
        private System.Windows.Forms.ColumnHeader columnaDescripcion;
        public System.Windows.Forms.Button btnIngresarGasto;
        private System.Windows.Forms.Panel pnlSuperiorDetalleGastoView;
        private System.Windows.Forms.Label lblTituloDetalleGastosView;
        public System.Windows.Forms.PictureBox btnMinimizarDetalleGastoView;
        public System.Windows.Forms.PictureBox btnCerrarDetalleGastoView;
    }
}