namespace Alumvix.View.Gasto
{
    partial class GastoInternoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GastoInternoView));
            this.lblListadoGastosInternos = new System.Windows.Forms.Label();
            this.btnEditarGastoInterno = new System.Windows.Forms.Button();
            this.lstvGastosInternos = new System.Windows.Forms.ListView();
            this.columnaTipoGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDescripcionGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIngresarGastoInterno = new System.Windows.Forms.Button();
            this.btnEliminarGastoInterno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListadoGastosInternos
            // 
            this.lblListadoGastosInternos.AutoSize = true;
            this.lblListadoGastosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoGastosInternos.Location = new System.Drawing.Point(12, 18);
            this.lblListadoGastosInternos.Name = "lblListadoGastosInternos";
            this.lblListadoGastosInternos.Size = new System.Drawing.Size(320, 29);
            this.lblListadoGastosInternos.TabIndex = 44;
            this.lblListadoGastosInternos.Text = "Listado de gastos internos";
            // 
            // btnEditarGastoInterno
            // 
            this.btnEditarGastoInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarGastoInterno.FlatAppearance.BorderSize = 0;
            this.btnEditarGastoInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGastoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGastoInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGastoInterno.Image")));
            this.btnEditarGastoInterno.Location = new System.Drawing.Point(1055, 12);
            this.btnEditarGastoInterno.Name = "btnEditarGastoInterno";
            this.btnEditarGastoInterno.Size = new System.Drawing.Size(30, 35);
            this.btnEditarGastoInterno.TabIndex = 43;
            this.btnEditarGastoInterno.UseVisualStyleBackColor = false;
            // 
            // lstvGastosInternos
            // 
            this.lstvGastosInternos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaTipoGastoInterno,
            this.columnaValorGastoInterno,
            this.fechaGastoInterno,
            this.columnaDescripcionGastoInterno});
            this.lstvGastosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstvGastosInternos.FullRowSelect = true;
            this.lstvGastosInternos.HideSelection = false;
            this.lstvGastosInternos.Location = new System.Drawing.Point(12, 53);
            this.lstvGastosInternos.MultiSelect = false;
            this.lstvGastosInternos.Name = "lstvGastosInternos";
            this.lstvGastosInternos.Size = new System.Drawing.Size(1160, 398);
            this.lstvGastosInternos.TabIndex = 42;
            this.lstvGastosInternos.UseCompatibleStateImageBehavior = false;
            this.lstvGastosInternos.View = System.Windows.Forms.View.Details;
            // 
            // columnaTipoGastoInterno
            // 
            this.columnaTipoGastoInterno.Text = "Tipo de Gasto";
            this.columnaTipoGastoInterno.Width = 289;
            // 
            // columnaValorGastoInterno
            // 
            this.columnaValorGastoInterno.Text = "Valor";
            this.columnaValorGastoInterno.Width = 138;
            // 
            // fechaGastoInterno
            // 
            this.fechaGastoInterno.Text = "Fecha";
            this.fechaGastoInterno.Width = 273;
            // 
            // columnaDescripcionGastoInterno
            // 
            this.columnaDescripcionGastoInterno.Text = "Descripcion";
            this.columnaDescripcionGastoInterno.Width = 456;
            // 
            // btnIngresarGastoInterno
            // 
            this.btnIngresarGastoInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarGastoInterno.FlatAppearance.BorderSize = 0;
            this.btnIngresarGastoInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarGastoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarGastoInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarGastoInterno.Image")));
            this.btnIngresarGastoInterno.Location = new System.Drawing.Point(1127, 9);
            this.btnIngresarGastoInterno.Name = "btnIngresarGastoInterno";
            this.btnIngresarGastoInterno.Size = new System.Drawing.Size(46, 40);
            this.btnIngresarGastoInterno.TabIndex = 41;
            this.btnIngresarGastoInterno.UseVisualStyleBackColor = false;
            // 
            // btnEliminarGastoInterno
            // 
            this.btnEliminarGastoInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGastoInterno.FlatAppearance.BorderSize = 0;
            this.btnEliminarGastoInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGastoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGastoInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGastoInterno.Image")));
            this.btnEliminarGastoInterno.Location = new System.Drawing.Point(1091, 12);
            this.btnEliminarGastoInterno.Name = "btnEliminarGastoInterno";
            this.btnEliminarGastoInterno.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarGastoInterno.TabIndex = 40;
            this.btnEliminarGastoInterno.UseVisualStyleBackColor = false;
            // 
            // GastoInternoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 463);
            this.Controls.Add(this.lblListadoGastosInternos);
            this.Controls.Add(this.btnEditarGastoInterno);
            this.Controls.Add(this.lstvGastosInternos);
            this.Controls.Add(this.btnIngresarGastoInterno);
            this.Controls.Add(this.btnEliminarGastoInterno);
            this.Name = "GastoInternoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastoInternoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblListadoGastosInternos;
        public System.Windows.Forms.Button btnEditarGastoInterno;
        public System.Windows.Forms.ListView lstvGastosInternos;
        public System.Windows.Forms.Button btnIngresarGastoInterno;
        public System.Windows.Forms.Button btnEliminarGastoInterno;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoInterno;
        private System.Windows.Forms.ColumnHeader columnaValorGastoInterno;
        private System.Windows.Forms.ColumnHeader fechaGastoInterno;
        private System.Windows.Forms.ColumnHeader columnaDescripcionGastoInterno;
    }
}