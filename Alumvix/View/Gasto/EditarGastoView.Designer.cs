namespace Alumvix.View.Gasto
{
    partial class EditarGastoView
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
            this.lblTituloEditarGasto = new System.Windows.Forms.Label();
            this.lvlActualizarValorAbono = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpActualizarFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarGasto = new System.Windows.Forms.Button();
            this.lblActualizarDescripcionGasto = new System.Windows.Forms.Label();
            this.txtIActualizarValorGasto = new System.Windows.Forms.TextBox();
            this.lblEditarValorGasto = new System.Windows.Forms.Label();
            this.lblActualizarFechaGasto = new System.Windows.Forms.Label();
            this.txtActualizarDescripcionGasto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloEditarGasto
            // 
            this.lblTituloEditarGasto.AutoSize = true;
            this.lblTituloEditarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditarGasto.Location = new System.Drawing.Point(12, 27);
            this.lblTituloEditarGasto.Name = "lblTituloEditarGasto";
            this.lblTituloEditarGasto.Size = new System.Drawing.Size(157, 29);
            this.lblTituloEditarGasto.TabIndex = 45;
            this.lblTituloEditarGasto.Text = "Editar Gasto";
            // 
            // lvlActualizarValorAbono
            // 
            this.lvlActualizarValorAbono.AutoSize = true;
            this.lvlActualizarValorAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlActualizarValorAbono.Location = new System.Drawing.Point(37, 27);
            this.lvlActualizarValorAbono.Name = "lvlActualizarValorAbono";
            this.lvlActualizarValorAbono.Size = new System.Drawing.Size(65, 24);
            this.lvlActualizarValorAbono.TabIndex = 41;
            this.lvlActualizarValorAbono.Text = "Valor:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtActualizarDescripcionGasto);
            this.panel1.Controls.Add(this.dtpActualizarFechaGasto);
            this.panel1.Controls.Add(this.btnActualizarGasto);
            this.panel1.Controls.Add(this.lblActualizarDescripcionGasto);
            this.panel1.Controls.Add(this.txtIActualizarValorGasto);
            this.panel1.Controls.Add(this.lblEditarValorGasto);
            this.panel1.Controls.Add(this.lblActualizarFechaGasto);
            this.panel1.Location = new System.Drawing.Point(17, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 284);
            this.panel1.TabIndex = 46;
            // 
            // dtpActualizarFechaGasto
            // 
            this.dtpActualizarFechaGasto.CustomFormat = "yyyy/MM/dd";
            this.dtpActualizarFechaGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpActualizarFechaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualizarFechaGasto.Location = new System.Drawing.Point(331, 29);
            this.dtpActualizarFechaGasto.Name = "dtpActualizarFechaGasto";
            this.dtpActualizarFechaGasto.Size = new System.Drawing.Size(120, 26);
            this.dtpActualizarFechaGasto.TabIndex = 40;
            // 
            // btnActualizarGasto
            // 
            this.btnActualizarGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGasto.Location = new System.Drawing.Point(380, 237);
            this.btnActualizarGasto.Name = "btnActualizarGasto";
            this.btnActualizarGasto.Size = new System.Drawing.Size(124, 33);
            this.btnActualizarGasto.TabIndex = 39;
            this.btnActualizarGasto.Text = "Actualizar";
            this.btnActualizarGasto.UseVisualStyleBackColor = true;
            // 
            // lblActualizarDescripcionGasto
            // 
            this.lblActualizarDescripcionGasto.AutoSize = true;
            this.lblActualizarDescripcionGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarDescripcionGasto.Location = new System.Drawing.Point(11, 84);
            this.lblActualizarDescripcionGasto.Name = "lblActualizarDescripcionGasto";
            this.lblActualizarDescripcionGasto.Size = new System.Drawing.Size(127, 24);
            this.lblActualizarDescripcionGasto.TabIndex = 38;
            this.lblActualizarDescripcionGasto.Text = "Descripcion:";
            // 
            // txtIActualizarValorGasto
            // 
            this.txtIActualizarValorGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIActualizarValorGasto.Location = new System.Drawing.Point(89, 29);
            this.txtIActualizarValorGasto.Name = "txtIActualizarValorGasto";
            this.txtIActualizarValorGasto.Size = new System.Drawing.Size(100, 26);
            this.txtIActualizarValorGasto.TabIndex = 34;
            // 
            // lblEditarValorGasto
            // 
            this.lblEditarValorGasto.AutoSize = true;
            this.lblEditarValorGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarValorGasto.Location = new System.Drawing.Point(24, 29);
            this.lblEditarValorGasto.Name = "lblEditarValorGasto";
            this.lblEditarValorGasto.Size = new System.Drawing.Size(65, 24);
            this.lblEditarValorGasto.TabIndex = 33;
            this.lblEditarValorGasto.Text = "Valor:";
            // 
            // lblActualizarFechaGasto
            // 
            this.lblActualizarFechaGasto.AutoSize = true;
            this.lblActualizarFechaGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarFechaGasto.Location = new System.Drawing.Point(254, 30);
            this.lblActualizarFechaGasto.Name = "lblActualizarFechaGasto";
            this.lblActualizarFechaGasto.Size = new System.Drawing.Size(75, 24);
            this.lblActualizarFechaGasto.TabIndex = 35;
            this.lblActualizarFechaGasto.Text = "Fecha:";
            // 
            // txtActualizarDescripcionGasto
            // 
            this.txtActualizarDescripcionGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualizarDescripcionGasto.Location = new System.Drawing.Point(144, 84);
            this.txtActualizarDescripcionGasto.Multiline = true;
            this.txtActualizarDescripcionGasto.Name = "txtActualizarDescripcionGasto";
            this.txtActualizarDescripcionGasto.Size = new System.Drawing.Size(360, 129);
            this.txtActualizarDescripcionGasto.TabIndex = 41;
            // 
            // EditarGastoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloEditarGasto);
            this.Controls.Add(this.lvlActualizarValorAbono);
            this.Name = "EditarGastoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarGastoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTituloEditarGasto;
        private System.Windows.Forms.Label lvlActualizarValorAbono;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtpActualizarFechaGasto;
        public System.Windows.Forms.Button btnActualizarGasto;
        private System.Windows.Forms.Label lblActualizarDescripcionGasto;
        public System.Windows.Forms.TextBox txtIActualizarValorGasto;
        private System.Windows.Forms.Label lblEditarValorGasto;
        private System.Windows.Forms.Label lblActualizarFechaGasto;
        public System.Windows.Forms.TextBox txtActualizarDescripcionGasto;
    }
}