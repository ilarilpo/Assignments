using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEHTÄVÄ_5
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

                Console.Write("Anna vuoden 2023 verotettavat ansiotulo euroina: ");
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
            if (this.summa < 19900)
            {
                vero = 0;
            }
            else if ((this.summa >= 19900) && (this.summa < 29700))
            {
                vero = 2515.36 + 0.19 * (this.summa - 19900);
            }
            else if ((this.summa >= 29700) && (this.summa < 49000))
            {
                vero = 4377.36 + 0.3025 * (this.summa - 29700);
            }
            else if ((this.summa >= 49000) && (this.summa < 85800))
            {
                vero = 10215.61 + 0.34 * (this.summa - 49000);
            }
            else
            {
                vero = 22727.61 + 0.44 * (this.summa - 85800);
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