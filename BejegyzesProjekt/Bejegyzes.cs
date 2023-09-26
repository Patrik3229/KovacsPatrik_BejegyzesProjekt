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
        private DateTime letrejött;
        private DateTime szerkesztve;

        public string Szerzo { get => szerzo;}
        public string Tartalom { get => tartalom; set => tartalom = value; }
        public int Likeok { get => likeok;}
        public DateTime Letrejött { get => letrejött;}
        public DateTime Szerkesztve { get => szerkesztve;}
    }
}
