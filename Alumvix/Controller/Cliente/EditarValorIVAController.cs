using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.Model.Negocio;
using Alumvix.View;
using Alumvix.View.Cliente;

namespace Alumvix.Controller.Cliente
{
    public class EditarValorIVAController
    {
        EditarValorIVAView editarValorIVAView;
        ClienteView clienteView;

        public EditarValorIVAController(EditarValorIVAView editarValorIVAVista)
        {
            editarValorIVAView = editarValorIVAVista;
            clienteView = ClienteView.ObtenerInstancia();
            editarValorIVAView.Activated += new EventHandler(CargarIVAActual);
            editarValorIVAView.Activated += new EventHandler(LimpiarCampos);
            editarValorIVAView.btnActualizarIVA.Click += new EventHandler(ActualizarIVA);
            editarValorIVAView.btnMinimizarEditarIVAView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarValorIVAView.btnMinimizarEditarIVAView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarValorIVAView.btnCerrarEditarIVAView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarValorIVAView.btnCerrarEditarIVAView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarValorIVAView.pnlSuperiorEditarIVAView.MouseDown += new MouseEventHandler(PermitirMovimientoDeForm);
            editarValorIVAView.btnMinimizarEditarIVAView.Click += new EventHandler(MinimizarEditarIVAView);
            editarValorIVAView.btnCerrarEditarIVAView.Click += new EventHandler(CerrarEditarIVAView);
        }

        private void LimpiarCampos(object sender, EventArgs e)
        {
            editarValorIVAView.txtUsuarioAdmin.Clear();
            editarValorIVAView.txtPasswordAdmin.Clear();
        }

        private void CerrarEditarIVAView(object sender, EventArgs e)
        {
            editarValorIVAView.Hide();
            clienteView.Show();
        }

        private void MinimizarEditarIVAView(object sender, EventArgs e)
        {
            editarValorIVAView.WindowState = FormWindowState.Minimized;
        }

        private void PermitirMovimientoDeForm(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(editarValorIVAView.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarValorIVAView.btnCerrarEditarIVAView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarValorIVAView.btnCerrarEditarIVAView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarValorIVAView.btnMinimizarEditarIVAView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarValorIVAView.btnMinimizarEditarIVAView.BackColor = Color.Transparent;
        }

        private void ActualizarIVA(object sender, EventArgs e)
        {
            UsuarioDto usuarioAdmin;
            if (editarValorIVAView.txtEditarValorIVA.Text == "" ||
                editarValorIVAView.txtUsuarioAdmin.Text == "" ||
                editarValorIVAView.txtPasswordAdmin.Text == "")
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                bool usuarioEncontrado = false;
                UsuarioDao usuarioDao = new UsuarioDao();
                List<UsuarioDto> listadoUsuarios = usuarioDao.ObtenerListadoUsuarios();
                usuarioAdmin = new UsuarioDto();
                foreach (UsuarioDto usuarioDto in listadoUsuarios)
                {
                    if (usuarioDto.Usuario == editarValorIVAView.txtUsuarioAdmin.Text 
                        && usuarioDto.Password == editarValorIVAView.txtPasswordAdmin.Text)
                    {
                        usuarioEncontrado = true;
                        usuarioAdmin = usuarioDto;
                        break;
                    }
                }
                if (usuarioEncontrado)
                {
                    if (usuarioAdmin.Usuario == "Sharina" && usuarioAdmin.Password == "*1039452959@")
                    {
                        Logica logica = new Logica();
                        bool ivaActualizado = logica.ModificarIVA(Convert.ToInt32(
                            editarValorIVAView.txtEditarValorIVA.Text));
                        if (ivaActualizado)
                        {
                            MessageBox.Show("El IVA se ha actualizado con exito");
                            editarValorIVAView.Hide();
                            clienteView.Show();
                        } 
                        else MessageBox.Show("Error al intentar actualizar el IVA, contacte al desarrollador");
                    }
                    else
                    {
                        MessageBox.Show($"El usuario ({usuarioAdmin.Usuario}) no tiene permisos de administrador");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario que intenta loguear no esta registrado en el sistema");
                }
            }
        }

        private void CargarIVAActual(object sender, EventArgs e)
        {
            editarValorIVAView.txtEditarValorIVA.Text = new Logica().ObtenerIVAActual().ToString();
        }
    }
}