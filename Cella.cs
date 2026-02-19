namespace _19_02_2026;

public class Cella
{
    Pozicio pozicio;
    NovenyFaj noveny = null;
    private int egyedszam;
    private List<Riasztas> riasztasok;
    private List<Szenzor> szenzorok;

    public Cella(Pozicio pozicio)
    {
        this.pozicio = pozicio;
        this.riasztasok = new List<Riasztas>();
        this.szenzorok = new List<Szenzor>();
    }

    public Pozicio Pozicio
    {
        get => pozicio;
        set => pozicio = value ?? throw new ArgumentNullException(nameof(value));
    }

    public NovenyFaj Noveny
    {
        get => noveny;
        set => noveny = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Egyedszam
    {
        get => egyedszam;
        set => egyedszam = value;
    }

    public List<Riasztas> Riasztasok
    {
        get => riasztasok;
        set => riasztasok = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Szenzor> Szenzorok
    {
        get => szenzorok;
        set => szenzorok = value ?? throw new ArgumentNullException(nameof(value));
    }

    public bool UresCella
    {
        get
        {
            return this.noveny == null;
        }
    }
    
    public bool Beultet(NovenyFaj noveny, int egyedSzam)
    {
        if (this.UresCella)
        {
            this.noveny = noveny;
            this.egyedszam = egyedSzam;
            return true;
        }
        else if (noveny == this.Noveny)
        {
            this.egyedszam += egyedSzam;
            if (this.egyedszam > noveny.OptimalisSuruseg)
            {
                this.noveny.EgeszsegiAllapot -= 2;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Noveles(int egyedSzam)
    {
        this.Beultet(this.Noveny, egyedSzam);
    }

    public void Csokkentes(int egyedSzam)
    {
        this.egyedszam -= egyedSzam;

        if (this.egyedszam <= 0)
        {
            this.Urit();
        }
    }

    public void Urit()
    {
        this.egyedszam = 0;
        this.noveny = null;
    }
}