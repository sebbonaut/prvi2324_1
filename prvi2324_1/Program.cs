using prvi2324_1;

internal class Program
{
    private static void Main(string[] args)
    {
        Apartman a1 = new Apartman("Novi apartman",
            15.515M, "novo u ponudi do mora");
        Console.WriteLine(a1);
        Apartman a2 = new Apartman("Star Apartman",
            23.5M, "vrhunski apartman s klimom");
        Console.WriteLine(a2);
        
        Hotel<byte> h = new Hotel<byte>("Otok Hotel",20.142M);
        h[3] = "soba s pogledom na park";
        h[2] = "jednokrevetna soba s balkonom";
        try
        {
            h[2] = "jednokrevetna soba s balkonom";
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(h);
        
        List<Smjestaj> lista = new List<Smjestaj>()
        {
            a1, a2, h
        };
        lista.Sort();
        Console.WriteLine("-----Nakon sortiranja-----");
        foreach (var smjestaj in lista)
            Console.WriteLine("- " + smjestaj);
        
        Hotel<char> novi = new Hotel<char>("Novi hotel", 5);
        if (h)
            Console.WriteLine("Neprazan hotel");
        if (novi)
            Console.WriteLine("Ovaj tekst ne smije se ispisati");
        
        Agencija ag = new Agencija("Agencija Tours",
            new List<Smjestaj>() {a2,h});
        ag.Informacije();
        
        Console.WriteLine("-----Dodajemo jos jednu sobu u hotel-----");
        h[1] = "soba s pogledom na more";
    }
}