using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_3_Osa_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)    // lisätään looppi tietovisan lopuksi
            {
                // Luodaan 2-ulotteinen taulukko ja lisätään siihen kysymykset, sekä oikeat vastaukset
                string[,] kysymykset = new string[3, 2];
                // Laitetaan taulukkoon kysymykset ja oikeat vastaukset
                kysymykset[0, 0] = "Mitä videopeliä pidetään maailman ensimmäisenä videopelinä (a=Pong, b=Tennis for two, c=Pac-Man)?";
                kysymykset[0, 1] = "b";
                kysymykset[1, 0] = "Mikä on maailman myydyin pelikonsoli (a=Playstation 2, b=Wii, c=XBOX 360)?";
                kysymykset[1, 1] = "a";
                kysymykset[2, 0] = "Mikä on maailman myydyin videopeli (a=Tetris, b=GTA 5, c=Minecraft)?";
                kysymykset[2, 1] = "c";

                // kysytään kysymykset ja lasketaan oikeat vastaukset
                int oikeat = 0;
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine("Kysymys " + (i + 1) + " : " + kysymykset[i, 0]);
                    string vastaus = Console.ReadLine();
                    if (vastaus.Equals(kysymykset[i, 1], StringComparison.OrdinalIgnoreCase))   
                        // lisätään ehto että vastauksen upper- tai lowercase muodolla ei ole merkitystä.
                    {
                        //jos meni oikein
                        oikeat++;
                        Console.WriteLine("Oikein!");
                    }
                    else
                    {
                        Console.WriteLine("Väärin...");
                    }   //if
                }   //for
                    //tulostetaan oikeiden vastausten määrä

                Console.WriteLine("Oikeat vastaukset : " + oikeat + " /3");
                Console.WriteLine("Paina enteriä yrittääksesi uudestaan.");
                Console.ReadLine(); //odotetaan että käyttäjä painaa enteriä
            }

        }   //Main
    }   //class
}   //namespace
