using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEHTÄVÄ_4 //namespace
{
    internal class Program //program
    {
        static void Main(string[] args) //main
        {
            
            string valinta = ""; // Määritellään täällä jotta näkyisi do-while lauseen ulkopuolella

            do
            {

                Console.Clear();

                Console.WriteLine("*******************************");
                Console.WriteLine("    PINTA-ALA LASKURI");
                Console.WriteLine("*******************************");
                Console.WriteLine();
                Console.WriteLine("   1. YMPYRÄN PINTA-ALA");
                Console.WriteLine();
                Console.WriteLine("   2. NELIKULMION PINTA-ALA");
                Console.WriteLine();
                Console.WriteLine("   3. KOLMION PINTA-ALA");
                Console.WriteLine();
                Console.WriteLine("   L Lopetus");
                Console.WriteLine();
                Console.WriteLine("*******************************");
                Console.WriteLine();
                Console.WriteLine("Anna valintasi: ");
                valinta = Console.ReadLine();
                if (valinta.Equals("L") || valinta.Equals("l") || valinta.Equals("1") || valinta.Equals("2") || valinta.Equals("3"))
                {
                    try
                    {

                        //  Kysytään laskutoimitusta varten vaadittavat tiedot ja lasketaan

                        if (valinta.Equals("1")) //ympyrä
                        {
                            Console.WriteLine("Anna ympyrän säde (mm): ");
                            double ymp_sade = Double.Parse(Console.ReadLine());
                            double ymp_pinta_ala = ymp_sade * ymp_sade * Math.PI;
                            Console.WriteLine("Ympyrä minkä säde on " + ymp_sade + " mm, on pinta-alaltaan = " + ymp_pinta_ala.ToString("0.00" + " mm^2"));
                        }
                        else if (valinta.Equals("2")) //nelikulmio
                        {
                            Console.WriteLine("Anna nelikulmion leveys (mm): ");
                            double nelio_leveys = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Anna nelikulmion korkeus (mm): ");
                            double nelio_korkeus = Double.Parse(Console.ReadLine());
                            double nelio_pinta_ala = nelio_leveys * nelio_korkeus;
                            Console.WriteLine("Nelikulmio minkä leveys on " + nelio_leveys + " mm, ja korkeus on " + nelio_korkeus + " mm, on pinta-alaltaan " 
                                + nelio_pinta_ala.ToString("0.00" + " mm^2"));
                        }
                        else if (valinta.Equals("3")) //kolmio
                        {
                            Console.WriteLine("Anna kolmion kanta (mm): ");
                            double kolmio_kanta = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Anna kolmion korkeus (mm): ");
                            double kolmio_korkeus = Double.Parse(Console.ReadLine());
                            double kolmio_pinta_ala = 0.5 * kolmio_kanta * kolmio_korkeus;
                            Console.WriteLine("Kolmio minkä kanta on " + kolmio_kanta + " mm, ja korkeus on " + kolmio_korkeus + " mm, on pinta-alaltaan "
                                + kolmio_pinta_ala.ToString("0.00" + " mm^2"));
                        } //if

                    }   //try
                    catch (Exception virhe)
                    {
                        Console.WriteLine("Virhe! Yritä uudestaan.");
                    }   //catch

                    if (!valinta.Equals("L") && !valinta.Equals("l"))
                    {
                        // Pysähdytään
                        Console.Write("Paina <Enter> jatkaaksesi...");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Hei hei!");
                    }
                } //if
                else
                {
                    Console.WriteLine("Virhe! Yritä uudestaaan.");
                    Console.Write("Paina <Enter> jatkaaksesi...");
                    Console.ReadLine();
                } //else if

            } while (!valinta.Equals("L") && (!valinta.Equals("l")));

        } //main
    } //class
} //namespace
