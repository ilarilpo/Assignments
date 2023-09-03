using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_osa_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esitetään käyttäjälle monivalintakysymys
            Console.WriteLine("Mikä on Suomen pääkaupunki? ");
            Console.WriteLine("A: Turku");
            Console.WriteLine("B: Helsinki");
            Console.WriteLine("C: Mouhijärvi");
            string vastaus = Console.ReadLine();

            //Tutkitaan käyttäjän vastausta

            if (vastaus.Equals("B") || vastaus.Equals("Helsinki"))
            {
                Console.WriteLine("Oikein!");
            }
            else if (vastaus.Equals("A") || vastaus.Equals("C") || vastaus.Equals("a") || vastaus.Equals("c")
                || vastaus.Equals("Turku") || vastaus.Equals("Mouhijärvi") || vastaus.Equals("turku") || vastaus.Equals("mouhijärvi"))
            {
                Console.WriteLine("Väärin.");
            }
            else
            {
                Console.WriteLine("Virhe! Et vastannut kysymykseen.");
            }
            
        }   //main
    }   //class
}   //namespace
