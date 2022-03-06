using Alumvix.Controller.Abono;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Abono
{
    public partial class ActualizarAbonoView : Form
    {
        private static ActualizarAbonoView instancia = null;

        public ActualizarAbonoView()
        {
            InitializeComponent();
            EditarAbonoController editarAbonoController = new EditarAbonoController(this);
        }

        public static ActualizarAbonoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ActualizarAbonoView();
            }
            return instancia;
        }

        
    }
}
