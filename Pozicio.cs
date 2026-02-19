namespace _19_02_2026;

public class Pozicio
{
    private int x;
    private int y;

    public Pozicio(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return this.x + "; " + this.y;
    }
}