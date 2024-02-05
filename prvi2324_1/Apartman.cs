using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace prvi2324_1
{
    internal class Apartman : Smjestaj
    {
        private string opis;
        public Apartman(string naziv, decimal cijena, string opis)
            : base(naziv, cijena)
        {
            this.opis = opis;
        }
        public override int BrojJedinica
            => 1;
        public override string ToString()
            => base.ToString() + ", opis: " + opis;
    }
}
