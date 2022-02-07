using Alumvix.Controller.Proveedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Proveedor
{
    public partial class ProveedorView : Form
    {
        private static ProveedorView instancia = null;
        public ProveedorView()
        {
            InitializeComponent();
            ProveedorController proveedoresController = new ProveedorController(this);
        }
        public static ProveedorView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ProveedorView();
            }
            return instancia;
        }
    }
}
