using System;

public class Program
{
    public static void Main(string[] args)
    {
        Parkhaus parkhaus = new Parkhaus("City Parkhaus", "Hauptstraße 1", 20);

        Fahrzeug auto1 = new Fahrzeug("AB-123", "Auto", 3);
        Fahrzeug moto1 = new Fahrzeug("CD-456", "Motorrad", 1);

        parkhaus.ParkFahrzeug(auto1);
        parkhaus.ParkFahrzeug(moto1);

        parkhaus.UpdateAmpelStatus();
        parkhaus.RemoveFahrzeug("AB-123");

        Console.WriteLine("Freie Autoparkplätze: " + parkhaus.GetFreieParkplätze("Auto"));
        Console.WriteLine("Freie Motorradparkplätze: " + parkhaus.GetFreieParkplätze("Motorrad"));

        Parkgebühren gebühren = new Parkgebühren();
        double preis = gebühren.BerechneGebühren(auto1);
        Console.WriteLine("Parkgebühr für Auto1: " + preis + " Euro");

        parkhaus.Anzeige.Anzeigen();
    }
}
