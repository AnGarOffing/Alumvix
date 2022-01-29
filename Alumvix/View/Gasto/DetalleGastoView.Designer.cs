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
            this.columnaDescripcionGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTipoGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListadoGastos = new System.Windows.Forms.Label();
            this.btnIngresarGasto = new System.Windows.Forms.Button();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.btnEditarGasto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvDetalleGastos
            // 
            this.lstvDetalleGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNumeroGasto,
            this.columnaNumeroFactura,
            this.columnaValorGasto,
            this.columnaFechaGasto,
            this.columnaDescripcionGasto,
            this.columnaProveedor,
            this.columnaTipoGasto});
            this.lstvDetalleGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDetalleGastos.FullRowSelect = true;
            this.lstvDetalleGastos.HideSelection = false;
            this.lstvDetalleGastos.Location = new System.Drawing.Point(12, 60);
            this.lstvDetalleGastos.Name = "lstvDetalleGastos";
            this.lstvDetalleGastos.Size = new System.Drawing.Size(1263, 277);
            this.lstvDetalleGastos.TabIndex = 36;
            this.lstvDetalleGastos.UseCompatibleStateImageBehavior = false;
            this.lstvDetalleGastos.View = System.Windows.Forms.View.Details;
            // 
            // columnaNumeroGasto
            // 
            this.columnaNumeroGasto.Text = "Gasto #";
            this.columnaNumeroGasto.Width = 80;
            // 
            // columnaNumeroFactura
            // 
            this.columnaNumeroFactura.Text = "# Factura";
            this.columnaNumeroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaNumeroFactura.Width = 95;
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
            // columnaDescripcionGasto
            // 
            this.columnaDescripcionGasto.Text = "Descripcion";
            this.columnaDescripcionGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaDescripcionGasto.Width = 400;
            // 
            // columnaProveedor
            // 
            this.columnaProveedor.Text = "Proveedor";
            this.columnaProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaProveedor.Width = 150;
            // 
            // columnaTipoGasto
            // 
            this.columnaTipoGasto.Text = "Tipo de Gasto";
            this.columnaTipoGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaTipoGasto.Width = 176;
            // 
            // lblListadoGastos
            // 
            this.lblListadoGastos.AutoSize = true;
            this.lblListadoGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoGastos.Location = new System.Drawing.Point(12, 33);
            this.lblListadoGastos.Name = "lblListadoGastos";
            this.lblListadoGastos.Size = new System.Drawing.Size(175, 24);
            this.lblListadoGastos.TabIndex = 35;
            this.lblListadoGastos.Text = "Listado de Gastos";
            // 
            // btnIngresarGasto
            // 
            this.btnIngresarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarGasto.FlatAppearance.BorderSize = 0;
            this.btnIngresarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarGasto.Image")));
            this.btnIngresarGasto.Location = new System.Drawing.Point(1229, 12);
            this.btnIngresarGasto.Name = "btnIngresarGasto";
            this.btnIngresarGasto.Size = new System.Drawing.Size(46, 40);
            this.btnIngresarGasto.TabIndex = 34;
            this.btnIngresarGasto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGasto.FlatAppearance.BorderSize = 0;
            this.btnEliminarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGasto.Image")));
            this.btnEliminarGasto.Location = new System.Drawing.Point(1193, 15);
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
            this.btnEditarGasto.Location = new System.Drawing.Point(1147, 15);
            this.btnEditarGasto.Name = "btnEditarGasto";
            this.btnEditarGasto.Size = new System.Drawing.Size(30, 35);
            this.btnEditarGasto.TabIndex = 37;
            this.btnEditarGasto.UseVisualStyleBackColor = false;
            // 
            // DetalleGastoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 352);
            this.Controls.Add(this.btnEditarGasto);
            this.Controls.Add(this.lstvDetalleGastos);
            this.Controls.Add(this.lblListadoGastos);
            this.Controls.Add(this.btnIngresarGasto);
            this.Controls.Add(this.btnEliminarGasto);
            this.Name = "DetalleGastoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetalleGastoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lstvDetalleGastos;
        private System.Windows.Forms.ColumnHeader columnaNumeroGasto;
        private System.Windows.Forms.ColumnHeader columnaValorGasto;
        private System.Windows.Forms.ColumnHeader columnaFechaGasto;
        private System.Windows.Forms.ColumnHeader columnaDescripcionGasto;
        public System.Windows.Forms.Label lblListadoGastos;
        public System.Windows.Forms.Button btnIngresarGasto;
        public System.Windows.Forms.Button btnEliminarGasto;
        public System.Windows.Forms.Button btnEditarGasto;
        private System.Windows.Forms.ColumnHeader columnaNumeroFactura;
        private System.Windows.Forms.ColumnHeader columnaProveedor;
        private System.Windows.Forms.ColumnHeader columnaTipoGasto;
    }
}