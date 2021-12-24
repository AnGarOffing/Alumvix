using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumvix.Controller;

namespace Alumvix.View.Cliente
{
    public partial class DetalleClienteView : Form
    {
        public DetalleClienteView()
        {
            InitializeComponent();
            ClienteController clienteController = new ClienteController(this);
        }
    }
}
