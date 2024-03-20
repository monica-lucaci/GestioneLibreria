using Gestione_Libreria.Utilities;
using GestioneLibreria.DAL;
using GestioneLibreria.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Libreria.DAL
{
    internal class LibroDAL : IDal<Libro>
    {

        private static LibroDAL? istanza;
        public static LibroDAL getIstanza()
        {
            if (istanza == null)  
                istanza = new LibroDAL();
            return istanza;
        }

        private LibroDAL() { }


        public bool Delete(Libro t)
        {
            throw new NotImplementedException();
        }

        public List<Libro> GetAll()
        {
            throw new NotImplementedException();
        }

        public Libro getByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Libro t)
        {
            bool risultato = false;

            using(SqlConnection con = new SqlConnection(Config.getIstanza().GetConnectionString()))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO Libro(titolo,dataPub,hasdisponibilita)VALUES(@valTitolo,@valDate,@valDisponib)";
                cmd.Parameters.AddWithValue("@valTitolo", t.Titolo);
                cmd.Parameters.AddWithValue("@valDate", t.DataPub);
                cmd.Parameters.AddWithValue("@valDisponib",t.HasDisponibilita);
                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        risultato = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            return risultato;
        }

        public bool Update(Libro t)
        {
            throw new NotImplementedException();
        }
    }
}
