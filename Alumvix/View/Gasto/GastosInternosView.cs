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
    public partial class GastosInternosView : Form
    {
        private static GastosInternosView instancia = null;
        public GastosInternosView()
        {
            InitializeComponent();
            GastosInternosController gastoInternoController = new GastosInternosController(this);
        }

        public static GastosInternosView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new GastosInternosView();
            }
            return instancia;
        }
    }
}
