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
    public partial class ProveedoresView : Form
    {
        private static ProveedoresView instancia = null;
        public ProveedoresView()
        {
            InitializeComponent();
            ProveedoresController proveedoresController = new ProveedoresController(this);
        }
        public static ProveedoresView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ProveedoresView();
            }
            return instancia;
        }
    }
}
