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
    public partial class EditarAbonoView : Form
    {
        private static EditarAbonoView instancia = null;

        public EditarAbonoView()
        {
            InitializeComponent();
            EditarAbonoController editarAbonoController = new EditarAbonoController(this);
        }

        public static EditarAbonoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new EditarAbonoView();
            }
            return instancia;
        }

        
    }
}
