using System;
using System.Collections.Generic;

public class Parkhaus
{
    public string Name { get; set; }
    public string Adresse { get; set; }
    public int Kapazität { get; set; }
    private List<Parkplatz> Parkplätze;
    public Anzeige Anzeige;
    private Ampel Ampel;

    public Parkhaus(string name, string adresse, int kapazität)
    {
        Name = name;
        Adresse = adresse;
        Kapazität = kapazität;
        Parkplätze = new List<Parkplatz>();
        Anzeige = new Anzeige();
        Ampel = new Ampel();
        // Initialisiere Parkplätze
        for (int i = 1; i <= kapazität; i++)
        {
            Parkplätze.Add(new Parkplatz(i, "Auto", false, false));
        }
        for (int i = 1; i <= 10; i++)
        {
            Parkplätze.Add(new Parkplatz(i, "Motorrad", false, false));
        }
        for (int i = 1; i <= 20; i++)
        {
            Parkplätze.Add(new Parkplatz(i, "Fahrrad", false, false));
        }
    }

    public int GetFreieParkplätze(string typ)
    {
        int count = 0;
        foreach (var parkplatz in Parkplätze)
        {
            if (parkplatz.Typ == typ && parkplatz.IstFrei())
            {
                count++;
            }
        }
        return count;
    }

    public void ParkFahrzeug(Fahrzeug fahrzeug)
    {
        foreach (var parkplatz in Parkplätze)
        {
            if (parkplatz.Typ == fahrzeug.Typ && parkplatz.IstFrei())
            {
                parkplatz.Belegen(fahrzeug);
                Anzeige.UpdateAnzeige(parkplatz.Typ, GetFreieParkplätze(parkplatz.Typ));
                break;
            }
        }
    }

    public void RemoveFahrzeug(string kennzeichen)
    {
        foreach (var parkplatz in Parkplätze)
        {
            if (!parkplatz.IstFrei() && parkplatz.Fahrzeug.Kennzeichen == kennzeichen)
            {
                parkplatz.Freigeben();
                Anzeige.UpdateAnzeige(parkplatz.Typ, GetFreieParkplätze(parkplatz.Typ));
                break;
            }
        }
    }

    public void UpdateAmpelStatus()
    {
        if (GetFreieParkplätze("Auto") > 0)
        {
            Ampel.SetStatus("Grün");
        }
        else
        {
            Ampel.SetStatus("Rot");
        }
    }
}
