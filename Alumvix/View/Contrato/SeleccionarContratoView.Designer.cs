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
            this.lblTituloSeleccionarContrato = new System.Windows.Forms.Label();
            this.lstvListadoContratos = new System.Windows.Forms.ListView();
            this.columnaNumeroFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorContrato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaFechaTerminacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEstadoContrato = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEstadoTrabajo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMostrarContrato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloSeleccionarContrato
            // 
            this.lblTituloSeleccionarContrato.AutoSize = true;
            this.lblTituloSeleccionarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSeleccionarContrato.Location = new System.Drawing.Point(12, 18);
            this.lblTituloSeleccionarContrato.Name = "lblTituloSeleccionarContrato";
            this.lblTituloSeleccionarContrato.Size = new System.Drawing.Size(258, 29);
            this.lblTituloSeleccionarContrato.TabIndex = 41;
            this.lblTituloSeleccionarContrato.Text = "Seleccionar Contrato";
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
            this.lstvListadoContratos.Location = new System.Drawing.Point(12, 53);
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
            // btnMostrarContrato
            // 
            this.btnMostrarContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarContrato.Location = new System.Drawing.Point(962, 12);
            this.btnMostrarContrato.Name = "btnMostrarContrato";
            this.btnMostrarContrato.Size = new System.Drawing.Size(128, 33);
            this.btnMostrarContrato.TabIndex = 43;
            this.btnMostrarContrato.Text = "Mostrar";
            this.btnMostrarContrato.UseVisualStyleBackColor = true;
            // 
            // SeleccionarContratoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 235);
            this.Controls.Add(this.btnMostrarContrato);
            this.Controls.Add(this.lstvListadoContratos);
            this.Controls.Add(this.lblTituloSeleccionarContrato);
            this.Name = "SeleccionarContratoView";
            this.Text = "SeleccionarContratoView";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}