namespace Alumvix.View.Producto
{
    partial class IngresoProductoView
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
            this.cbSeleccionarProducto = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblIngresarProducto = new System.Windows.Forms.Label();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSeleccionarProducto
            // 
            this.cbSeleccionarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarProducto.FormattingEnabled = true;
            this.cbSeleccionarProducto.Location = new System.Drawing.Point(148, 70);
            this.cbSeleccionarProducto.Name = "cbSeleccionarProducto";
            this.cbSeleccionarProducto.Size = new System.Drawing.Size(171, 28);
            this.cbSeleccionarProducto.TabIndex = 38;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(42, 70);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(100, 24);
            this.lblProducto.TabIndex = 39;
            this.lblProducto.Text = "Producto:";
            // 
            // lblIngresarProducto
            // 
            this.lblIngresarProducto.AutoSize = true;
            this.lblIngresarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarProducto.Location = new System.Drawing.Point(92, 11);
            this.lblIngresarProducto.Name = "lblIngresarProducto";
            this.lblIngresarProducto.Size = new System.Drawing.Size(332, 29);
            this.lblIngresarProducto.TabIndex = 40;
            this.lblIngresarProducto.Text = "INGRESO DE  PRODUCTO";
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Location = new System.Drawing.Point(354, 67);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(83, 33);
            this.btnGuardarProducto.TabIndex = 41;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            // 
            // IngresoProductoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 114);
            this.Controls.Add(this.btnGuardarProducto);
            this.Controls.Add(this.lblIngresarProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cbSeleccionarProducto);
            this.Name = "IngresoProductoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbSeleccionarProducto;
        private System.Windows.Forms.Label lblProducto;
        public System.Windows.Forms.Label lblIngresarProducto;
        public System.Windows.Forms.Button btnGuardarProducto;
    }
}