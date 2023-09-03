using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitustehtävä_3_osa_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for lause
            for (int i = 1;i<=10;i++)
            {
                Console.WriteLine("Kierros: " +i);
            }   //for

            //  While lause
            int j = 10; 
            while (j >= 1)
            {
                Console.WriteLine("Kierros: " + j);
                j--;
            }
        }   //main
    }   //class
}   //namespace
