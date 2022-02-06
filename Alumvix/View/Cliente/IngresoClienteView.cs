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
    public partial class IngresoClienteView : Form
    {
        private static IngresoClienteView instancia = null;
        public IngresoClienteView()
        {
            InitializeComponent();
            IngresoClienteController ingresoClienteController = new IngresoClienteController(this);
        }

        public static IngresoClienteView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new IngresoClienteView();
            }
            return instancia;
        }
    }
}
