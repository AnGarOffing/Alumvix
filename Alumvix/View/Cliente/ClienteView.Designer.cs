namespace Alumvix.View
{
    partial class ClienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteView));
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            this.btnActualizarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.btnIngresarCliente = new System.Windows.Forms.Button();
            this.pnlSuperiorClienteView = new System.Windows.Forms.Panel();
            this.btnMinimizarClienteView = new System.Windows.Forms.PictureBox();
            this.btnCerrarClienteView = new System.Windows.Forms.PictureBox();
            this.btnGastosInternos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnDetalleCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.pnlSuperiorClienteView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarClienteView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarClienteView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(11, 123);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(1008, 249);
            this.dataGridClientes.TabIndex = 0;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarCliente.Location = new System.Drawing.Point(12, 83);
            this.txtFiltrarCliente.Multiline = true;
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(247, 29);
            this.txtFiltrarCliente.TabIndex = 3;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCliente.FlatAppearance.BorderSize = 0;
            this.btnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarCliente.Image")));
            this.btnActualizarCliente.Location = new System.Drawing.Point(880, 75);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(30, 35);
            this.btnActualizarCliente.TabIndex = 35;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.Location = new System.Drawing.Point(925, 74);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarCliente.TabIndex = 36;
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(20, 394);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(125, 44);
            this.btnReporte.TabIndex = 37;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloClientes.Location = new System.Drawing.Point(432, 10);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(156, 31);
            this.lblTituloClientes.TabIndex = 39;
            this.lblTituloClientes.Text = "CLIENTES";
            // 
            // btnIngresarCliente
            // 
            this.btnIngresarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarCliente.FlatAppearance.BorderSize = 0;
            this.btnIngresarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarCliente.Image")));
            this.btnIngresarCliente.Location = new System.Drawing.Point(965, 72);
            this.btnIngresarCliente.Name = "btnIngresarCliente";
            this.btnIngresarCliente.Size = new System.Drawing.Size(37, 39);
            this.btnIngresarCliente.TabIndex = 41;
            this.btnIngresarCliente.UseVisualStyleBackColor = false;
            // 
            // pnlSuperiorClienteView
            // 
            this.pnlSuperiorClienteView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorClienteView.Controls.Add(this.btnMinimizarClienteView);
            this.pnlSuperiorClienteView.Controls.Add(this.btnCerrarClienteView);
            this.pnlSuperiorClienteView.Controls.Add(this.lblTituloClientes);
            this.pnlSuperiorClienteView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorClienteView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorClienteView.Name = "pnlSuperiorClienteView";
            this.pnlSuperiorClienteView.Size = new System.Drawing.Size(1032, 53);
            this.pnlSuperiorClienteView.TabIndex = 43;
            // 
            // btnMinimizarClienteView
            // 
            this.btnMinimizarClienteView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarClienteView.Image")));
            this.btnMinimizarClienteView.Location = new System.Drawing.Point(949, 12);
            this.btnMinimizarClienteView.Name = "btnMinimizarClienteView";
            this.btnMinimizarClienteView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarClienteView.TabIndex = 41;
            this.btnMinimizarClienteView.TabStop = false;
            // 
            // btnCerrarClienteView
            // 
            this.btnCerrarClienteView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarClienteView.Image")));
            this.btnCerrarClienteView.Location = new System.Drawing.Point(991, 12);
            this.btnCerrarClienteView.Name = "btnCerrarClienteView";
            this.btnCerrarClienteView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarClienteView.TabIndex = 40;
            this.btnCerrarClienteView.TabStop = false;
            // 
            // btnGastosInternos
            // 
            this.btnGastosInternos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGastosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastosInternos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnGastosInternos.Image = ((System.Drawing.Image)(resources.GetObject("btnGastosInternos.Image")));
            this.btnGastosInternos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGastosInternos.Location = new System.Drawing.Point(189, 394);
            this.btnGastosInternos.Name = "btnGastosInternos";
            this.btnGastosInternos.Size = new System.Drawing.Size(184, 44);
            this.btnGastosInternos.TabIndex = 44;
            this.btnGastosInternos.Text = "Gastos Internos";
            this.btnGastosInternos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGastosInternos.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Location = new System.Drawing.Point(421, 394);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(159, 44);
            this.btnProveedores.TabIndex = 45;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnDetalleCliente
            // 
            this.btnDetalleCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnDetalleCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalleCliente.Image")));
            this.btnDetalleCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetalleCliente.Location = new System.Drawing.Point(685, 70);
            this.btnDetalleCliente.Name = "btnDetalleCliente";
            this.btnDetalleCliente.Size = new System.Drawing.Size(172, 44);
            this.btnDetalleCliente.TabIndex = 46;
            this.btnDetalleCliente.Text = "Detalle Cliente";
            this.btnDetalleCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalleCliente.UseVisualStyleBackColor = true;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.btnDetalleCliente);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnGastosInternos);
            this.Controls.Add(this.pnlSuperiorClienteView);
            this.Controls.Add(this.btnIngresarCliente);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.dataGridClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClienteView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.pnlSuperiorClienteView.ResumeLayout(false);
            this.pnlSuperiorClienteView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarClienteView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarClienteView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.TextBox txtFiltrarCliente;
        public System.Windows.Forms.Button btnActualizarCliente;
        public System.Windows.Forms.Button btnEliminarCliente;
        public System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblTituloClientes;
        public System.Windows.Forms.Button btnIngresarCliente;
        private System.Windows.Forms.Panel pnlSuperiorClienteView;
        public System.Windows.Forms.PictureBox btnMinimizarClienteView;
        public System.Windows.Forms.PictureBox btnCerrarClienteView;
        public System.Windows.Forms.Button btnGastosInternos;
        public System.Windows.Forms.Button btnProveedores;
        public System.Windows.Forms.Button btnDetalleCliente;
    }
}