using Gestione_Libreria.DAL;
using Gestione_Libreria.Utilities;
using GestioneLibreria.Models;

namespace Gestione_Libreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Config.getIstanza().GetConnectionString());
            Libro lib = new Libro()
            {
              Titolo= "l'idiota",
              DataPub = new DateTime(2024, 10, 10),
              HasDisponibilita=true

            };

            Console.WriteLine(LibroDAL.getIstanza().Insert(lib) ? "Stappo!" : "Errore");
        }
    }
}
