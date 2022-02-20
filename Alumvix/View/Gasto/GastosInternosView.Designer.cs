namespace Alumvix.View.Gasto
{
    partial class GastosInternosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GastosInternosView));
            this.lblListadoGastosInternos = new System.Windows.Forms.Label();
            this.btnEditarGastoInterno = new System.Windows.Forms.Button();
            this.lstvGastosInternos = new System.Windows.Forms.ListView();
            this.columnaTipoGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaValorGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaDescripcionGastoInterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminarGastoInterno = new System.Windows.Forms.Button();
            this.pnlSuperiorGastoInternoView = new System.Windows.Forms.Panel();
            this.btnCerrarSesionGastosInternos = new System.Windows.Forms.PictureBox();
            this.btnMinimizarGastoInternoView = new System.Windows.Forms.PictureBox();
            this.btnCerrarGastoInternoView = new System.Windows.Forms.PictureBox();
            this.btnIngresarGastoInterno = new System.Windows.Forms.Button();
            this.pnlSuperiorGastoInternoView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionGastosInternos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarGastoInternoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGastoInternoView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListadoGastosInternos
            // 
            this.lblListadoGastosInternos.AutoSize = true;
            this.lblListadoGastosInternos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoGastosInternos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.lblListadoGastosInternos.Location = new System.Drawing.Point(450, 15);
            this.lblListadoGastosInternos.Name = "lblListadoGastosInternos";
            this.lblListadoGastosInternos.Size = new System.Drawing.Size(260, 29);
            this.lblListadoGastosInternos.TabIndex = 44;
            this.lblListadoGastosInternos.Text = "GASTOS INTERNOS";
            // 
            // btnEditarGastoInterno
            // 
            this.btnEditarGastoInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarGastoInterno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarGastoInterno.FlatAppearance.BorderSize = 0;
            this.btnEditarGastoInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarGastoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarGastoInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGastoInterno.Image")));
            this.btnEditarGastoInterno.Location = new System.Drawing.Point(1055, 66);
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
            this.lstvGastosInternos.Location = new System.Drawing.Point(12, 109);
            this.lstvGastosInternos.MultiSelect = false;
            this.lstvGastosInternos.Name = "lstvGastosInternos";
            this.lstvGastosInternos.Size = new System.Drawing.Size(1160, 415);
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
            // btnEliminarGastoInterno
            // 
            this.btnEliminarGastoInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarGastoInterno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarGastoInterno.FlatAppearance.BorderSize = 0;
            this.btnEliminarGastoInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarGastoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGastoInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarGastoInterno.Image")));
            this.btnEliminarGastoInterno.Location = new System.Drawing.Point(1091, 66);
            this.btnEliminarGastoInterno.Name = "btnEliminarGastoInterno";
            this.btnEliminarGastoInterno.Size = new System.Drawing.Size(30, 35);
            this.btnEliminarGastoInterno.TabIndex = 40;
            this.btnEliminarGastoInterno.UseVisualStyleBackColor = false;
            // 
            // pnlSuperiorGastoInternoView
            // 
            this.pnlSuperiorGastoInternoView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSuperiorGastoInternoView.Controls.Add(this.btnCerrarSesionGastosInternos);
            this.pnlSuperiorGastoInternoView.Controls.Add(this.btnMinimizarGastoInternoView);
            this.pnlSuperiorGastoInternoView.Controls.Add(this.btnCerrarGastoInternoView);
            this.pnlSuperiorGastoInternoView.Controls.Add(this.lblListadoGastosInternos);
            this.pnlSuperiorGastoInternoView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperiorGastoInternoView.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorGastoInternoView.Name = "pnlSuperiorGastoInternoView";
            this.pnlSuperiorGastoInternoView.Size = new System.Drawing.Size(1184, 59);
            this.pnlSuperiorGastoInternoView.TabIndex = 45;
            // 
            // btnCerrarSesionGastosInternos
            // 
            this.btnCerrarSesionGastosInternos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesionGastosInternos.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesionGastosInternos.Image")));
            this.btnCerrarSesionGastosInternos.Location = new System.Drawing.Point(1064, 11);
            this.btnCerrarSesionGastosInternos.Name = "btnCerrarSesionGastosInternos";
            this.btnCerrarSesionGastosInternos.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarSesionGastosInternos.TabIndex = 49;
            this.btnCerrarSesionGastosInternos.TabStop = false;
            // 
            // btnMinimizarGastoInternoView
            // 
            this.btnMinimizarGastoInternoView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizarGastoInternoView.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarGastoInternoView.Image")));
            this.btnMinimizarGastoInternoView.Location = new System.Drawing.Point(1107, 14);
            this.btnMinimizarGastoInternoView.Name = "btnMinimizarGastoInternoView";
            this.btnMinimizarGastoInternoView.Size = new System.Drawing.Size(33, 30);
            this.btnMinimizarGastoInternoView.TabIndex = 46;
            this.btnMinimizarGastoInternoView.TabStop = false;
            // 
            // btnCerrarGastoInternoView
            // 
            this.btnCerrarGastoInternoView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarGastoInternoView.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarGastoInternoView.Image")));
            this.btnCerrarGastoInternoView.Location = new System.Drawing.Point(1149, 14);
            this.btnCerrarGastoInternoView.Name = "btnCerrarGastoInternoView";
            this.btnCerrarGastoInternoView.Size = new System.Drawing.Size(33, 30);
            this.btnCerrarGastoInternoView.TabIndex = 45;
            this.btnCerrarGastoInternoView.TabStop = false;
            // 
            // btnIngresarGastoInterno
            // 
            this.btnIngresarGastoInterno.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarGastoInterno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarGastoInterno.FlatAppearance.BorderSize = 0;
            this.btnIngresarGastoInterno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresarGastoInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarGastoInterno.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresarGastoInterno.Image")));
            this.btnIngresarGastoInterno.Location = new System.Drawing.Point(1127, 64);
            this.btnIngresarGastoInterno.Name = "btnIngresarGastoInterno";
            this.btnIngresarGastoInterno.Size = new System.Drawing.Size(37, 39);
            this.btnIngresarGastoInterno.TabIndex = 46;
            this.btnIngresarGastoInterno.UseVisualStyleBackColor = false;
            // 
            // GastosInternosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1184, 536);
            this.Controls.Add(this.btnIngresarGastoInterno);
            this.Controls.Add(this.pnlSuperiorGastoInternoView);
            this.Controls.Add(this.btnEditarGastoInterno);
            this.Controls.Add(this.lstvGastosInternos);
            this.Controls.Add(this.btnEliminarGastoInterno);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GastosInternosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastoInternoView";
            this.pnlSuperiorGastoInternoView.ResumeLayout(false);
            this.pnlSuperiorGastoInternoView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesionGastosInternos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarGastoInternoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarGastoInternoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblListadoGastosInternos;
        public System.Windows.Forms.Button btnEditarGastoInterno;
        public System.Windows.Forms.ListView lstvGastosInternos;
        public System.Windows.Forms.Button btnEliminarGastoInterno;
        private System.Windows.Forms.ColumnHeader columnaTipoGastoInterno;
        private System.Windows.Forms.ColumnHeader columnaValorGastoInterno;
        private System.Windows.Forms.ColumnHeader fechaGastoInterno;
        private System.Windows.Forms.ColumnHeader columnaDescripcionGastoInterno;
        public System.Windows.Forms.PictureBox btnMinimizarGastoInternoView;
        public System.Windows.Forms.PictureBox btnCerrarGastoInternoView;
        public System.Windows.Forms.Button btnIngresarGastoInterno;
        public System.Windows.Forms.PictureBox btnCerrarSesionGastosInternos;
        public System.Windows.Forms.Panel pnlSuperiorGastoInternoView;
    }
}