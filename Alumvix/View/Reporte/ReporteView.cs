using Alumvix.Controller.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Reporte
{
    public partial class ReporteView : Form
    {
        private static ReporteView instancia = null;
        public ReporteView()
        {
            InitializeComponent();
            ReporteController reporteController = new ReporteController(this);
        }

        public static ReporteView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ReporteView();
            }
            return instancia;
        }
    }
}
