namespace Alumvix.View.Gasto
{
    partial class IngresoGastoView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFechaIngresoGasto = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarNuevoGasto = new System.Windows.Forms.Button();
            this.lblDescripcionGasto = new System.Windows.Forms.Label();
            this.txtIngresarValorGasto = new System.Windows.Forms.TextBox();
            this.lvlValorIngresoGasto = new System.Windows.Forms.Label();
            this.lblFechaIngresoGasto = new System.Windows.Forms.Label();
            this.lblIngresarGasto = new System.Windows.Forms.Label();
            this.txtDescripcionGasto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescripcionGasto);
            this.panel1.Controls.Add(this.dtpFechaIngresoGasto);
            this.panel1.Controls.Add(this.btnGuardarNuevoGasto);
            this.panel1.Controls.Add(this.lblDescripcionGasto);
            this.panel1.Controls.Add(this.txtIngresarValorGasto);
            this.panel1.Controls.Add(this.lvlValorIngresoGasto);
            this.panel1.Controls.Add(this.lblFechaIngresoGasto);
            this.panel1.Location = new System.Drawing.Point(34, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 267);
            this.panel1.TabIndex = 39;
            // 
            // dtpFechaIngresoGasto
            // 
            this.dtpFechaIngresoGasto.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaIngresoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngresoGasto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngresoGasto.Location = new System.Drawing.Point(331, 29);
            this.dtpFechaIngresoGasto.Name = "dtpFechaIngresoGasto";
            this.dtpFechaIngresoGasto.Size = new System.Drawing.Size(120, 26);
            this.dtpFechaIngresoGasto.TabIndex = 40;
            // 
            // btnGuardarNuevoGasto
            // 
            this.btnGuardarNuevoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoGasto.Location = new System.Drawing.Point(550, 221);
            this.btnGuardarNuevoGasto.Name = "btnGuardarNuevoGasto";
            this.btnGuardarNuevoGasto.Size = new System.Drawing.Size(83, 33);
            this.btnGuardarNuevoGasto.TabIndex = 39;
            this.btnGuardarNuevoGasto.Text = "Guardar";
            this.btnGuardarNuevoGasto.UseVisualStyleBackColor = true;
            // 
            // lblDescripcionGasto
            // 
            this.lblDescripcionGasto.AutoSize = true;
            this.lblDescripcionGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionGasto.Location = new System.Drawing.Point(11, 84);
            this.lblDescripcionGasto.Name = "lblDescripcionGasto";
            this.lblDescripcionGasto.Size = new System.Drawing.Size(216, 24);
            this.lblDescripcionGasto.TabIndex = 38;
            this.lblDescripcionGasto.Text = "Descripcion de Gasto:";
            // 
            // txtIngresarValorGasto
            // 
            this.txtIngresarValorGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarValorGasto.Location = new System.Drawing.Point(89, 29);
            this.txtIngresarValorGasto.Name = "txtIngresarValorGasto";
            this.txtIngresarValorGasto.Size = new System.Drawing.Size(100, 26);
            this.txtIngresarValorGasto.TabIndex = 34;
            // 
            // lvlValorIngresoGasto
            // 
            this.lvlValorIngresoGasto.AutoSize = true;
            this.lvlValorIngresoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlValorIngresoGasto.Location = new System.Drawing.Point(24, 29);
            this.lvlValorIngresoGasto.Name = "lvlValorIngresoGasto";
            this.lvlValorIngresoGasto.Size = new System.Drawing.Size(65, 24);
            this.lvlValorIngresoGasto.TabIndex = 33;
            this.lvlValorIngresoGasto.Text = "Valor:";
            // 
            // lblFechaIngresoGasto
            // 
            this.lblFechaIngresoGasto.AutoSize = true;
            this.lblFechaIngresoGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngresoGasto.Location = new System.Drawing.Point(254, 30);
            this.lblFechaIngresoGasto.Name = "lblFechaIngresoGasto";
            this.lblFechaIngresoGasto.Size = new System.Drawing.Size(75, 24);
            this.lblFechaIngresoGasto.TabIndex = 35;
            this.lblFechaIngresoGasto.Text = "Fecha:";
            // 
            // lblIngresarGasto
            // 
            this.lblIngresarGasto.AutoSize = true;
            this.lblIngresarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarGasto.Location = new System.Drawing.Point(29, 30);
            this.lblIngresarGasto.Name = "lblIngresarGasto";
            this.lblIngresarGasto.Size = new System.Drawing.Size(184, 29);
            this.lblIngresarGasto.TabIndex = 38;
            this.lblIngresarGasto.Text = "Ingresar Gasto";
            // 
            // txtDescripcionGasto
            // 
            this.txtDescripcionGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionGasto.Location = new System.Drawing.Point(233, 84);
            this.txtDescripcionGasto.Multiline = true;
            this.txtDescripcionGasto.Name = "txtDescripcionGasto";
            this.txtDescripcionGasto.Size = new System.Drawing.Size(417, 131);
            this.txtDescripcionGasto.TabIndex = 41;
            // 
            // IngresoGastoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblIngresarGasto);
            this.Name = "IngresoGastoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoGastoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtpFechaIngresoGasto;
        public System.Windows.Forms.Button btnGuardarNuevoGasto;
        private System.Windows.Forms.Label lblDescripcionGasto;
        public System.Windows.Forms.TextBox txtIngresarValorGasto;
        private System.Windows.Forms.Label lvlValorIngresoGasto;
        private System.Windows.Forms.Label lblFechaIngresoGasto;
        public System.Windows.Forms.Label lblIngresarGasto;
        public System.Windows.Forms.TextBox txtDescripcionGasto;
    }
}