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
        public ProveedorController(ProveedorView ProveedoresVista)
        {
            proveedorView = ProveedoresVista;
            proveedorView.Activated += new EventHandler(MostrarProveedores);
            proveedorView.btnIngresarProveedor.Click += new EventHandler(AbrirIngresoProveedorView);
        }

        private void AbrirIngresoProveedorView(object sender, EventArgs e)
        {
            IngresoProveedorView ingresoProveedorView = IngresoProveedorView.ObtenerInstancia();
            ingresoProveedorView.ShowDialog();
        }

        private void MostrarProveedores(object sender, EventArgs e)
        {
            proveedorView.lstvProveedores.Items.Clear();
            foreach (ProveedorDto proveedor in new ProveedorDao().ObtenerProveedores())
            {
                string[] row = { proveedor.NombreProveedor, proveedor.CelularProveedor, proveedor.TelefonoFijoProveedor, proveedor.DireccionProveedor};
                ListViewItem itemContrato = new ListViewItem(row);
                proveedorView.lstvProveedores.Items.Add(itemContrato);
            }
        }
    }
}
