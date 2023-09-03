using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muuttujat_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä nimi
            Console.Write("Anna nimesi: ");
            string nimi =    Console.ReadLine();

            // Tulostetaan tervehdys
            Console.WriteLine("Tervehdys " + nimi + "!");

        }   // Main
    }   // class
}   //namespace
