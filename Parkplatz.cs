public class Parkplatz
{
    public int Nummer { get; set; }
    public string Typ { get; set; }
    public bool Frei { get; private set; }
    public bool Barrierefrei { get; set; }
    public bool FrauenFamilien { get; set; }
    public Fahrzeug Fahrzeug { get; private set; }

    public Parkplatz(int nummer, string typ, bool barrierefrei, bool frauenFamilien)
    {
        Nummer = nummer;
        Typ = typ;
        Frei = true;
        Barrierefrei = barrierefrei;
        FrauenFamilien = frauenFamilien;
    }

    public bool IstFrei()
    {
        return Frei;
    }

    public void Belegen(Fahrzeug fahrzeug)
    {
        Frei = false;
        Fahrzeug = fahrzeug;
    }

    public void Freigeben()
    {
        Frei = true;
        Fahrzeug = null;
    }
}
