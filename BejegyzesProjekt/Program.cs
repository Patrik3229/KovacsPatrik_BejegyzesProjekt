using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BejegyzesProjekt
{
    internal class Program
    {
        static List<Bejegyzes> lista1 = new List<Bejegyzes>();

        static void Feladat2()
        {
            // a

            Bejegyzes b1 = new Bejegyzes("én", "asdf");
            Bejegyzes b2 = new Bejegyzes("Gipsz Jakab", "ghjk");

            // b

            int darabszam;
            do
            {
                Console.WriteLine("Hány darab bejegyzést szeretne hozzáadni? ");
                darabszam = int.Parse(Console.ReadLine());
            } while (darabszam <= 0);

            for (int i = 0; i < darabszam; i++)
            {
                Console.WriteLine("Adja meg az új bejegyzés szerzőjét: ");
                string szerzo = Console.ReadLine();

                Console.WriteLine("Adja meg az új bejegyzés tartalmát: ");
                string tartalom = Console.ReadLine();

                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                lista1.Add(b);
            }

            // c

            StreamReader sr = new StreamReader("bejegyzesek.csv");
            while (!sr.EndOfStream)
            {
                string sor = Console.ReadLine();
                string[] adatok = sor.Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];
                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                lista1.Add(b);
            }
        }


        static void Main(string[] args)
        {
            Feladat2();

            Console.ReadKey();
        }
    }
}
