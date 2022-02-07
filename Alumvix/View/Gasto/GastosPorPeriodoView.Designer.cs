namespace Alumvix.View.Gasto
{
    partial class GastosPorPeriodoView
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
            this.lblListadoGastosPeriodo = new System.Windows.Forms.Label();
            this.lstvGastosPeriodo = new System.Windows.Forms.ListView();
            this.columnaTipoGastoPeriodo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaTotalGasto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblListadoGastosPeriodo
            // 
            this.lblListadoGastosPeriodo.AutoSize = true;
            this.lblListadoGastosPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoGastosPeriodo.Location = new System.Drawing.Point(49, 9);
            this.lblListadoGastosPeriodo.Name = "lblListadoGastosPeriodo";
            this.lblListadoGastosPeriodo.Size = new System.Drawing.Size(299, 29);
            this.lblListadoGastosPeriodo.TabIndex = 44;
            this.lblListadoGastosPeriodo.Text = "GASTOS DEL PERIODO";
            // 
            // lstvGastosPeriodo
            // 
            this.lstvGastosPeriodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGastoPeriodo,
            this.columnaTotalGasto});
            this.lstvGastosPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosPeriodo.FullRowSelect = true;
            this.lstvGastosPeriodo.HideSelection = false;
            this.lstvGastosPeriodo.Location = new System.Drawing.Point(12, 56);
            this.lstvGastosPeriodo.MultiSelect = false;
            this.lstvGastosPeriodo.Name = "lstvGastosPeriodo";
            this.lstvGastosPeriodo.Size = new System.Drawing.Size(376, 289);
            this.lstvGastosPeriodo.TabIndex = 42;
            this.lstvGastosPeriodo.UseCompatibleStateImageBehavior = false;
            this.lstvGastosPeriodo.View = System.Windows.Forms.View.Details;
            // 
            // columnaTipoGastoPeriodo
            // 
            this.columnaTipoGastoPeriodo.Text = "Tipo de gasto";
            this.columnaTipoGastoPeriodo.Width = 223;
            // 
            // columnaTotalGasto
            // 
            this.columnaTotalGasto.Text = "Total";
            this.columnaTotalGasto.Width = 141;
            // 
            // GastosPorPeriodoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 356);
            this.Controls.Add(this.lblListadoGastosPeriodo);
            this.Controls.Add(this.lstvGastosPeriodo);
            this.Name = "GastosPorPeriodoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastosPorPeriodoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblListadoGastosPeriodo;
        public System.Windows.Forms.ListView lstvGastosPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoPeriodo;
        private System.Windows.Forms.ColumnHeader columnaTotalGasto;
    }
}