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
    public partial class IngresoContratoView : Form
    {
        private static IngresoContratoView instancia = null;

        public IngresoContratoView()
        {
            InitializeComponent();
            IngresoContratoController ingresoContratoController = new IngresoContratoController(this);
        }

        public static IngresoContratoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new IngresoContratoView();
            }
            return instancia;
        }
    }
}
