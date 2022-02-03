using Alumvix.Controller.Gasto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Gasto
{
    public partial class GastosPorPeriodoView : Form
    {
        private static GastosPorPeriodoView instancia = null;

        public GastosPorPeriodoView()
        {
            InitializeComponent();
            GastosPorPeriodoController gastosPorPeriodoController = new GastosPorPeriodoController(this);
        }

        public static GastosPorPeriodoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GastosPorPeriodoView();
            }
            return instancia;
        }
    }
}
