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
    public partial class EditarGastoView : Form
    {

        private static EditarGastoView instancia = null;
        public EditarGastoView()
        {
            InitializeComponent();
            EditarGastoController editarGastoController = new EditarGastoController(this);
        }

        public static EditarGastoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarGastoView();
            }
            return instancia;
        }
    }
}
