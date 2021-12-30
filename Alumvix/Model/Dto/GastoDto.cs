using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class GastoDto
    {
        int idGasto;
        int valorGasto;
        DateTime fechaGasto;
        string descripcionGasto;

        public int IdGasto { get => idGasto; set => idGasto = value; }
        public DateTime FechaGasto { get => fechaGasto; set => fechaGasto = value; }
        public string DescripcionGasto { get => descripcionGasto; set => descripcionGasto = value; }
        public int ValorGasto { get => valorGasto; set => valorGasto = value; }
    }
}
