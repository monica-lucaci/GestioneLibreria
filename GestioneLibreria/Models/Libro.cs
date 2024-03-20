using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneLibreria.Models
{
    internal class Libro
    {
        public int Id { get; set; }
        public string?  Titolo { get; set; }
        public DateOnly DataPub { get; set; }
        public bool HasDisponibilita { get; set; }
    }
}
