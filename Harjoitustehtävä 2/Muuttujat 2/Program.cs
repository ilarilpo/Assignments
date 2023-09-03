using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muuttujat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä laskettavat luvut
            // Muunnetaan luvut numeerisiksi laskentaa varten
            Console.Write("Anna ensimmäinen luku: ");
            double luku1 = Double.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            double luku2 = Double.Parse(Console.ReadLine());

            // Lasketaan summa ja tulostetaan vastaus
            double summa = luku1 + luku2;
            Console.WriteLine("Lukujen " + luku1 
                + " ja " + luku2 + " summa on " + summa.ToString("0.00"));

        }   // Main
    }   // class
}   // namespace
