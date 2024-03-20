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
        public string? Titolo { get; set; }
        public DateTime DataPub { get; set; }
        public bool HasDisponibilita { get; set; }

        public Libro()
        {

        }

        public Libro(int id, string? titolo, DateTime dataPub, bool hasDisponibilita)
        {
            Id = id;
            Titolo = titolo;
            DataPub = dataPub;
            HasDisponibilita = hasDisponibilita;
        }
    }
}