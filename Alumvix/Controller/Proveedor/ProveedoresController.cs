using Alumvix.Controller.Login;
using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View;
using Alumvix.View.Login;
using Alumvix.View.Proveedor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Proveedor
{
    internal class ProveedoresController
    {
        static ProveedoresView proveedoresView;
        ClienteView clienteView;
        LoginView loginView;
        static List<int> idsProveedores = new List<int>();
        int indice;
        static int idProveedor;

        public static int IdProveedor { get => idProveedor; set => idProveedor = value; }

        public ProveedoresController(ProveedoresView ProveedoresVista)
        {
            proveedoresView = ProveedoresVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            loginView = LoginController.ObtenerInstanciaLoginView(); 
            proveedoresView.Activated += new EventHandler(MostrarProveedores);
            proveedoresView.btnIngresarProveedor.Click += new EventHandler(AbrirIngresoProveedorView);
            proveedoresView.lstvProveedores.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            proveedoresView.btnCerrarProveedorView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            proveedoresView.btnCerrarProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            proveedoresView.btnCerrarProveedorView.Click += new EventHandler(CerrarIngresoGastoInternoView);
            proveedoresView.btnMinimizarProveedorView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            proveedoresView.btnMinimizarProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            proveedoresView.btnMinimizarProveedorView.Click += new EventHandler(MinimizarIngresoGastoInternoView);
            proveedoresView.btnEliminarProveedor.Click += new EventHandler(EliminarProveedor);
            proveedoresView.btnEditarProveedor.Click += new EventHandler(AbrirEditarProveedorView);
            proveedoresView.btnCerrarSesionProveedores.Click += new EventHandler(CerrarSesion);
            proveedoresView.btnCerrarSesionProveedores.MouseHover += new EventHandler(ResaltarBotonCerrarSesion);
            proveedoresView.btnCerrarSesionProveedores.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrarSesion);
        }

        private void QuitarResaltadoBotonCerrarSesion(object sender, EventArgs e)
        {
            proveedoresView.btnCerrarSesionProveedores.BackColor = Color.Transparent;
        }

        private void ResaltarBotonCerrarSesion(object sender, EventArgs e)
        {
            proveedoresView.btnCerrarSesionProveedores.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void CerrarSesion(object sender, EventArgs e)
        {
            proveedoresView.Hide();
            clienteView.Hide();
            loginView.Show();
        }

        private void MinimizarIngresoGastoInternoView(object sender, EventArgs e)
        {
            proveedoresView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoInternoView(object sender, EventArgs e)
        {
            proveedoresView.Hide();
            clienteView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            proveedoresView.btnCerrarProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            proveedoresView.btnCerrarProveedorView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            proveedoresView.btnMinimizarProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            proveedoresView.btnMinimizarProveedorView.BackColor = Color.Transparent;
        }


            private void AbrirEditarProveedorView(object sender, EventArgs e)
        {
            if (proveedoresView.lstvProveedores.SelectedItems.Count > 0)
            {
                EditarProveedorView editarProveedorView = EditarProveedorView.ObtenerInstancia();
                proveedoresView.Hide();
                editarProveedorView.Show();
            }else MessageBox.Show("No ha seleccionado un proveedor");
        }

        private void ObtenerIndice(object sender, EventArgs e)
        {
            if (proveedoresView.lstvProveedores.SelectedItems.Count > 0)
            {
                indice = proveedoresView.lstvProveedores.Items.IndexOf(proveedoresView.lstvProveedores.SelectedItems[0]);
                IdProveedor = EncontrarIdProveedor(idsProveedores, indice);
            }
        }

        private int EncontrarIdProveedor(List<int> idsProveedores, int indice)
        {
            return idsProveedores[indice];
        }

        private void EliminarProveedor(object sender, EventArgs e)
        {
            if (proveedoresView.lstvProveedores.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el proveedor?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool respuesta = new ProveedorDao().EliminarProveedor(IdProveedor);
                    if (respuesta)
                    {
                        proveedoresView.lstvProveedores.SelectedItems.Clear();
                        MessageBox.Show("El proveedor ha sido eliminado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar el proveedor");
                    }
                }
            }
            else MessageBox.Show("No ha seleccionado un proveedor");
        }

        private void AbrirIngresoProveedorView(object sender, EventArgs e)
        {
            IngresoProveedorView ingresoProveedorView = IngresoProveedorView.ObtenerInstancia();
            proveedoresView.Hide();
            ingresoProveedorView.Show();
        }

        private void MostrarProveedores(object sender, EventArgs e)
        {
            proveedoresView.lstvProveedores.Items.Clear();
            idsProveedores.Clear();
            foreach (ProveedorDto proveedor in new ProveedorDao().ObtenerProveedores())
            {
                idsProveedores.Add(proveedor.IdProveedor);
                string[] row = { proveedor.NombreProveedor, proveedor.CelularProveedor, proveedor.TelefonoFijoProveedor, proveedor.DireccionProveedor};
                ListViewItem itemContrato = new ListViewItem(row);
                proveedoresView.lstvProveedores.Items.Add(itemContrato);
            }
        }

        public static ProveedoresView ObtenerInstancia()
        {
            return proveedoresView;
        }
    }
}
