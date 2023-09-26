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
                string sor = sr.ReadLine();
                string[] adatok = sor.Split(';');
                string szerzo = adatok[0];
                string tartalom = adatok[1];
                Bejegyzes b = new Bejegyzes(szerzo, tartalom);
                lista1.Add(b);
            }

            // d

            int likeokszama = 0;
            Random r = new Random();
            int sum = 0;
            List<int> likeokszamaLista = new List<int>();

            do
            {
                likeokszamaLista.Clear();
                sum = 0;
                likeokszama = 0;
                for (int i = 0; i < lista1.Count; i++)
                {
                    likeokszama = r.Next(0, lista1.Count*10+1); // Ahány elem, annyi*10+1 (5 esetén ezzel 0 és 50 között generál egy adott tartalomra)
                    likeokszamaLista.Add(likeokszama);
                    sum += likeokszama;
                }
            } while (sum != lista1.Count * 20);
            for (int i = 0; i < lista1.Count; i++) // Végig a listán
            {
                for (int j = 0; j < likeokszamaLista[i]; j++) // Annyiszor like++, amennyi az adott elemhez tartozik like mennyiségben
                {
                    lista1[i].Like();
                }
            }

            // e

            Console.WriteLine("Mi legyen a második bejegyzés tartalma?");
            lista1[1].Tartalom = Console.ReadLine();

            // f

            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine($"\n{lista1[i]}");
            }
        }

        static void Feladat3()
        {
            // a

            int legnepszerubb = 0;

            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i].Likeok > legnepszerubb)
                {
                    legnepszerubb = lista1[i].Likeok;
                }
            }
            Console.WriteLine($"\nLike-ok száma (legnépszerűbb): {legnepszerubb}");

            // b

            bool voltolyan = false;
            for (int i = 0; i < lista1.Count; i++)
            {
                if (lista1[i].Likeok > 35)
                {
                    Console.WriteLine("\nVolt olyan, ami 35-nél több like-ot kapott.");
                    i = lista1.Count;
                    voltolyan = true;
                }
            }
            if (!voltolyan)
            {
                Console.WriteLine("\nNem volt olyan, ami 35-nél több like-ot kapott.");
            }
        }


        static void Main(string[] args)
        {
            Feladat2();
            Feladat3();

            Console.ReadKey();
        }
    }
}
