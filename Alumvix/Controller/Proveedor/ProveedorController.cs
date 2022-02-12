using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View;
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
    internal class ProveedorController
    {
        static ProveedoresView proveedorView;
        ClienteView clienteView;
        static List<int> idsProveedores = new List<int>();
        int indice;
        static int idProveedor;

        public static int IdProveedor { get => idProveedor; set => idProveedor = value; }

        public ProveedorController(ProveedoresView ProveedoresVista)
        {
            proveedorView = ProveedoresVista;
            clienteView = ClienteController.ObtenerInstanciaClienteView();
            proveedorView.Activated += new EventHandler(MostrarProveedores);
            proveedorView.btnIngresarProveedor.Click += new EventHandler(AbrirIngresoProveedorView);
            proveedorView.lstvProveedores.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            proveedorView.btnCerrarProveedorView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            proveedorView.btnCerrarProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            proveedorView.btnCerrarProveedorView.Click += new EventHandler(CerrarIngresoGastoInternoView);
            proveedorView.btnMinimizarProveedorView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            proveedorView.btnMinimizarProveedorView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            proveedorView.btnMinimizarProveedorView.Click += new EventHandler(MinimizarIngresoGastoInternoView);
            proveedorView.btnEliminarProveedor.Click += new EventHandler(EliminarProveedor);
            proveedorView.btnEditarProveedor.Click += new EventHandler(AbrirEditarProveedorView);
        }

        private void MinimizarIngresoGastoInternoView(object sender, EventArgs e)
        {
            proveedorView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoInternoView(object sender, EventArgs e)
        {
            proveedorView.Hide();
            clienteView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            proveedorView.btnCerrarProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            proveedorView.btnCerrarProveedorView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            proveedorView.btnMinimizarProveedorView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            proveedorView.btnMinimizarProveedorView.BackColor = Color.Transparent;
        }


            private void AbrirEditarProveedorView(object sender, EventArgs e)
        {
            if (proveedorView.lstvProveedores.SelectedItems.Count > 0)
            {
                EditarProveedorView editarProveedorView = EditarProveedorView.ObtenerInstancia();
                editarProveedorView.ShowDialog();
            }else MessageBox.Show("No ha seleccionado un proveedor");
        }

        private void ObtenerIndice(object sender, EventArgs e)
        {
            if (proveedorView.lstvProveedores.SelectedItems.Count > 0)
            {
                indice = proveedorView.lstvProveedores.Items.IndexOf(proveedorView.lstvProveedores.SelectedItems[0]);
                IdProveedor = EncontrarIdProveedor(idsProveedores, indice);
            }
        }

        private int EncontrarIdProveedor(List<int> idsProveedores, int indice)
        {
            return idsProveedores[indice];
        }

        private void EliminarProveedor(object sender, EventArgs e)
        {
            if (proveedorView.lstvProveedores.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("¿Realmente desea borrar el proveedor?", "BORRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool respuesta = new ProveedorDao().EliminarProveedor(IdProveedor);
                    if (respuesta)
                    {
                        proveedorView.lstvProveedores.SelectedItems.Clear();
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
            ingresoProveedorView.ShowDialog();
        }

        private void MostrarProveedores(object sender, EventArgs e)
        {
            proveedorView.lstvProveedores.Items.Clear();
            idsProveedores.Clear();
            foreach (ProveedorDto proveedor in new ProveedorDao().ObtenerProveedores())
            {
                idsProveedores.Add(proveedor.IdProveedor);
                string[] row = { proveedor.NombreProveedor, proveedor.CelularProveedor, proveedor.TelefonoFijoProveedor, proveedor.DireccionProveedor};
                ListViewItem itemContrato = new ListViewItem(row);
                proveedorView.lstvProveedores.Items.Add(itemContrato);
            }
        }

        public static ProveedoresView ObtenerInstancia()
        {
            return proveedorView;
        }
    }
}
