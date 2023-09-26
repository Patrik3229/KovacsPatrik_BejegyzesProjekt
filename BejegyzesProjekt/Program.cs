using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    internal class Program
    {
        static List<Bejegyzes> lista1 = new List<Bejegyzes>();
        static List<Bejegyzes> lista2 = new List<Bejegyzes>();

        static void Feladat2()
        {
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
            for (int i = 0; i < lista1.Count; i++)
            {
                Console.WriteLine(lista1[i]);
            }
        }


        static void Main(string[] args)
        {
            Feladat2();

            Console.ReadKey();
        }
    }
}
