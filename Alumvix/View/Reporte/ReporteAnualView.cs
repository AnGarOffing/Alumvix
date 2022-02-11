using Alumvix.Controller.Reporte;
using Alumvix.Model.Negocio.Util.CopyPaste;
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
    public partial class ReporteAnualView : Form
    {
        private static ReporteAnualView instancia = null;
        public ReporteAnualView()
        {
            InitializeComponent();
            ReporteAnualController reporteAnualController = new ReporteAnualController(this);
            CopyPasteEnReporteAnualView copyPasteEnReporteAnualView = new CopyPasteEnReporteAnualView(this);
        }

        public static ReporteAnualView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ReporteAnualView();
            }
            return instancia;
        }
    }
}
