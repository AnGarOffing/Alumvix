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
            this.columnaValorGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDescripcionGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListadoGastos = new System.Windows.Forms.Label();
            this.btnIngresarAbono = new System.Windows.Forms.Button();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvDetalleGastos
            // 
            this.lstvDetalleGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNumeroGasto,
            this.columnaValorGasto,
            this.columnaFechaGasto,
            this.columnaDescripcionGasto});
            this.lstvDetalleGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDetalleGastos.FullRowSelect = true;
            this.lstvDetalleGastos.HideSelection = false;
            this.lstvDetalleGastos.Location = new System.Drawing.Point(12, 65);
            this.lstvDetalleGastos.Name = "lstvDetalleGastos";
            this.lstvDetalleGastos.Size = new System.Drawing.Size(1003, 211);
            this.lstvDetalleGastos.TabIndex = 36;
            this.lstvDetalleGastos.UseCompatibleStateImageBehavior = false;
            this.lstvDetalleGastos.View = System.Windows.Forms.View.Details;
            // 
            // columnaNumeroGasto
            // 
            this.columnaNumeroGasto.Text = "Gasto #";
            this.columnaNumeroGasto.Width = 72;
            // 
            // columnaValorGasto
            // 
            this.columnaValorGasto.Text = "Valor";
            this.columnaValorGasto.Width = 93;
            // 
            // columnaFechaGasto
            // 
            this.columnaFechaGasto.Text = "Fecha";
            this.columnaFechaGasto.Width = 114;
            // 
            // columnaDescripcionGasto
            // 
            this.columnaDescripcionGasto.Text = "Descripcion";
            this.columnaDescripcionGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnaDescripcionGasto.Width = 712;
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
            // btnIngresarAbono
            // 
            this.btnIngresarAbono.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarAbono.FlatAppearance.BorderSize = 0;
            this.btnIngresarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarAbono.Image")));
            this.btnIngresarAbono.Location = new System.Drawing.Point(879, 19);
            this.btnIngresarAbono.Name = "btnIngresarAbono";
            this.btnIngresarAbono.Size = new System.Drawing.Size(46, 40);
            this.btnIngresarAbono.TabIndex = 34;
            this.btnIngresarAbono.UseVisualStyleBackColor = false;
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGasto.FlatAppearance.BorderSize = 0;
            this.btnEliminarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGasto.Image")));
            this.btnEliminarGasto.Location = new System.Drawing.Point(843, 22);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarGasto.TabIndex = 33;
            this.btnEliminarGasto.UseVisualStyleBackColor = false;
            // 
            // DetalleGastoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 288);
            this.Controls.Add(this.lstvDetalleGastos);
            this.Controls.Add(this.lblListadoGastos);
            this.Controls.Add(this.btnIngresarAbono);
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
        public System.Windows.Forms.Button btnIngresarAbono;
        public System.Windows.Forms.Button btnEliminarGasto;
    }
}