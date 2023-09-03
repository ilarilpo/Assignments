using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_3_osa_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Määritellään täällä jotta näkyisi do-while lauseen ulkopuolella
            string valinta = "";

            do
            {

                Console.Clear();

                Console.WriteLine("**************************");
                Console.WriteLine("    EURO / MK MUUNNIN");
                Console.WriteLine("**************************");
                Console.WriteLine("   1. Markat euroiksi");
                Console.WriteLine("   2. Eurot markoiksi");
                Console.WriteLine();
                Console.WriteLine("   L Lopetus");
                Console.WriteLine("**************************");
                Console.WriteLine("Anna valintasi: ");
                valinta = Console.ReadLine();
                if (valinta.Equals("L") || valinta.Equals("l") || valinta.Equals("1") || valinta.Equals("2"))
                {
                    try
                    {

                        //  Kysytään summa ja lasketaan

                        if (valinta.Equals("1"))
                        {
                            Console.WriteLine("Anna summa markkoina: ");
                            double summa = Double.Parse(Console.ReadLine());
                            double tulos = summa / 5.94573;
                            Console.WriteLine(summa + " mk = " + tulos.ToString("0.00" + " euroa."));
                        }
                        else if (valinta.Equals("2"))
                        {
                            Console.WriteLine("Anna summa euroina: ");
                            double summa = Double.Parse(Console.ReadLine());
                            double tulos = summa * 5.94573;
                            Console.WriteLine(summa + " euroa = " + tulos.ToString("0.00" + " markkaa."));
                        }

                    }   //try
                    catch (Exception virhe)
                    {
                        Console.WriteLine("Virhe!");
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
                } else
                {
                    Console.WriteLine("Virhe!");
                    Console.Write("Paina <Enter> jatkaaksesi...");
                    Console.ReadLine();
                }

            } while (!valinta.Equals("L") && (!valinta.Equals("l"))); 

        }   //main
    }   //class
}   //namespace
