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
    public partial class IngresoGastoView : Form
    {

        private static IngresoGastoView instancia = null;
        public IngresoGastoView()
        {
            InitializeComponent();
            IngresoGastoController ingresoGastoController = new IngresoGastoController(this);
        }

        public static IngresoGastoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new IngresoGastoView();
            }
            return instancia;
        }
    }
}
