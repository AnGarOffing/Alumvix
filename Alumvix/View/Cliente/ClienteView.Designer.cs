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
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.btnDetalleCliente = new System.Windows.Forms.Button();
            this.txtFiltrarCliente = new System.Windows.Forms.TextBox();
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
            this.btnDetalleCliente.Location = new System.Drawing.Point(258, 58);
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
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiltrarCliente);
            this.Controls.Add(this.btnDetalleCliente);
            this.Controls.Add(this.dataGridClientes);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridClientes;
        public System.Windows.Forms.Button btnDetalleCliente;
        public System.Windows.Forms.TextBox txtFiltrarCliente;
    }
}