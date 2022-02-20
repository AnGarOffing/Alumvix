namespace Alumvix.View.Contrato
{
    partial class SeleccionarContratoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeleccionarContratoView));
            this.lblTituloSeleccionarContrato = new System.Windows.Forms.Label();
            this.lstvListadoContratos = new System.Windows.Forms.ListView();
            this.columnaNumeroFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorContrato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaTerminacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEstadoContrato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEstadoTrabajo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSuperiorSeleccionarContratoView = new System.Windows.Forms.Panel();
            this.btnMinimizarSeleccionarContratoView = new System.Windows.Forms.PictureBox();
            this.btnCerrarSeleccionarContratoView = new System.Windows.Forms.PictureBox();
            this.btnMostrarContrato = new System.Windows.Forms.Button();
            this.pnlSuperiorSeleccionarContratoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarSeleccionarContratoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSeleccionarContratoView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloSeleccionarContrato
            // 
            this.lblTituloSeleccionarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloSeleccionarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeleccionarContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloSeleccionarContrato.Location = new System.Drawing.Point(355, 17);
            this.lblTituloSeleccionarContrato.Name = "lblTituloSeleccionarContrato";
            this.lblTituloSeleccionarContrato.Size = new System.Drawing.Size(346, 29);
            this.lblTituloSeleccionarContrato.TabIndex = 41;
            this.lblTituloSeleccionarContrato.Text = "SELECCIONAR CONTRATO";
            this.lblTituloSeleccionarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstvListadoContratos
            // 
            this.lstvListadoContratos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNumeroFactura,
            this.columnaValorContrato,
            this.columnaFechaInicio,
            this.columnaFechaTerminacion,
            this.columnaEstadoContrato,
            this.columnaEstadoTrabajo});
            this.lstvListadoContratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvListadoContratos.FullRowSelect = true;
            this.lstvListadoContratos.HideSelection = false;
            this.lstvListadoContratos.Location = new System.Drawing.Point(12, 116);
            this.lstvListadoContratos.MultiSelect = false;
            this.lstvListadoContratos.Name = "lstvListadoContratos";
            this.lstvListadoContratos.Size = new System.Drawing.Size(1078, 170);
            this.lstvListadoContratos.TabIndex = 42;
            this.lstvListadoContratos.UseCompatibleStateImageBehavior = false;
            this.lstvListadoContratos.View = System.Windows.Forms.View.Details;
            // 
            // columnaNumeroFactura
            // 
            this.columnaNumeroFactura.Text = "# Factura";
            this.columnaNumeroFactura.Width = 72;
            // 
            // columnaValorContrato
            // 
            this.columnaValorContrato.Text = "Valor";
            this.columnaValorContrato.Width = 128;
            // 
            // columnaFechaInicio
            // 
            this.columnaFechaInicio.Text = "Fecha de Inicio";
            this.columnaFechaInicio.Width = 285;
            // 
            // columnaFechaTerminacion
            // 
            this.columnaFechaTerminacion.Text = "Fecha de Terminacion";
            this.columnaFechaTerminacion.Width = 285;
            // 
            // columnaEstadoContrato
            // 
            this.columnaEstadoContrato.Text = "Estado de Contrato";
            this.columnaEstadoContrato.Width = 155;
            // 
            // columnaEstadoTrabajo
            // 
            this.columnaEstadoTrabajo.Text = "Estado de Trabajo";
            this.columnaEstadoTrabajo.Width = 164;
            // 
            // pnlSuperiorSeleccionarContratoView
            // 
            this.pnlSuperiorSeleccionarContratoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorSeleccionarContratoView.Controls.Add(this.btnMinimizarSeleccionarContratoView);
            this.pnlSuperiorSeleccionarContratoView.Controls.Add(this.btnCerrarSeleccionarContratoView);
            this.pnlSuperiorSeleccionarContratoView.Controls.Add(this.lblTituloSeleccionarContrato);
            this.pnlSuperiorSeleccionarContratoView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorSeleccionarContratoView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorSeleccionarContratoView.Name = "pnlSuperiorSeleccionarContratoView";
            this.pnlSuperiorSeleccionarContratoView.Size = new System.Drawing.Size(1102, 59);
            this.pnlSuperiorSeleccionarContratoView.TabIndex = 44;
            // 
            // btnMinimizarSeleccionarContratoView
            // 
            this.btnMinimizarSeleccionarContratoView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarSeleccionarContratoView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarSeleccionarContratoView.Image")));
            this.btnMinimizarSeleccionarContratoView.Location = new System.Drawing.Point(1025, 16);
            this.btnMinimizarSeleccionarContratoView.Name = "btnMinimizarSeleccionarContratoView";
            this.btnMinimizarSeleccionarContratoView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarSeleccionarContratoView.TabIndex = 43;
            this.btnMinimizarSeleccionarContratoView.TabStop = false;
            // 
            // btnCerrarSeleccionarContratoView
            // 
            this.btnCerrarSeleccionarContratoView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSeleccionarContratoView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSeleccionarContratoView.Image")));
            this.btnCerrarSeleccionarContratoView.Location = new System.Drawing.Point(1067, 16);
            this.btnCerrarSeleccionarContratoView.Name = "btnCerrarSeleccionarContratoView";
            this.btnCerrarSeleccionarContratoView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarSeleccionarContratoView.TabIndex = 42;
            this.btnCerrarSeleccionarContratoView.TabStop = false;
            // 
            // btnMostrarContrato
            // 
            this.btnMostrarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnMostrarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrarContrato.Image")));
            this.btnMostrarContrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarContrato.Location = new System.Drawing.Point(464, 63);
            this.btnMostrarContrato.Name = "btnMostrarContrato";
            this.btnMostrarContrato.Size = new System.Drawing.Size(159, 44);
            this.btnMostrarContrato.TabIndex = 47;
            this.btnMostrarContrato.Text = "Ver Contrato";
            this.btnMostrarContrato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrarContrato.UseVisualStyleBackColor = true;
            // 
            // SeleccionarContratoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1102, 297);
            this.Controls.Add(this.btnMostrarContrato);
            this.Controls.Add(this.lstvListadoContratos);
            this.Controls.Add(this.pnlSuperiorSeleccionarContratoView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeleccionarContratoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarContratoView";
            this.pnlSuperiorSeleccionarContratoView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarSeleccionarContratoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSeleccionarContratoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTituloSeleccionarContrato;
        public System.Windows.Forms.ListView lstvListadoContratos;
        private System.Windows.Forms.ColumnHeader columnaNumeroFactura;
        private System.Windows.Forms.ColumnHeader columnaValorContrato;
        private System.Windows.Forms.ColumnHeader columnaFechaInicio;
        private System.Windows.Forms.ColumnHeader columnaFechaTerminacion;
        private System.Windows.Forms.ColumnHeader columnaEstadoContrato;
        private System.Windows.Forms.ColumnHeader columnaEstadoTrabajo;
        public System.Windows.Forms.Button btnMostrarContrato;
        public System.Windows.Forms.PictureBox btnMinimizarSeleccionarContratoView;
        public System.Windows.Forms.PictureBox btnCerrarSeleccionarContratoView;
        public System.Windows.Forms.Panel pnlSuperiorSeleccionarContratoView;
    }
}