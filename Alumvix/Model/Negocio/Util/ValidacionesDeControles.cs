using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Negocio.Util
{
    internal class ValidacionesDeControles
    {
        static bool respuesta;
        public static bool ValidarBotonIngresoAbono(string valorAbono, int formaDeAbono) 
        {
            respuesta = false;  
            if (valorAbono != "")
            {
                if (formaDeAbono != 0)
                {
                    return true;
                }
            }
            return respuesta;
        }

        public static bool ValidarBotonIngresoGasto(string valorGasto)
        {
            respuesta = false;
            if (valorGasto != "") respuesta = true;
            return respuesta;
        }
    }
}
