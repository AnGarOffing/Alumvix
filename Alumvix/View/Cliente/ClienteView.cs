﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumvix.Controller;

namespace Alumvix.View
{
    public partial class ClienteView : Form
    {

        private static ClienteView instancia = null;
        public ClienteView()
        {
            InitializeComponent();
            ClienteController clienteController = new ClienteController(this);
        }

        public static ClienteView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new ClienteView();
            }
            return instancia;
        }
    }
}
