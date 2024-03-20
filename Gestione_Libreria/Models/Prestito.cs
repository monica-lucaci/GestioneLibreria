using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibreria.Models
{
    internal class Prestito
    {
        public int Id { get; set; }
        public DateTime DataPrestito { get; set; }
        public DateTime DataRitorno { get; set; }

        public Prestito() { }

        public Prestito(int id, DateTime dataPrestito, DateTime dataRitorno)
        {
            Id = id;
            DataPrestito = dataPrestito;
            DataRitorno = dataRitorno;
        }
    }
}