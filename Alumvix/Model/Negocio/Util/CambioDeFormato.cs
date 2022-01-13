using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Logica.Util
{
    internal class CambioDeFormato
    {
        public static string DarFormatoANumero(int valor)
        {
            string resultado = "";
            int conteo = 0;

            string numero = Convert.ToString(valor);
            int cantidad = numero.Length;
            while (conteo < cantidad)
            {
                resultado += numero[conteo];
                if ((cantidad - conteo-1) % 3 == 0 && conteo!=(cantidad-1)) resultado += ",";

                conteo++;
                
            }
            return resultado;
        }

        public static string QuitarFormatoANumero(string valor)
        {
            string str = valor.ToString();
            str = string.Join("", str.Split(','));
            return str;
        }

        public static string CambiarFormatoDeFecha(DateTime date) 
        {
            string dateString = date.ToLongDateString();
            return dateString;
        }
    }
}
