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
    public partial class EditarValorIVAView : Form
    {
        private static EditarValorIVAView instancia = null;

        public EditarValorIVAView()
        {
            InitializeComponent();
            EditarValorIVAController editarValorIVAController = new EditarValorIVAController(this);
        }

        public static EditarValorIVAView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarValorIVAView();
            }
            return instancia;
        }

        
    }
}
