namespace _19_02_2026;

public class Kezelo
{
    private string nev;
    private string azonosito;
    private Szerepkor szerepkor;

    public Kezelo(string nev, string azonosito, Szerepkor szerepkor)
    {
        this.nev = nev;
        this.azonosito = azonosito;
        this.szerepkor = szerepkor;
    }

    public string Nev
    {
        get => nev;
        set => nev = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Azonosito
    {
        get => azonosito;
        set => azonosito = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Szerepkor Szerepkor
    {
        get => szerepkor;
        set => szerepkor = value;
    }

    public override string ToString()
    {
        return $"{this.nev}: {this.azonosito}";
    }
}