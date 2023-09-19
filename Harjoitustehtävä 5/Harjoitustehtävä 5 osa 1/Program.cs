using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_5_osa_1
{
    // olioluokka mikä hoitaa verolaskennan
    public class HoidaVerotus1
    {
        // Tähän ominaisuuteen tallennetaan summa
        private double summa = 0;

        public bool KysySumma()
        {

            bool ok = true;  // tarkistetaan onnistuiko
            try
            {

                Console.Write("Anna vuoden verotettavat ansiotulo euroina: ");
                this.summa = Double.Parse(Console.ReadLine());
            } // try
            catch (Exception virhe)
            {
                ok = false; //jos meni pieleen
            } // catch

            return ok;

        } // KysySumma

        public double LaskeVero1()
        {
            double vero = 0;
            if (this.summa < 19200)
            {
                vero = 0;
            } else if ((this.summa >= 19200) && (this.summa < 28700)) 
            {
                vero = 8 + 0.06 * (this.summa - 19200);
            }
            else if ((this.summa >= 28700) && (this.summa < 47300)) 
            {
                vero = 578 + 0.1725 * (this.summa - 28700);
            }
            else if ((this.summa >= 47300) && (this.summa < 82900)) 
            {
                vero = 3786.50 + 0.2125 * (this.summa - 47300);
            } else
            {
                vero = 11351.50 + 0.3125 * (this.summa - 82900);
            } //if

            return vero;

        } //laskevero1


    } // HoidaVerotus1
    

    internal class Program 
    {
        static void Main(string[] args) 
        {

            string valinta = "";

            do
            {
                // luodaan olioluokalle ilmentymä
                HoidaVerotus1 apu = new HoidaVerotus1();
                // Kysytään verotettava tulo
                if (apu.KysySumma())
                {
                    double vero = apu.LaskeVero1();
                    Console.WriteLine("Tuloveron suuruus on: " + vero.ToString("0.00") + " euroa.");

                } // if
                else
                {
                    Console.WriteLine("Virhe! Antamasi syöte ei kelpaa.");

                }

                Console.WriteLine("Paina <Enter> yrittääksesi uudestaan tai paina <L> lopettaaksesi sovelluksen.");
                valinta = Console.ReadLine();


            } while (!valinta.Equals("L") && (!valinta.Equals("l")));
            
            if (!valinta.Equals("L") && !valinta.Equals("l"))
            {

                Console.Write("Paina <Enter> jatkaaksesi...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hei hei!");
            }
            

        } // Main

    } // class

} // namespace
