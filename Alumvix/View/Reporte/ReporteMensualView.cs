using Alumvix.Controller.Reporte;
using Alumvix.Model.Negocio.Util;
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
    public partial class ReporteMensualView : Form
    {
        private static ReporteMensualView instancia = null;
        public ReporteMensualView()
        {
            InitializeComponent();
            ReporteMensualController reporteMensualController = new ReporteMensualController(this);
            CopyPasteEnReporteMensual copyPasteEnReporteMensualView = new CopyPasteEnReporteMensual(this);
        }

        public static ReporteMensualView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ReporteMensualView();
            }
            return instancia;
        }
    }
}
