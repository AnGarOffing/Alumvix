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
    public partial class IngresoAbonoView : Form
    {

        private static IngresoAbonoView instancia = null;

        private IngresoAbonoView()
        {
            InitializeComponent();
        }

        public static IngresoAbonoView ObtenerInstancia() 
        {
            if (instancia == null)
            {
                instancia = new IngresoAbonoView();
            }
            return instancia;
        }


    }
}
