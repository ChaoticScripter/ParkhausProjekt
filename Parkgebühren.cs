public class Parkgebühren
{
    private double StundenpreisAuto { get; set; }
    private double StundenpreisMotorrad { get; set; }
    private double Tageshöchstpreis { get; set; }

    public Parkgebühren()
    {
        StundenpreisAuto = 1.0;
        StundenpreisMotorrad = 0.5;
        Tageshöchstpreis = 10.0;
    }

    public double BerechneGebühren(Fahrzeug fahrzeug)
    {
        double preis = 0.0;
        if (fahrzeug.Typ == "Auto")
        {
            preis = Math.Min(fahrzeug.Parkdauer * StundenpreisAuto, Tageshöchstpreis);
        }
        else if (fahrzeug.Typ == "Motorrad" || fahrzeug.Typ == "Fahrrad")
        {
            preis = Math.Min(fahrzeug.Parkdauer * StundenpreisMotorrad, Tageshöchstpreis);
        }
        return preis;
    }
}
