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
    public partial class AdministradorReportesView : Form
    {
        private static AdministradorReportesView instancia = null;
        public AdministradorReportesView()
        {
            InitializeComponent();
            AdministradorReportesController reporteController = new AdministradorReportesController(this);
        }

        public static AdministradorReportesView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AdministradorReportesView();
            }
            return instancia;
        }
    }
}
