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
    public partial class DetalleAbonoView : Form
    {

        private static DetalleAbonoView instancia = null;

        public DetalleAbonoView()
        {
            InitializeComponent();
            AbonoController abonoController = new AbonoController(this);
        }

        public static DetalleAbonoView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new DetalleAbonoView();
            }
            return instancia;
        }
    }
}
