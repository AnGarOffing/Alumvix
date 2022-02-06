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
    public partial class EditarGastoInternoView : Form
    {
        private static EditarGastoInternoView instancia = null;
        public EditarGastoInternoView()
        {
            InitializeComponent();
            EditarGastoInternoController editarGastoInternoController = new EditarGastoInternoController(this);
        }

        public static EditarGastoInternoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarGastoInternoView();
            }
            return instancia;
        }
    }
}
