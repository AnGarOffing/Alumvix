namespace Alumvix.View.Reporte
{
    partial class AdministradorReportesView
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
            this.gbPeriodicidad = new System.Windows.Forms.GroupBox();
            this.rbRangoDeFechas = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.btnConsultarReporte = new System.Windows.Forms.Button();
            this.lblTituloReporteGeneral = new System.Windows.Forms.Label();
            this.cbSeleccionarMes = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarMes = new System.Windows.Forms.Label();
            this.lblSeleccionarAnio = new System.Windows.Forms.Label();
            this.cbSeleccionarAnio = new System.Windows.Forms.ComboBox();
            this.gbPeriodicidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPeriodicidad
            // 
            this.gbPeriodicidad.Controls.Add(this.rbRangoDeFechas);
            this.gbPeriodicidad.Controls.Add(this.rbAnual);
            this.gbPeriodicidad.Controls.Add(this.rbMensual);
            this.gbPeriodicidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodicidad.Location = new System.Drawing.Point(174, 86);
            this.gbPeriodicidad.Name = "gbPeriodicidad";
            this.gbPeriodicidad.Size = new System.Drawing.Size(601, 64);
            this.gbPeriodicidad.TabIndex = 0;
            this.gbPeriodicidad.TabStop = false;
            this.gbPeriodicidad.Text = "PERIODICIDAD";
            // 
            // rbRangoDeFechas
            // 
            this.rbRangoDeFechas.AutoSize = true;
            this.rbRangoDeFechas.Location = new System.Drawing.Point(409, 24);
            this.rbRangoDeFechas.Name = "rbRangoDeFechas";
            this.rbRangoDeFechas.Size = new System.Drawing.Size(189, 24);
            this.rbRangoDeFechas.TabIndex = 2;
            this.rbRangoDeFechas.TabStop = true;
            this.rbRangoDeFechas.Text = "Por rango de fechas";
            this.rbRangoDeFechas.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(223, 24);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(73, 24);
            this.rbAnual.TabIndex = 1;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(15, 24);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(94, 24);
            this.rbMensual.TabIndex = 0;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // btnConsultarReporte
            // 
            this.btnConsultarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReporte.Location = new System.Drawing.Point(774, 173);
            this.btnConsultarReporte.Name = "btnConsultarReporte";
            this.btnConsultarReporte.Size = new System.Drawing.Size(117, 38);
            this.btnConsultarReporte.TabIndex = 45;
            this.btnConsultarReporte.Text = "Consultar";
            this.btnConsultarReporte.UseVisualStyleBackColor = true;
            // 
            // lblTituloReporteGeneral
            // 
            this.lblTituloReporteGeneral.AutoSize = true;
            this.lblTituloReporteGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporteGeneral.Location = new System.Drawing.Point(238, 21);
            this.lblTituloReporteGeneral.Name = "lblTituloReporteGeneral";
            this.lblTituloReporteGeneral.Size = new System.Drawing.Size(471, 31);
            this.lblTituloReporteGeneral.TabIndex = 23;
            this.lblTituloReporteGeneral.Text = "ADMINISTRADOR DE REPORTES";
            // 
            // cbSeleccionarMes
            // 
            this.cbSeleccionarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarMes.FormattingEnabled = true;
            this.cbSeleccionarMes.Location = new System.Drawing.Point(244, 183);
            this.cbSeleccionarMes.Name = "cbSeleccionarMes";
            this.cbSeleccionarMes.Size = new System.Drawing.Size(131, 28);
            this.cbSeleccionarMes.TabIndex = 50;
            // 
            // lblSeleccionarMes
            // 
            this.lblSeleccionarMes.AutoSize = true;
            this.lblSeleccionarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarMes.Location = new System.Drawing.Point(66, 183);
            this.lblSeleccionarMes.Name = "lblSeleccionarMes";
            this.lblSeleccionarMes.Size = new System.Drawing.Size(172, 24);
            this.lblSeleccionarMes.TabIndex = 51;
            this.lblSeleccionarMes.Text = "Seleccionar mes:";
            // 
            // lblSeleccionarAnio
            // 
            this.lblSeleccionarAnio.AutoSize = true;
            this.lblSeleccionarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarAnio.Location = new System.Drawing.Point(418, 183);
            this.lblSeleccionarAnio.Name = "lblSeleccionarAnio";
            this.lblSeleccionarAnio.Size = new System.Drawing.Size(171, 24);
            this.lblSeleccionarAnio.TabIndex = 53;
            this.lblSeleccionarAnio.Text = "Seleccionar Año:";
            // 
            // cbSeleccionarAnio
            // 
            this.cbSeleccionarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarAnio.FormattingEnabled = true;
            this.cbSeleccionarAnio.Location = new System.Drawing.Point(595, 179);
            this.cbSeleccionarAnio.Name = "cbSeleccionarAnio";
            this.cbSeleccionarAnio.Size = new System.Drawing.Size(145, 28);
            this.cbSeleccionarAnio.TabIndex = 52;
            // 
            // AdministradorReportesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 235);
            this.Controls.Add(this.lblSeleccionarAnio);
            this.Controls.Add(this.cbSeleccionarAnio);
            this.Controls.Add(this.lblSeleccionarMes);
            this.Controls.Add(this.cbSeleccionarMes);
            this.Controls.Add(this.btnConsultarReporte);
            this.Controls.Add(this.gbPeriodicidad);
            this.Controls.Add(this.lblTituloReporteGeneral);
            this.Name = "AdministradorReportesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General";
            this.gbPeriodicidad.ResumeLayout(false);
            this.gbPeriodicidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnConsultarReporte;
        private System.Windows.Forms.Label lblTituloReporteGeneral;
        public System.Windows.Forms.ComboBox cbSeleccionarMes;
        private System.Windows.Forms.Label lblSeleccionarMes;
        private System.Windows.Forms.Label lblSeleccionarAnio;
        public System.Windows.Forms.ComboBox cbSeleccionarAnio;
        public System.Windows.Forms.GroupBox gbPeriodicidad;
        public System.Windows.Forms.RadioButton rbMensual;
        public System.Windows.Forms.RadioButton rbRangoDeFechas;
        public System.Windows.Forms.RadioButton rbAnual;
    }
}