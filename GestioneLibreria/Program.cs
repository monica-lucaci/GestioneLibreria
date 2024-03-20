using GestioneLibreria.Utilities;

namespace GestioneLibreria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Config.getIstanza().GetConnectionString());
        }
            
    }
}
