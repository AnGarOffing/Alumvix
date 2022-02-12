using Alumvix.Model.Dao;
using Alumvix.Model.Logica.Util;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Gasto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Gasto
{
    internal class EditarGastoInternoController
    {
        EditarGastoInternoView editarGastoInternoView;
        GastoInternoView gastoInternoView;

        public EditarGastoInternoController(EditarGastoInternoView editarGastoInternoVista)
        {
            editarGastoInternoView = editarGastoInternoVista;
            gastoInternoView = GastoInternoController.ObtenerInstancia();
            editarGastoInternoView.Activated += new EventHandler(CargarDatos);
            editarGastoInternoView.txtEditarValorGastoInterno.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            editarGastoInternoView.btnCerrarActualizarGastoInternoView.MouseHover += new EventHandler(ResaltarBotonCerrar);
            editarGastoInternoView.btnCerrarActualizarGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonCerrar);
            editarGastoInternoView.btnCerrarActualizarGastoInternoView.Click += new EventHandler(CerrarIngresoGastoInternoView);
            editarGastoInternoView.btnMinimizarActualizarGastoInternoView.MouseHover += new EventHandler(ResaltarBotonMinimizar);
            editarGastoInternoView.btnMinimizarActualizarGastoInternoView.MouseLeave += new EventHandler(QuitarResaltadoBotonMinimizar);
            editarGastoInternoView.btnMinimizarActualizarGastoInternoView.Click += new EventHandler(MinimizarIngresoGastoInternoView);
            editarGastoInternoView.btnActualizarGastoInterno.Click += new EventHandler(ActualizarGastoInterno);
        }

        private void MinimizarIngresoGastoInternoView(object sender, EventArgs e)
        {
            editarGastoInternoView.WindowState = FormWindowState.Minimized;
        }

        private void CerrarIngresoGastoInternoView(object sender, EventArgs e)
        {
            editarGastoInternoView.Hide();
            gastoInternoView.Show();
        }

        private void ResaltarBotonCerrar(object sender, EventArgs e)
        {
            editarGastoInternoView.btnCerrarActualizarGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonCerrar(object sender, EventArgs e)
        {
            editarGastoInternoView.btnCerrarActualizarGastoInternoView.BackColor = Color.Transparent;
        }

        private void ResaltarBotonMinimizar(object sender, EventArgs e)
        {
            editarGastoInternoView.btnMinimizarActualizarGastoInternoView.BackColor = Color.FromArgb(223, 240, 254);
        }

        private void QuitarResaltadoBotonMinimizar(object sender, EventArgs e)
        {
            editarGastoInternoView.btnMinimizarActualizarGastoInternoView.BackColor = Color.Transparent;
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void ActualizarGastoInterno(object sender, EventArgs e)
        {
            bool respuesta = false;
            GastoInternoDao gastoActualizado = new GastoInternoDao();
            respuesta = ValidacionesDeControles.ValidarBotonIngresoGastoInterno(editarGastoInternoView.txtEditarValorGastoInterno.Text, editarGastoInternoView.cbEditarTipoGastoInterno.SelectedIndex);
            if (respuesta)
            {
                int idTipoGastoInterno = gastoActualizado.ObtenerTipoGastoInternoPorNombre(editarGastoInternoView.cbEditarTipoGastoInterno.GetItemText(editarGastoInternoView.cbEditarTipoGastoInterno.SelectedItem));
                string valorSinFormato = CambioDeFormato.QuitarFormatoANumero(editarGastoInternoView.txtEditarValorGastoInterno.Text);
                bool respuestaIngresoGastoInterno = gastoActualizado.ActualizarGastoInterno(Convert.ToInt32(valorSinFormato), editarGastoInternoView.dtpEditarFechaGastoInterno.Text, editarGastoInternoView.txtEditarDescripcionGastoInterno.Text, idTipoGastoInterno);
                if (respuestaIngresoGastoInterno)
                {
                    editarGastoInternoView.Hide();
                    MessageBox.Show("El gasto ha sido actualizado con exito");
                    gastoInternoView.Show();
                }
                else MessageBox.Show("Error al actualizar el gasto");
            }
            else
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
        }

        private void CargarDatos(object sender, EventArgs e)
        {
            GastoInternoDao tipoGastoInterno = new GastoInternoDao();
            editarGastoInternoView.cbEditarTipoGastoInterno.DataSource = tipoGastoInterno.ObtenerTiposDeGastoInterno();
            editarGastoInternoView.cbEditarTipoGastoInterno.DropDownStyle = ComboBoxStyle.DropDownList;
            editarGastoInternoView.cbEditarTipoGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[0].Text;
            editarGastoInternoView.txtEditarValorGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[1].Text;
            editarGastoInternoView.txtEditarDescripcionGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[3].Text;
            editarGastoInternoView.dtpEditarFechaGastoInterno.Text = gastoInternoView.lstvGastosInternos.SelectedItems[0].SubItems[2].Text;
        }
    }
}
