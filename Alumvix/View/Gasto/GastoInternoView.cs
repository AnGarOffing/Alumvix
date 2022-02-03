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
    public partial class GastoInternoView : Form
    {
        private static GastoInternoView instancia = null;
        public GastoInternoView()
        {
            InitializeComponent();
            GastoInternoController gastoInternoController = new GastoInternoController(this);
        }

        public static GastoInternoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GastoInternoView();
            }
            return instancia;
        }
    }
}
