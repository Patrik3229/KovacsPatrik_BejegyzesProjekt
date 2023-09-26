using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    internal class Bejegyzes
    {
        private string szerzo;
        private string tartalom;
        private int likeok;
        private DateTime letrejott;
        private DateTime szerkesztve;

        public Bejegyzes(string szerzo, string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likeok = 0;
            this.letrejott = DateTime.Now;
            this.szerkesztve = DateTime.Now;
        }

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejott { get => letrejott;}
        public DateTime Szerkesztve { get => szerkesztve; set => szerkesztve = value; }

        public void Like()
        {
            this.likeok++;
            Szerkesztve = DateTime.Now;
        }

        public override string ToString()
        {
            if (this.letrejott != this.szerkesztve)
            {
                return $"{this.szerzo} - {this.likeok} - {this.letrejott}\nSzerkesztve: {this.szerkesztve}\n{this.tartalom}";
            }
            else
            {
                return $"{this.szerzo} - {this.likeok} - {this.letrejott}\n{this.tartalom}";
            }
        }
    }
}
