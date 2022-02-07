using Alumvix.Model.Dao;
using Alumvix.Model.Dto;
using Alumvix.View.Proveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Proveedor
{
    internal class ProveedorController
    {
        ProveedorView proveedorView;
        static List<int> idsProveedores = new List<int>();
        int indice;
        static int idProveedor;

        public ProveedorController(ProveedorView ProveedoresVista)
        {
            proveedorView = ProveedoresVista;
            proveedorView.Activated += new EventHandler(MostrarProveedores);
            proveedorView.btnIngresarProveedor.Click += new EventHandler(AbrirIngresoProveedorView);
            proveedorView.lstvProveedores.SelectedIndexChanged += new EventHandler(ObtenerIndice);
            proveedorView.btnEliminarProveedor.Click += new EventHandler(EliminarProveedor);
        }

        private void ObtenerIndice(object sender, EventArgs e)
        {
            if (proveedorView.lstvProveedores.SelectedItems.Count > 0)
            {
                indice = proveedorView.lstvProveedores.Items.IndexOf(proveedorView.lstvProveedores.SelectedItems[0]);
                idProveedor = EncontrarIdProveedor(idsProveedores, indice);
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
                    bool respuesta = new ProveedorDao().EliminarProveedor(idProveedor);
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
            else MessageBox.Show("Debe seleccionar un proveedor de la lista");
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
    }
}
