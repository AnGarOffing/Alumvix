using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Logica.Util
{
    internal class FormatoAValor
    {
        public static string DarFormatoANumero(int valor)
        {
            string numero = "";
            string resultado = "";
            int cantidad = 0;
            int conteo = 0;

            numero = Convert.ToString(valor);
            cantidad = numero.Length;
            while (conteo < cantidad)
            {
                resultado += numero[conteo];
                if ((cantidad - conteo-1) % 3 == 0 && conteo!=(cantidad-1)) resultado += ",";

                conteo++;
                
            }
            return resultado;
        }
    }
}
