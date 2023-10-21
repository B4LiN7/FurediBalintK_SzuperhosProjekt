using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Kepregeny.Szereplok("szuperhos.txt");
            }
            catch (Exception)
            {
                throw new IOException("Hiba a fájl beolvasásakor!");
            }
            
            Kepregeny.Szuperhosok();
            Console.ReadKey();
        }
    }
}
