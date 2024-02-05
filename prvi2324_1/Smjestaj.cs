namespace prvi2324_1
{
    internal abstract class Smjestaj : IComparable<Smjestaj>
    {
        public event Action<string, string>? DodavanjeSobe;
        public void NapraviInvoke(string value)
        {
            DodavanjeSobe?.Invoke(naziv, value);
        }
        private string naziv;
        private decimal cijena;
        public abstract int BrojJedinica { get; }
        public Smjestaj(string naziv, decimal cijena)
        {
            this.naziv = naziv;
            this.cijena = cijena;
        }
        public override string ToString()
            => "Naziv: " + naziv + ", cijena: "
                + cijena.ToString("0.00",
                    System.Globalization.CultureInfo.InvariantCulture)
                + " EUR";

        public int CompareTo(Smjestaj? other)
            => (other is null) ? -1 : naziv.CompareTo(other.naziv);
    }
}
