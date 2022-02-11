namespace Alumvix.View.Abono
{
    partial class IngresoAbonoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoAbonoView));
            this.lvlIngresarValorAbono = new System.Windows.Forms.Label();
            this.txtIngresarValorAbono = new System.Windows.Forms.TextBox();
            this.lblIngresarFechaAbono = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpIngresarFechaAbono = new System.Windows.Forms.DateTimePicker();
            this.lblIngresarFormaDePago = new System.Windows.Forms.Label();
            this.cbIngresarFormaDePago = new System.Windows.Forms.ComboBox();
            this.lblTituloEditarProveedor = new System.Windows.Forms.Label();
            this.pnlSuperiorIngresoAbonoView = new System.Windows.Forms.Panel();
            this.btnMinimizarIngresoAbonoView = new System.Windows.Forms.PictureBox();
            this.btnCerrarIngresoAbonoView = new System.Windows.Forms.PictureBox();
            this.btnGuardarNuevoAbono = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlSuperiorIngresoAbonoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarIngresoAbonoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarIngresoAbonoView)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlIngresarValorAbono
            // 
            this.lvlIngresarValorAbono.AutoSize = true;
            this.lvlIngresarValorAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlIngresarValorAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lvlIngresarValorAbono.Location = new System.Drawing.Point(24, 20);
            this.lvlIngresarValorAbono.Name = "lvlIngresarValorAbono";
            this.lvlIngresarValorAbono.Size = new System.Drawing.Size(59, 24);
            this.lvlIngresarValorAbono.TabIndex = 33;
            this.lvlIngresarValorAbono.Text = "Valor";
            // 
            // txtIngresarValorAbono
            // 
            this.txtIngresarValorAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngresarValorAbono.Location = new System.Drawing.Point(89, 20);
            this.txtIngresarValorAbono.Name = "txtIngresarValorAbono";
            this.txtIngresarValorAbono.Size = new System.Drawing.Size(100, 26);
            this.txtIngresarValorAbono.TabIndex = 34;
            // 
            // lblIngresarFechaAbono
            // 
            this.lblIngresarFechaAbono.AutoSize = true;
            this.lblIngresarFechaAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarFechaAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblIngresarFechaAbono.Location = new System.Drawing.Point(260, 20);
            this.lblIngresarFechaAbono.Name = "lblIngresarFechaAbono";
            this.lblIngresarFechaAbono.Size = new System.Drawing.Size(69, 24);
            this.lblIngresarFechaAbono.TabIndex = 35;
            this.lblIngresarFechaAbono.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardarNuevoAbono);
            this.panel1.Controls.Add(this.dtpIngresarFechaAbono);
            this.panel1.Controls.Add(this.lblIngresarFormaDePago);
            this.panel1.Controls.Add(this.cbIngresarFormaDePago);
            this.panel1.Controls.Add(this.txtIngresarValorAbono);
            this.panel1.Controls.Add(this.lvlIngresarValorAbono);
            this.panel1.Controls.Add(this.lblIngresarFechaAbono);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 128);
            this.panel1.TabIndex = 37;
            // 
            // dtpIngresarFechaAbono
            // 
            this.dtpIngresarFechaAbono.CustomFormat = "yyyy/MM/dd";
            this.dtpIngresarFechaAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIngresarFechaAbono.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngresarFechaAbono.Location = new System.Drawing.Point(335, 20);
            this.dtpIngresarFechaAbono.Name = "dtpIngresarFechaAbono";
            this.dtpIngresarFechaAbono.Size = new System.Drawing.Size(129, 26);
            this.dtpIngresarFechaAbono.TabIndex = 40;
            // 
            // lblIngresarFormaDePago
            // 
            this.lblIngresarFormaDePago.AutoSize = true;
            this.lblIngresarFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarFormaDePago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblIngresarFormaDePago.Location = new System.Drawing.Point(9, 81);
            this.lblIngresarFormaDePago.Name = "lblIngresarFormaDePago";
            this.lblIngresarFormaDePago.Size = new System.Drawing.Size(154, 24);
            this.lblIngresarFormaDePago.TabIndex = 38;
            this.lblIngresarFormaDePago.Text = "Forma de Pago";
            // 
            // cbIngresarFormaDePago
            // 
            this.cbIngresarFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIngresarFormaDePago.FormattingEnabled = true;
            this.cbIngresarFormaDePago.Location = new System.Drawing.Point(169, 81);
            this.cbIngresarFormaDePago.Name = "cbIngresarFormaDePago";
            this.cbIngresarFormaDePago.Size = new System.Drawing.Size(145, 28);
            this.cbIngresarFormaDePago.TabIndex = 37;
            // 
            // lblTituloEditarProveedor
            // 
            this.lblTituloEditarProveedor.AutoSize = true;
            this.lblTituloEditarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEditarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloEditarProveedor.Location = new System.Drawing.Point(134, 16);
            this.lblTituloEditarProveedor.Name = "lblTituloEditarProveedor";
            this.lblTituloEditarProveedor.Size = new System.Drawing.Size(243, 29);
            this.lblTituloEditarProveedor.TabIndex = 80;
            this.lblTituloEditarProveedor.Text = "INGRESAR ABONO";
            // 
            // pnlSuperiorIngresoAbonoView
            // 
            this.pnlSuperiorIngresoAbonoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorIngresoAbonoView.Controls.Add(this.btnMinimizarIngresoAbonoView);
            this.pnlSuperiorIngresoAbonoView.Controls.Add(this.btnCerrarIngresoAbonoView);
            this.pnlSuperiorIngresoAbonoView.Controls.Add(this.lblTituloEditarProveedor);
            this.pnlSuperiorIngresoAbonoView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorIngresoAbonoView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorIngresoAbonoView.Name = "pnlSuperiorIngresoAbonoView";
            this.pnlSuperiorIngresoAbonoView.Size = new System.Drawing.Size(506, 59);
            this.pnlSuperiorIngresoAbonoView.TabIndex = 38;
            // 
            // btnMinimizarIngresoAbonoView
            // 
            this.btnMinimizarIngresoAbonoView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarIngresoAbonoView.Image")));
            this.btnMinimizarIngresoAbonoView.Location = new System.Drawing.Point(426, 14);
            this.btnMinimizarIngresoAbonoView.Name = "btnMinimizarIngresoAbonoView";
            this.btnMinimizarIngresoAbonoView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarIngresoAbonoView.TabIndex = 82;
            this.btnMinimizarIngresoAbonoView.TabStop = false;
            // 
            // btnCerrarIngresoAbonoView
            // 
            this.btnCerrarIngresoAbonoView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarIngresoAbonoView.Image")));
            this.btnCerrarIngresoAbonoView.Location = new System.Drawing.Point(468, 14);
            this.btnCerrarIngresoAbonoView.Name = "btnCerrarIngresoAbonoView";
            this.btnCerrarIngresoAbonoView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarIngresoAbonoView.TabIndex = 81;
            this.btnCerrarIngresoAbonoView.TabStop = false;
            // 
            // btnGuardarNuevoAbono
            // 
            this.btnGuardarNuevoAbono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevoAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevoAbono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnGuardarNuevoAbono.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarNuevoAbono.Image")));
            this.btnGuardarNuevoAbono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarNuevoAbono.Location = new System.Drawing.Point(344, 65);
            this.btnGuardarNuevoAbono.Name = "btnGuardarNuevoAbono";
            this.btnGuardarNuevoAbono.Size = new System.Drawing.Size(120, 44);
            this.btnGuardarNuevoAbono.TabIndex = 59;
            this.btnGuardarNuevoAbono.Text = "Guardar";
            this.btnGuardarNuevoAbono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarNuevoAbono.UseVisualStyleBackColor = true;
            // 
            // IngresoAbonoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(506, 217);
            this.Controls.Add(this.pnlSuperiorIngresoAbonoView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoAbonoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoAbonoView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSuperiorIngresoAbonoView.ResumeLayout(false);
            this.pnlSuperiorIngresoAbonoView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarIngresoAbonoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarIngresoAbonoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lvlIngresarValorAbono;
        private System.Windows.Forms.Label lblIngresarFechaAbono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIngresarFormaDePago;
        public System.Windows.Forms.ComboBox cbIngresarFormaDePago;
        public System.Windows.Forms.TextBox txtIngresarValorAbono;
        public System.Windows.Forms.DateTimePicker dtpIngresarFechaAbono;
        public System.Windows.Forms.Label lblTituloEditarProveedor;
        private System.Windows.Forms.Panel pnlSuperiorIngresoAbonoView;
        public System.Windows.Forms.PictureBox btnMinimizarIngresoAbonoView;
        public System.Windows.Forms.PictureBox btnCerrarIngresoAbonoView;
        public System.Windows.Forms.Button btnGuardarNuevoAbono;
    }
}