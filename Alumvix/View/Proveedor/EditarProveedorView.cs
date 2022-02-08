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
    public partial class EditarProveedorView : Form
    {
        private static EditarProveedorView instancia = null;
        public EditarProveedorView()
        {
            InitializeComponent();
            EditarProveedorController editarProveedorController = new EditarProveedorController(this);
        }

        public static EditarProveedorView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarProveedorView();
            }
            return instancia;
        }
    }
}
