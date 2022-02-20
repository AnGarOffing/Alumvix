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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorReportesView));
            this.gbPeriodicidad = new System.Windows.Forms.GroupBox();
            this.rbRangoDeFechas = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.lblTituloReporteGeneral = new System.Windows.Forms.Label();
            this.cbSeleccionarMes = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarMes = new System.Windows.Forms.Label();
            this.lblSeleccionarAnio = new System.Windows.Forms.Label();
            this.cbSeleccionarAnio = new System.Windows.Forms.ComboBox();
            this.pnlSuperiorAdminReportesView = new System.Windows.Forms.Panel();
            this.btnCerrarSesionAdminReportes = new System.Windows.Forms.PictureBox();
            this.btnMinimizarAdministradorReportesView = new System.Windows.Forms.PictureBox();
            this.btnCerrarAdministradorReportesView = new System.Windows.Forms.PictureBox();
            this.btnConsultarReporte = new System.Windows.Forms.Button();
            this.gbPeriodicidad.SuspendLayout();
            this.pnlSuperiorAdminReportesView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionAdminReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarAdministradorReportesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAdministradorReportesView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPeriodicidad
            // 
            this.gbPeriodicidad.Controls.Add(this.rbRangoDeFechas);
            this.gbPeriodicidad.Controls.Add(this.rbAnual);
            this.gbPeriodicidad.Controls.Add(this.rbMensual);
            this.gbPeriodicidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPeriodicidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
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
            this.rbAnual.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.rbMensual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMensual.Location = new System.Drawing.Point(15, 24);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(94, 24);
            this.rbMensual.TabIndex = 0;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // lblTituloReporteGeneral
            // 
            this.lblTituloReporteGeneral.AutoSize = true;
            this.lblTituloReporteGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloReporteGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblTituloReporteGeneral.Location = new System.Drawing.Point(238, 11);
            this.lblTituloReporteGeneral.Name = "lblTituloReporteGeneral";
            this.lblTituloReporteGeneral.Size = new System.Drawing.Size(471, 31);
            this.lblTituloReporteGeneral.TabIndex = 23;
            this.lblTituloReporteGeneral.Text = "ADMINISTRADOR DE REPORTES";
            // 
            // cbSeleccionarMes
            // 
            this.cbSeleccionarMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSeleccionarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarMes.FormattingEnabled = true;
            this.cbSeleccionarMes.Location = new System.Drawing.Point(201, 183);
            this.cbSeleccionarMes.Name = "cbSeleccionarMes";
            this.cbSeleccionarMes.Size = new System.Drawing.Size(131, 28);
            this.cbSeleccionarMes.TabIndex = 50;
            // 
            // lblSeleccionarMes
            // 
            this.lblSeleccionarMes.AutoSize = true;
            this.lblSeleccionarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblSeleccionarMes.Location = new System.Drawing.Point(23, 183);
            this.lblSeleccionarMes.Name = "lblSeleccionarMes";
            this.lblSeleccionarMes.Size = new System.Drawing.Size(172, 24);
            this.lblSeleccionarMes.TabIndex = 51;
            this.lblSeleccionarMes.Text = "Seleccionar mes:";
            // 
            // lblSeleccionarAnio
            // 
            this.lblSeleccionarAnio.AutoSize = true;
            this.lblSeleccionarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblSeleccionarAnio.Location = new System.Drawing.Point(375, 183);
            this.lblSeleccionarAnio.Name = "lblSeleccionarAnio";
            this.lblSeleccionarAnio.Size = new System.Drawing.Size(171, 24);
            this.lblSeleccionarAnio.TabIndex = 53;
            this.lblSeleccionarAnio.Text = "Seleccionar Año:";
            // 
            // cbSeleccionarAnio
            // 
            this.cbSeleccionarAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSeleccionarAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarAnio.FormattingEnabled = true;
            this.cbSeleccionarAnio.Location = new System.Drawing.Point(552, 179);
            this.cbSeleccionarAnio.Name = "cbSeleccionarAnio";
            this.cbSeleccionarAnio.Size = new System.Drawing.Size(145, 28);
            this.cbSeleccionarAnio.TabIndex = 52;
            // 
            // pnlSuperiorAdminReportesView
            // 
            this.pnlSuperiorAdminReportesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorAdminReportesView.Controls.Add(this.btnCerrarSesionAdminReportes);
            this.pnlSuperiorAdminReportesView.Controls.Add(this.btnMinimizarAdministradorReportesView);
            this.pnlSuperiorAdminReportesView.Controls.Add(this.btnCerrarAdministradorReportesView);
            this.pnlSuperiorAdminReportesView.Controls.Add(this.lblTituloReporteGeneral);
            this.pnlSuperiorAdminReportesView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorAdminReportesView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorAdminReportesView.Name = "pnlSuperiorAdminReportesView";
            this.pnlSuperiorAdminReportesView.Size = new System.Drawing.Size(907, 59);
            this.pnlSuperiorAdminReportesView.TabIndex = 54;
            // 
            // btnCerrarSesionAdminReportes
            // 
            this.btnCerrarSesionAdminReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesionAdminReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesionAdminReportes.Image")));
            this.btnCerrarSesionAdminReportes.Location = new System.Drawing.Point(788, 12);
            this.btnCerrarSesionAdminReportes.Name = "btnCerrarSesionAdminReportes";
            this.btnCerrarSesionAdminReportes.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarSesionAdminReportes.TabIndex = 48;
            this.btnCerrarSesionAdminReportes.TabStop = false;
            // 
            // btnMinimizarAdministradorReportesView
            // 
            this.btnMinimizarAdministradorReportesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarAdministradorReportesView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarAdministradorReportesView.Image")));
            this.btnMinimizarAdministradorReportesView.Location = new System.Drawing.Point(829, 14);
            this.btnMinimizarAdministradorReportesView.Name = "btnMinimizarAdministradorReportesView";
            this.btnMinimizarAdministradorReportesView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarAdministradorReportesView.TabIndex = 43;
            this.btnMinimizarAdministradorReportesView.TabStop = false;
            // 
            // btnCerrarAdministradorReportesView
            // 
            this.btnCerrarAdministradorReportesView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAdministradorReportesView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAdministradorReportesView.Image")));
            this.btnCerrarAdministradorReportesView.Location = new System.Drawing.Point(871, 14);
            this.btnCerrarAdministradorReportesView.Name = "btnCerrarAdministradorReportesView";
            this.btnCerrarAdministradorReportesView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarAdministradorReportesView.TabIndex = 42;
            this.btnCerrarAdministradorReportesView.TabStop = false;
            // 
            // btnConsultarReporte
            // 
            this.btnConsultarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.btnConsultarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarReporte.Image")));
            this.btnConsultarReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarReporte.Location = new System.Drawing.Point(728, 167);
            this.btnConsultarReporte.Name = "btnConsultarReporte";
            this.btnConsultarReporte.Size = new System.Drawing.Size(159, 44);
            this.btnConsultarReporte.TabIndex = 55;
            this.btnConsultarReporte.Text = "Ver Reporte";
            this.btnConsultarReporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarReporte.UseVisualStyleBackColor = true;
            // 
            // AdministradorReportesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(907, 235);
            this.Controls.Add(this.btnConsultarReporte);
            this.Controls.Add(this.pnlSuperiorAdminReportesView);
            this.Controls.Add(this.lblSeleccionarAnio);
            this.Controls.Add(this.cbSeleccionarAnio);
            this.Controls.Add(this.lblSeleccionarMes);
            this.Controls.Add(this.cbSeleccionarMes);
            this.Controls.Add(this.gbPeriodicidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorReportesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte General";
            this.gbPeriodicidad.ResumeLayout(false);
            this.gbPeriodicidad.PerformLayout();
            this.pnlSuperiorAdminReportesView.ResumeLayout(false);
            this.pnlSuperiorAdminReportesView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionAdminReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarAdministradorReportesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarAdministradorReportesView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTituloReporteGeneral;
        public System.Windows.Forms.ComboBox cbSeleccionarMes;
        private System.Windows.Forms.Label lblSeleccionarMes;
        private System.Windows.Forms.Label lblSeleccionarAnio;
        public System.Windows.Forms.ComboBox cbSeleccionarAnio;
        public System.Windows.Forms.GroupBox gbPeriodicidad;
        public System.Windows.Forms.RadioButton rbMensual;
        public System.Windows.Forms.RadioButton rbRangoDeFechas;
        public System.Windows.Forms.RadioButton rbAnual;
        public System.Windows.Forms.Button btnConsultarReporte;
        public System.Windows.Forms.PictureBox btnMinimizarAdministradorReportesView;
        public System.Windows.Forms.PictureBox btnCerrarAdministradorReportesView;
        public System.Windows.Forms.PictureBox btnCerrarSesionAdminReportes;
        public System.Windows.Forms.Panel pnlSuperiorAdminReportesView;
    }
}