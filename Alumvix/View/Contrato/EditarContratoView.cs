using Alumvix.Controller.Contrato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Contrato
{
    public partial class EditarContratoView : Form
    {

        private static EditarContratoView instancia = null;

        public EditarContratoView()
        {
            InitializeComponent();
            EditarContratoController editarContratoController = new EditarContratoController(this);
        }

        public static EditarContratoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarContratoView();
            }
            return instancia;
        }
    }
}
