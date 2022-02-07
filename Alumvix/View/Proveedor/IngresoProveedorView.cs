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
    public partial class IngresoProveedorView : Form
    {
        private static IngresoProveedorView instancia = null;
        public IngresoProveedorView()
        {
            InitializeComponent();
            IngresoProveedorController ingresoProveedorController = new IngresoProveedorController(this);
        }

        public static IngresoProveedorView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new IngresoProveedorView();
            }
            return instancia;
        }
    }
}
