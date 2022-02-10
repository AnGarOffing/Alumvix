using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio.Util;
using Alumvix.View;
using Alumvix.View.Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Alumvix.Controller.Login
{
    internal class LoginController
    {
        static LoginView loginView;

        public LoginController(LoginView loginVista)
        {
            loginView = loginVista;
            loginView.Activated += new EventHandler(LimpiarControles);
            loginView.txtUsuario.Enter += new EventHandler(VaciarYResaltarCampoUsuario);
            loginView.txtUsuario.Leave += new EventHandler(EstablecerCampoUsuarioPorDefecto);
            loginView.txtPassword.Enter += new EventHandler(VaciarYResaltarCampoPassword);
            loginView.txtPassword.Leave += new EventHandler(EstablecerCampoPasswordPorDefecto);
            loginView.btnCerrarLogin.Click += new EventHandler(CerrarLogin);
            loginView.btnMinimizarLogin.Click += new EventHandler(MinimizarLogin);
            loginView.btnAcceder.Click += new EventHandler(IniciarSesion);
            loginView.txtUsuario.KeyPress += new KeyPressEventHandler(ValidarEntradaNumerosYLetras);
            loginView.btnVerPassword.Click += new EventHandler(ModificarCaracteresDePassword);
            loginView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
        }

        private void LimpiarControles(object sender, EventArgs e)
        {
            loginView.txtUsuario.Text = "USUARIO";
            loginView.txtPassword.Text = "CONTRASEÑA";
            loginView.txtPassword.UseSystemPasswordChar = false;
        }

        public static LoginView ObtenerInstancia()
        {
            return loginView;
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(loginView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ModificarCaracteresDePassword(object sender, EventArgs e)
        {
            if (loginView.txtPassword.UseSystemPasswordChar == true)
            {
                loginView.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                loginView.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void ValidarEntradaNumerosYLetras(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumerosyLetras(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros y letras");
        }

        private void ValidarCredenciales() { }

        private void IniciarSesion(object sender, EventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarBotonInicioDeSesion(loginView.txtUsuario.Text, loginView.txtPassword.Text);
            if (respuesta)
            {
                bool usuarioEncontrado = false;
                UsuarioDao usuarioDao = new UsuarioDao();
                List<UsuarioDto> listadoUsuarios = usuarioDao.ObtenerListadoUsuarios();
                foreach (UsuarioDto usuarioDto in listadoUsuarios)
                {
                    if (usuarioDto.Usuario == loginView.txtUsuario.Text && usuarioDto.Password == loginView.txtPassword.Text)
                    {
                        usuarioEncontrado = true;
                        break;
                    }
                }
                if (usuarioEncontrado)
                {
                    ClienteView clienteView = ClienteView.ObtenerInstancia();
                    clienteView.Show();
                    loginView.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son incorrectos, verifique nuevamente");
                }
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
        }

        private void MinimizarLogin(object sender, EventArgs e)
        {
            loginView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarLogin(object sender, EventArgs e)
        {
            loginView.Dispose();
            Application.Exit();
        }

        private void EstablecerCampoPasswordPorDefecto(object sender, EventArgs e)
        {
            if (loginView.txtPassword.Text == "")
            {
                loginView.txtPassword.Text = "CONTRASEÑA";
                loginView.txtPassword.ForeColor = Color.FromArgb(223, 240, 254);
                loginView.txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void VaciarYResaltarCampoPassword(object sender, EventArgs e)
        {
            if (loginView.txtPassword.Text == "CONTRASEÑA")
            {
                loginView.txtPassword.Text = "";
                loginView.txtPassword.ForeColor = Color.LightGray;
                loginView.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void EstablecerCampoUsuarioPorDefecto(object sender, EventArgs e)
        {
            if (loginView.txtUsuario.Text == "")
            {
                loginView.txtUsuario.Text = "USUARIO";
                loginView.txtUsuario.ForeColor = Color.FromArgb(223, 240, 254);
            }
        }

        private void VaciarYResaltarCampoUsuario(object sender, EventArgs e)
        {
            if (loginView.txtUsuario.Text == "USUARIO")
            {
                loginView.txtUsuario.Text = "";
                loginView.txtUsuario.ForeColor = Color.LightGray;
            }
        }
    }
}
