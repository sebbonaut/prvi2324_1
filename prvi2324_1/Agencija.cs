using static Program;

namespace prvi2324_1
{
    internal class Agencija
    {
        private string naziv;
        private List<Smjestaj> popis;
        public Agencija(string naziv, List<Smjestaj> popis)
        {
            this.naziv = naziv;
            this.popis = popis;
            foreach (Smjestaj smjestaj in popis)
                smjestaj.DodavanjeSobe += Obavijest;
        }
        public void Informacije()
        {
            Console.WriteLine("Smjestaji u agenciji "
                + naziv + ":");
            foreach (Smjestaj smjestaj in popis)
            {
                Console.WriteLine(smjestaj
                    + "\nBroj jedinica: "
                    + smjestaj.BrojJedinica);
            }
        }
        public void Obavijest(string nazivHotela, string opisSobe)
        {
            Console.WriteLine($"U hotel \"{nazivHotela}\" " +
                $"dodana je nova soba - opis: {opisSobe}");
            Informacije();
        }
    }
}
