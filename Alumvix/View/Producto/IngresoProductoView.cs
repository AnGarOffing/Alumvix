using Alumvix.Controller.Producto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Producto
{
    public partial class IngresoProductoView : Form
    {
        private static IngresoProductoView instancia = null;

        public IngresoProductoView()
        {
            InitializeComponent();
            IngresoProductoController ingresoProductoController = new IngresoProductoController(this);
        }

        public static IngresoProductoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new IngresoProductoView();
            }
            return instancia;
        }
    }
}
