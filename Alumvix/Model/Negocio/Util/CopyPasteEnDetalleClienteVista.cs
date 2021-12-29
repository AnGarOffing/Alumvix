using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alumvix.View.Cliente;

namespace Alumvix.Model.Logica.Util
{
    internal class CopyPasteEnDetalleClienteVista
    {
        DetalleClienteView detalleClienteVista;
        public CopyPasteEnDetalleClienteVista(DetalleClienteView detalleClienteView)
        {
            detalleClienteVista = detalleClienteView;
            detalleClienteVista.Load += new EventHandler(TransformarTextBoxes);
        }

        private void TransformarTextBoxes(object sender, EventArgs e) 
        {
            
            detalleClienteVista.textBox1.ReadOnly = true;
            detalleClienteVista.textBox1.BorderStyle = 0;
            detalleClienteVista.textBox1.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox1.TabStop = false;
           
            detalleClienteVista.textBox2.ReadOnly = true;
            detalleClienteVista.textBox2.BorderStyle = 0;
            detalleClienteVista.textBox2.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox2.TabStop = false;
            
            detalleClienteVista.textBox3.ReadOnly = true;
            detalleClienteVista.textBox3.BorderStyle = 0;
            detalleClienteVista.textBox3.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox3.TabStop = false;

            
            detalleClienteVista.textBox4.ReadOnly = true;
            detalleClienteVista.textBox4.BorderStyle = 0;
            detalleClienteVista.textBox4.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox4.TabStop = false;
            
            detalleClienteVista.textBox5.ReadOnly = true;
            detalleClienteVista.textBox5.BorderStyle = 0;
            detalleClienteVista.textBox5.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox5.TabStop = false;
           
            detalleClienteVista.textBox6.ReadOnly = true;
            detalleClienteVista.textBox6.BorderStyle = 0;
            detalleClienteVista.textBox6.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox6.TabStop = false;
           
            detalleClienteVista.textBox7.ReadOnly = true;
            detalleClienteVista.textBox7.BorderStyle = 0;
            detalleClienteVista.textBox7.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox7.TabStop = false;
           
            detalleClienteVista.textBox8.ReadOnly = true;
            detalleClienteVista.textBox8.BorderStyle = 0;
            detalleClienteVista.textBox8.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox8.TabStop = false;
            
            detalleClienteVista.textBox9.ReadOnly = true;
            detalleClienteVista.textBox9.BorderStyle = 0;
            detalleClienteVista.textBox9.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox9.TabStop = false;
            
            detalleClienteVista.textBox10.ReadOnly = true;
            detalleClienteVista.textBox10.BorderStyle = 0;
            detalleClienteVista.textBox10.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox10.TabStop = false;
            
            detalleClienteVista.textBox11.ReadOnly = true;
            detalleClienteVista.textBox11.BorderStyle = 0;
            detalleClienteVista.textBox11.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox11.TabStop = false;
           
            detalleClienteVista.textBox12.ReadOnly = true;
            detalleClienteVista.textBox12.BorderStyle = 0;
            detalleClienteVista.textBox12.BackColor = detalleClienteVista.BackColor;
            detalleClienteVista.textBox12.TabStop = false;
        }
    }
}
