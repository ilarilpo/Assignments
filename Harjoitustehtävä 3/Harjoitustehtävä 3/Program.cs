using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                //Poikkeuskäsittelijä
                try
                {

                    // Kysytään käyttäjältä kokonaisluku
                    Console.WriteLine("Syötä kokonaisluku 10-20 väliltä: ");
                    int luku = Int32.Parse(Console.ReadLine());

                    // Tarkastetaan toteutuuko ehto
                    if ((luku < 10) && (luku > 20))
                    {
                        //Jos 10-20
                        Console.WriteLine("Hienoa!");
                        Console.WriteLine("Luku sijoittui välille 10-20 ");
                    }
                    else if (luku > 20)
                    {
                        Console.WriteLine("Väärin.");
                        Console.WriteLine("Luku on suurempi kuin 20 ");
                    }
                    else if (luku < 10)
                    {
                        Console.WriteLine("Väärin.");
                        Console.WriteLine("Luku on pienempi kuin 10 ");
                    }
                }   //try
                catch (Exception virhe)
                {
                    Console.WriteLine("VIRHE: Jokin meni vikaan. ");
                    Console.WriteLine("Ilmoitus: " + virhe.Message);
                }   //catch

                Console.WriteLine("Paina Enter käynnistääksesi sovelluksen uudestaan. ");
                Console.ReadLine(); // Wait for Enter key press
            }

        }   //main
        
            
    }   //class
    
}   //namespace
