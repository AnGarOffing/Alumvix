using Alumvix.Controller.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.View.Login
{
    public partial class LoginView : Form
    {
        private static LoginView instancia = null;
        public LoginView()
        {
            InitializeComponent();
            LoginController loginController = new LoginController(this);
        }

        public static LoginView ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new LoginView();
            }
            return instancia;
        }
    }
}
