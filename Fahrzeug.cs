public class Fahrzeug
{
    public string Kennzeichen { get; set; }
    public string Typ { get; set; }
    public int Parkdauer { get; set; } // in Stunden

    public Fahrzeug(string kennzeichen, string typ, int parkdauer)
    {
        Kennzeichen = kennzeichen;
        Typ = typ;
        Parkdauer = parkdauer;
    }
}
