using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_3_osa_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kysytään käyttäjältä laskettavat luvut ja muunnetaan ne samalla numeeriseksi
            Console.WriteLine("Syötä yhteenlaskettavat numerot.");   
            Console.Write("Anna ensimmäinen luku: ");
            double luku1 = Double.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku: ");
            double luku2 = Double.Parse(Console.ReadLine());

            // lasketaan summa ja tulostetaan vastaus
            double summa = luku1 + luku2;
            Console.WriteLine("Lukujen " +luku1+ " ja " +luku2+ " yhteenlaskettu summa on: " +summa.ToString("0.00"));

            

        }   //main
    }   //class
}   //namespace
