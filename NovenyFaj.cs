namespace _19_02_2026;

public class NovenyFaj
{
    private string azonosito;
    private string nev;
    private int vizigeny; // max 100, azon túl egészség romlik
    private int egeszsegiAllapot; // 0-10, ahol a 0 az elpusztult
    private int optimalisSuruseg;

    public NovenyFaj(string nev, int vizigeny, int egeszsegiAllapot, int optimalisSuruseg)
    {
        this.nev = nev;
        this.vizigeny = vizigeny;
        this.egeszsegiAllapot = egeszsegiAllapot;
        this.optimalisSuruseg = optimalisSuruseg;
    }

    public string Azonosito
    {
        get => this.nev.Substring(0, 3);
    }

    public string Nev
    {
        get => nev;
        set => nev = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Vizigeny
    {
        get => vizigeny;
        set => vizigeny = value;
    }

    public int EgeszsegiAllapot
    {
        get => egeszsegiAllapot;
        set => egeszsegiAllapot = value;
    }

    public int OptimalisSuruseg
    {
        get => optimalisSuruseg;
        set => optimalisSuruseg = value;
    }

    public override string ToString()
    {
        return $"{this.nev} ({this.Azonosito}): {this.vizigeny}, {this.egeszsegiAllapot}";
    }
}