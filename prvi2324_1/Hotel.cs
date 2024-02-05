using static Program;

namespace prvi2324_1
{
    internal class Hotel<T> : Smjestaj
            where T : unmanaged
    {
        private Dictionary<T, string> opis;
        public Hotel(string naziv, decimal cijena)
            : base(naziv, cijena)
        {
            opis = new Dictionary<T, string>();
        }
        public override int BrojJedinica
            => opis.Count;
        public override string ToString()
        {
            string poruka = base.ToString()
                + ", opisi soba:";
            foreach (var op in opis)
            {
                poruka += "\n\t" + op.Value;
            }
            return poruka;
        }
        public string this[T id]
        {
            get => opis[id];
            set
            {
                if (opis.ContainsKey(id))
                    throw new Exception("Hotel vec ima sobu " +
                        $"s identifikatorom {id}");
                opis[id] = value;
                NapraviInvoke(value);
            }
        }
        public static bool operator true(Hotel<T> h)
            => h.BrojJedinica != 0;
        public static bool operator false(Hotel<T> h)
            => h.BrojJedinica == 0;
    }
}
