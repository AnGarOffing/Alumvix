using Alumvix.Model.Dao;
using Alumvix.Model.Negocio;
using Alumvix.Model.Negocio.Util;
using Alumvix.View.Cliente;
using Alumvix.View.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumvix.Controller.Contrato
{
    internal class IngresoContratoController
    {
        IngresoContratoView ingresoContratoView;
        public IngresoContratoController(IngresoContratoView ingresoContratoVista)
        {
            ingresoContratoView = ingresoContratoVista;
            ingresoContratoView.Load += new EventHandler(CargarTiposFactura);
            ingresoContratoView.txtIngresarValorContrato.KeyPress += new KeyPressEventHandler(ValidarEntradaNumeros);
            ingresoContratoView.btnGuardarNuevoContrato.Click += new EventHandler(GuardarContrato);
        }

        private void ValidarEntradaNumeros(object sender, KeyPressEventArgs e)
        {
            bool respuesta = ValidacionesDeControles.ValidarEntradaNumeros(e);
            if (respuesta == true) MessageBox.Show("El campo solo permite numeros");
        }

        private void GuardarContrato(object sender, EventArgs e)
        {
            if (ValidacionesDeControles.ValidarBotonIngresoContrato(ingresoContratoView.txtIngresarValorContrato.Text, ingresoContratoView.cbIngresarTipoFactura.SelectedIndex) == false)
            {
                MessageBox.Show("Debe diligenciar todos los campos");
            }
            else
            {
                if (ingresoContratoView.dtpFechaTerminacionContrato.Value.Date <= ingresoContratoView.dtpFechaInicioContrato.Value.Date)
                {
                    MessageBox.Show("La fecha de Terminacion no puede ser inferior a la fecha de inicio");
                }
                else
                {
                    int valorContratoCalculado;
                    ContratoDao contratoDao = new ContratoDao();
                    if (ingresoContratoView.cbIngresarTipoFactura.SelectedIndex == 1)
                    {
                        valorContratoCalculado = Logica.AplicarIVA(Convert.ToInt32(ingresoContratoView.txtIngresarValorContrato.Text), 1);
                    }
                    else valorContratoCalculado = Convert.ToInt32(ingresoContratoView.txtIngresarValorContrato.Text);

                    bool respuestaIngresoContrato = contratoDao.GuardarContrato(valorContratoCalculado, ingresoContratoView.dtpFechaInicioContrato.Text, ingresoContratoView.dtpFechaTerminacionContrato.Text, 1, 1, ingresoContratoView.cbIngresarTipoFactura.SelectedIndex, ClienteController.ObtenerIdCliente());
                    if (respuestaIngresoContrato)
                    {
                        ingresoContratoView.txtIngresarValorContrato.Clear();
                        ingresoContratoView.cbIngresarTipoFactura.SelectedIndex = 0;
                        ingresoContratoView.Close();
                        MessageBox.Show("El contrato ha sido guardado con exito");
                    }
                    else MessageBox.Show("Error al guardar el contrato");
                }
               
            }      
        }

        private void CargarTiposFactura(object sender, EventArgs e)
        {
            ingresoContratoView.txtIngresarValorContrato.Clear();
            ContratoDao contratoDao = new ContratoDao();
            ingresoContratoView.cbIngresarTipoFactura.DataSource = contratoDao.ObtenerTiposFactura();
        }
    }
}
