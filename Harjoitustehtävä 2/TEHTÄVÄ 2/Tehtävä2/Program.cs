using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä etu- ja sukunimi sekä ikä
            Console.Write("Terve! Syötä tähän etunimesi:");
            string etunimi = Console.ReadLine();
            Console.Write("Syötä tähän sukunimesi:");
            string sukunimi = Console.ReadLine();
            Console.Write("Syötä tähän ikäsi:");
            string ikä = Console.ReadLine();

            // Tulostetaan syötetyt tiedot
            Console.WriteLine("Tervehdys " + etunimi + " " + 
                sukunimi + ", olet " + ikä + " " + "vuotias!");

        }   // main
    }   // class
}   // namespace
