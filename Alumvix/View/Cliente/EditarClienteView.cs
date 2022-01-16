using Alumvix.Controller.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Cliente
{
    public partial class EditarClienteView : Form
    {

        private static EditarClienteView instancia = null;
        public EditarClienteView()
        {
            InitializeComponent();
            EditarClienteController editarClienteController = new EditarClienteController(this);
        }

        public static EditarClienteView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarClienteView();
            }
            return instancia;
        }
    }
}
