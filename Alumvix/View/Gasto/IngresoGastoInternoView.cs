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
    public partial class IngresoGastoInternoView : Form
    {
        private static IngresoGastoInternoView instancia = null;
        public IngresoGastoInternoView()
        {
            InitializeComponent();
            IngresoGastoInternoController ingresoGastoInternoController = new IngresoGastoInternoController(this);
        }

        public static IngresoGastoInternoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new IngresoGastoInternoView();
            }
            return instancia;
        }
    }
}
