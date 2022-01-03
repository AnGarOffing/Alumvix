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
            this.btnDetalleCliente = new System.Windows.Forms.Button();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnEliminarGasto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Location = new System.Drawing.Point(27, 100);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClientes.Size = new System.Drawing.Size(735, 148);
            this.dataGridClientes.TabIndex = 0;
            // 
            // btnDetalleCliente
            // 
            this.btnDetalleCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalleCliente.Location = new System.Drawing.Point(272, 58);
            this.btnDetalleCliente.Name = "btnDetalleCliente";
            this.btnDetalleCliente.Size = new System.Drawing.Size(139, 25);
            this.btnDetalleCliente.TabIndex = 2;
            this.btnDetalleCliente.Text = "Detalle";
            this.btnDetalleCliente.UseVisualStyleBackColor = true;
            // 
            // txtFiltrarCliente
            // 
            this.txtFiltrarCliente.Location = new System.Drawing.Point(58, 63);
            this.txtFiltrarCliente.Name = "txtFiltrarCliente";
            this.txtFiltrarCliente.Size = new System.Drawing.Size(170, 20);
            this.txtFiltrarCliente.TabIndex = 3;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCliente.Image")));
            this.btnEditarCliente.Location = new System.Drawing.Point(431, 52);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(30, 35);
            this.btnEditarCliente.TabIndex = 35;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            // 
            // btnEliminarGasto
            // 
            this.btnEliminarGasto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGasto.FlatAppearance.BorderSize = 0;
            this.btnEliminarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGasto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGasto.Image")));
            this.btnEliminarGasto.Location = new System.Drawing.Point(482, 48);
            this.btnEliminarGasto.Name = "btnEliminarGasto";
            this.btnEliminarGasto.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarGasto.TabIndex = 36;
            this.btnEliminarGasto.UseVisualStyleBackColor = false;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarGasto);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnDetalleCliente);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "ClienteView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.Button btnDetalleCliente;
        public System.Windows.Forms.TextBox txtFiltrarCliente;
        public System.Windows.Forms.Button btnEditarCliente;
        public System.Windows.Forms.Button btnEliminarGasto;
    }
}