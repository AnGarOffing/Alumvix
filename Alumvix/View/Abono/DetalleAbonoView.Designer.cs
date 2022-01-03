namespace Alumvix.View.Abono
{
    partial class DetalleAbonoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleAbonoView));
            this.btnEliminarAbono = new System.Windows.Forms.Button();
            this.btnIngresarAbono = new System.Windows.Forms.Button();
            this.lstvDetalleAbonos = new System.Windows.Forms.ListView();
            this.columnaNumeroAbono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorAbono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaAbono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFormaDePago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditarAbono = new System.Windows.Forms.Button();
            this.lblListadoAbonos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarAbono.FlatAppearance.BorderSize = 0;
            this.btnEliminarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarAbono.Image")));
            this.btnEliminarAbono.Location = new System.Drawing.Point(513, 15);
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            this.btnEliminarAbono.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarAbono.TabIndex = 28;
            this.btnEliminarAbono.UseVisualStyleBackColor = false;
            // 
            // btnIngresarAbono
            // 
            this.btnIngresarAbono.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarAbono.FlatAppearance.BorderSize = 0;
            this.btnIngresarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarAbono.Image")));
            this.btnIngresarAbono.Location = new System.Drawing.Point(549, 12);
            this.btnIngresarAbono.Name = "btnIngresarAbono";
            this.btnIngresarAbono.Size = new System.Drawing.Size(46, 40);
            this.btnIngresarAbono.TabIndex = 30;
            this.btnIngresarAbono.UseVisualStyleBackColor = false;
            // 
            // lstvDetalleAbonos
            // 
            this.lstvDetalleAbonos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNumeroAbono,
            this.columnaValorAbono,
            this.columnaFechaAbono,
            this.columnaFormaDePago});
            this.lstvDetalleAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvDetalleAbonos.FullRowSelect = true;
            this.lstvDetalleAbonos.HideSelection = false;
            this.lstvDetalleAbonos.Location = new System.Drawing.Point(12, 58);
            this.lstvDetalleAbonos.MultiSelect = false;
            this.lstvDetalleAbonos.Name = "lstvDetalleAbonos";
            this.lstvDetalleAbonos.Size = new System.Drawing.Size(583, 129);
            this.lstvDetalleAbonos.TabIndex = 32;
            this.lstvDetalleAbonos.UseCompatibleStateImageBehavior = false;
            this.lstvDetalleAbonos.View = System.Windows.Forms.View.Details;
            // 
            // columnaNumeroAbono
            // 
            this.columnaNumeroAbono.Text = "Abono #";
            this.columnaNumeroAbono.Width = 72;
            // 
            // columnaValorAbono
            // 
            this.columnaValorAbono.Text = "Valor";
            this.columnaValorAbono.Width = 93;
            // 
            // columnaFechaAbono
            // 
            this.columnaFechaAbono.Text = "Fecha";
            this.columnaFechaAbono.Width = 244;
            // 
            // columnaFormaDePago
            // 
            this.columnaFormaDePago.Text = "Forma de Pago";
            this.columnaFormaDePago.Width = 154;
            // 
            // btnEditarAbono
            // 
            this.btnEditarAbono.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarAbono.FlatAppearance.BorderSize = 0;
            this.btnEditarAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarAbono.Image")));
            this.btnEditarAbono.Location = new System.Drawing.Point(477, 15);
            this.btnEditarAbono.Name = "btnEditarAbono";
            this.btnEditarAbono.Size = new System.Drawing.Size(30, 35);
            this.btnEditarAbono.TabIndex = 33;
            this.btnEditarAbono.UseVisualStyleBackColor = false;
            // 
            // lblListadoAbonos
            // 
            this.lblListadoAbonos.AutoSize = true;
            this.lblListadoAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoAbonos.Location = new System.Drawing.Point(12, 21);
            this.lblListadoAbonos.Name = "lblListadoAbonos";
            this.lblListadoAbonos.Size = new System.Drawing.Size(230, 29);
            this.lblListadoAbonos.TabIndex = 39;
            this.lblListadoAbonos.Text = "Listado de Abonos";
            // 
            // DetalleAbonoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 200);
            this.Controls.Add(this.lblListadoAbonos);
            this.Controls.Add(this.btnEditarAbono);
            this.Controls.Add(this.lstvDetalleAbonos);
            this.Controls.Add(this.btnIngresarAbono);
            this.Controls.Add(this.btnEliminarAbono);
            this.Name = "DetalleAbonoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abonos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEliminarAbono;
        public System.Windows.Forms.Button btnIngresarAbono;
        public System.Windows.Forms.ListView lstvDetalleAbonos;
        private System.Windows.Forms.ColumnHeader columnaNumeroAbono;
        private System.Windows.Forms.ColumnHeader columnaValorAbono;
        private System.Windows.Forms.ColumnHeader columnaFechaAbono;
        private System.Windows.Forms.ColumnHeader columnaFormaDePago;
        public System.Windows.Forms.Button btnEditarAbono;
        public System.Windows.Forms.Label lblListadoAbonos;
    }
}