using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumvix.Model.Dto
{
    internal class AbonoDto
    {
        int idAbono;
        int valorAbono;
        DateTime fechaAbono;
        string formaDeAbono;


        public int IdAbono { get => idAbono; set => idAbono = value; }
        public DateTime FechaAbono { get => fechaAbono; set => fechaAbono = value; }
        public int ValorAbono { get => valorAbono; set => valorAbono = value; }
        internal string FormaDeAbono { get => formaDeAbono; set => formaDeAbono = value; }
    }
}
