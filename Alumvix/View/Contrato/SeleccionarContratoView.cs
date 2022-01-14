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
    public partial class SeleccionarContratoView : Form
    {
        private static SeleccionarContratoView instancia = null;
        public SeleccionarContratoView()
        {
            InitializeComponent();
            SeleccionarContratoController seleccionarContratoController = new SeleccionarContratoController(this);  
        }

        public static SeleccionarContratoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new SeleccionarContratoView();
            }
            return instancia;
        }
    }
}
