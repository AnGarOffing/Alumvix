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
    public partial class GastosContratosView : Form
    {
        private static GastosContratosView instancia = null;
        public GastosContratosView()
        {
            InitializeComponent();
            GastosContratosController gastosContratosController = new GastosContratosController(this);
        }

        public static GastosContratosView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GastosContratosView();
            }
            return instancia;
        }
    }
}
