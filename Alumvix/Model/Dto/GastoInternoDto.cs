using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class GastoInternoDto
    {
        int idGastoInterno;
        int valorGastoInterno;
        DateTime fechaGastoInterno;
        string descripcionGastoInterno;
        string tipoGastoInterno;

        public int IdGastoInterno { get => idGastoInterno; set => idGastoInterno = value; }
        public int ValorGastoInterno { get => valorGastoInterno; set => valorGastoInterno = value; }
        public DateTime FechaGastoInterno { get => fechaGastoInterno; set => fechaGastoInterno = value; }
        public string DescripcionGastoInterno { get => descripcionGastoInterno; set => descripcionGastoInterno = value; }
        public string TipoGastoInterno { get => tipoGastoInterno; set => tipoGastoInterno = value; }
    }
}
