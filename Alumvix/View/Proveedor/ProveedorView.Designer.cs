namespace Alumvix.View.Proveedor
{
    partial class ProveedorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProveedorView));
            this.lstvProveedores = new System.Windows.Forms.ListView();
            this.columnaNombreProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaCelularProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTelefonoProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDireccionProveedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTituloProveedores = new System.Windows.Forms.Label();
            this.btnIngresarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvProveedores
            // 
            this.lstvProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNombreProveedor,
            this.columnaCelularProveedor,
            this.columnaTelefonoProveedor,
            this.columnaDireccionProveedor});
            this.lstvProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvProveedores.FullRowSelect = true;
            this.lstvProveedores.HideSelection = false;
            this.lstvProveedores.Location = new System.Drawing.Point(12, 65);
            this.lstvProveedores.MultiSelect = false;
            this.lstvProveedores.Name = "lstvProveedores";
            this.lstvProveedores.Size = new System.Drawing.Size(826, 398);
            this.lstvProveedores.TabIndex = 43;
            this.lstvProveedores.UseCompatibleStateImageBehavior = false;
            this.lstvProveedores.View = System.Windows.Forms.View.Details;
            // 
            // columnaNombreProveedor
            // 
            this.columnaNombreProveedor.Text = "Nombre";
            this.columnaNombreProveedor.Width = 224;
            // 
            // columnaCelularProveedor
            // 
            this.columnaCelularProveedor.Text = "Celular";
            this.columnaCelularProveedor.Width = 132;
            // 
            // columnaTelefonoProveedor
            // 
            this.columnaTelefonoProveedor.Text = "Telefono";
            this.columnaTelefonoProveedor.Width = 95;
            // 
            // columnaDireccionProveedor
            // 
            this.columnaDireccionProveedor.Text = "Direccion";
            this.columnaDireccionProveedor.Width = 366;
            // 
            // lblTituloProveedores
            // 
            this.lblTituloProveedores.AutoSize = true;
            this.lblTituloProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProveedores.Location = new System.Drawing.Point(330, 15);
            this.lblTituloProveedores.Name = "lblTituloProveedores";
            this.lblTituloProveedores.Size = new System.Drawing.Size(208, 29);
            this.lblTituloProveedores.TabIndex = 45;
            this.lblTituloProveedores.Text = "PROVEEDORES";
            // 
            // btnIngresarProveedor
            // 
            this.btnIngresarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarProveedor.FlatAppearance.BorderSize = 0;
            this.btnIngresarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarProveedor.Image")));
            this.btnIngresarProveedor.Location = new System.Drawing.Point(792, 22);
            this.btnIngresarProveedor.Name = "btnIngresarProveedor";
            this.btnIngresarProveedor.Size = new System.Drawing.Size(46, 40);
            this.btnIngresarProveedor.TabIndex = 48;
            this.btnIngresarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            this.btnEliminarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProveedor.Image")));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(753, 24);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarProveedor.TabIndex = 47;
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarProveedor.FlatAppearance.BorderSize = 0;
            this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProveedor.Image")));
            this.btnEditarProveedor.Location = new System.Drawing.Point(708, 25);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(30, 35);
            this.btnEditarProveedor.TabIndex = 46;
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            // 
            // ProveedoresView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 497);
            this.Controls.Add(this.btnIngresarProveedor);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnEditarProveedor);
            this.Controls.Add(this.lblTituloProveedores);
            this.Controls.Add(this.lstvProveedores);
            this.Name = "ProveedoresView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProveedoresView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView lstvProveedores;
        private System.Windows.Forms.ColumnHeader columnaNombreProveedor;
        private System.Windows.Forms.ColumnHeader columnaCelularProveedor;
        private System.Windows.Forms.ColumnHeader columnaTelefonoProveedor;
        private System.Windows.Forms.ColumnHeader columnaDireccionProveedor;
        public System.Windows.Forms.Label lblTituloProveedores;
        public System.Windows.Forms.Button btnIngresarProveedor;
        public System.Windows.Forms.Button btnEliminarProveedor;
        public System.Windows.Forms.Button btnEditarProveedor;
    }
}