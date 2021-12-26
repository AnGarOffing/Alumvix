using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumvix.Controller;
using Alumvix.Controller.Cliente;
using Alumvix.Model.Logica.Util;

namespace Alumvix.View.Cliente
{
    public partial class DetalleClienteView : Form
    {
        public DetalleClienteView()
        {
            InitializeComponent();
            DetalleClienteController detalleClienteController = new DetalleClienteController(this);
            CopyPasteEnDetalleClienteVista copyPasteEnDetalleClienteVista = new CopyPasteEnDetalleClienteVista(this);
        }

        
    }
}
