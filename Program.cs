namespace _19_02_2026;

class Program
{
    static void Main(string[] args)
    {
        Kezelo k = new Kezelo("Kovács Péter", "kpeter", Szerepkor.ADMIN);
        Kezelo k1 = new Kezelo("Nagy Anna", "nanna", Szerepkor.KERTESZ);

        NovenyFaj n1 = new NovenyFaj("paradicsom", 100, 10, 10);

        Cella c1 = new Cella(new Pozicio(0, 0));

        Console.WriteLine(c1.UresCella);

        c1.Beultet(n1, 5);

        Console.WriteLine(c1.UresCella);
    }
}