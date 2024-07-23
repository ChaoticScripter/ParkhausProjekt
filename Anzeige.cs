public class Anzeige
{
    public int FreiePlätzeAuto { get; private set; }
    public int FreiePlätzeMotorrad { get; private set; }
    public int FreiePlätzeFahrrad { get; private set; }
    public double Einnahmen { get; private set; }

    public Anzeige()
    {
        FreiePlätzeAuto = 20;
        FreiePlätzeMotorrad = 10;
        FreiePlätzeFahrrad = 20;
        Einnahmen = 0.0;
    }

    public void UpdateAnzeige(string typ, int freiePlätze)
    {
        switch (typ)
        {
            case "Auto":
                FreiePlätzeAuto = freiePlätze;
                break;
            case "Motorrad":
                FreiePlätzeMotorrad = freiePlätze;
                break;
            case "Fahrrad":
                FreiePlätzeFahrrad = freiePlätze;
                break;
        }
    }

    public void Anzeigen()
    {
        Console.WriteLine($"Freie Autoplätze: {FreiePlätzeAuto}");
        Console.WriteLine($"Freie Motorradplätze: {FreiePlätzeMotorrad}");
        Console.WriteLine($"Freie Fahrradplätze: {FreiePlätzeFahrrad}");
        Console.WriteLine($"Einnahmen: {Einnahmen} Euro");
    }

    public void AddEinnahmen(double betrag)
    {
        Einnahmen += betrag;
    }
}
