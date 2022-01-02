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
    public partial class DetalleGastoView : Form
    {

        private static DetalleGastoView instancia = null;

        public DetalleGastoView()
        {
            InitializeComponent();
            DetalleGastoController detalleGastoController = new DetalleGastoController(this);
        }

        public static DetalleGastoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new DetalleGastoView();
            }
            return instancia;
        }
    }
}
