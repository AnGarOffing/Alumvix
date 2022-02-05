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
    public partial class ReportePorPeriodoView : Form
    {
        private static ReportePorPeriodoView instancia = null;
        public ReportePorPeriodoView()
        {
            InitializeComponent();
            ReportePorPeriodoController reportePorPeriodoController = new ReportePorPeriodoController(this);
        }

        public static ReportePorPeriodoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ReportePorPeriodoView();
            }
            return instancia;
        }
    }
}
