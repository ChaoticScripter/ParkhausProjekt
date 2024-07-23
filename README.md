# Parkhaus Projekt

## Beschreibung

Das Parkhaus-Projekt ist eine Konsolenanwendung, die ein einfaches Parkhaussystem simuliert. 
Die Anwendung ermöglicht das Verwalten von Parkplätzen, Fahrzeugen, Parkgebühren und eine Anzeige für die freien Plätze und Einnahmen. 
Das System bietet Funktionen zur Verwaltung von Autos, Motorrädern und Fahrrädern sowie zur Berechnung der Parkgebühren.

## Funktionen

- Parken und Entfernen von Fahrzeugen.
- Verwaltung von freien und belegten Parkplätzen.
- Berechnung der Parkgebühren basierend auf Fahrzeugtyp und Parkdauer.
- Anzeige der freien Parkplätze und Einnahmen.
- Ampel-Status zur Regelung des Zugangs zum Parkhaus.

## Installation

1. Klonen Sie das Repository:

   ```bash
   git clone https://github.com/ChaoticScripter/parkhaus-projekt.git




### Tabelle der Klassen und Methoden

| Klasse       | Methode                           | Beschreibung                                                    |
|--------------|-----------------------------------|----------------------------------------------------------------|
| **Parkhaus** | `GetFreieParkplätze(string typ)`  | Gibt die Anzahl der freien Parkplätze für den angegebenen Typ zurück. |
|              | `ParkFahrzeug(Fahrzeug fahrzeug)` | Parkt ein Fahrzeug im Parkhaus.                                |
|              | `RemoveFahrzeug(string kennzeichen)` | Entfernt ein Fahrzeug aus dem Parkhaus.                        |
|              | `UpdateAmpelStatus()`              | Aktualisiert den Ampelstatus basierend auf freien Parkplätzen.  |
| **Parkplatz** | `Belegen(Fahrzeug fahrzeug)`      | Belegt den Parkplatz mit einem Fahrzeug.                        |
|              | `Freigeben()`                     | Gibt den Parkplatz frei.                                       |
|              | `IstFrei()`                        | Überprüft, ob der Parkplatz frei ist.                          |
| **Fahrzeug** | -                                 | Attribute: Kennzeichen, Typ, Parkdauer.                        |
| **Anzeige**  | `UpdateAnzeige(string typ, int freiePlätze)` | Aktualisiert die Anzeige der freien Parkplätze für den angegebenen Typ. |
|              | `Anzeigen()`                       | Zeigt die aktuellen freien Plätze und Einnahmen an.            |
|              | `AddEinnahmen(double betrag)`      | Fügt den Betrag zu den Einnahmen hinzu.                         |
| **Ampel**    | `SetStatus(string status)`         | Setzt den Status der Ampel (z.B. Grün, Rot).                    |
| **Parkgebühren** | `BerechneGebühren(Fahrzeug fahrzeug)` | Berechnet die Parkgebühren basierend auf dem Fahrzeugtyp und der Parkdauer. |

### Lastenheft

#### 1. Einleitung

##### 1.1 Ziel des Projekts

Das Ziel des Projekts ist die Entwicklung eines Parkhaussystems zur Verwaltung von Parkplätzen für Autos, Motorräder und Fahrräder. Das System soll die Parkgebühren berechnen, freie Parkplätze anzeigen und den Zugang zum Parkhaus über eine Ampelregelung steuern.

##### 1.2 Projektumfang

Das System umfasst folgende Funktionen:
- Verwaltung von Parkplätzen
- Verwaltung von Fahrzeugen
- Berechnung von Parkgebühren
- Anzeige freier Parkplätze und Einnahmen
- Ampelsteuerung für den Zugang zum Parkhaus

#### 2. Anforderungen

##### 2.1 Funktionale Anforderungen

1. **Parken von Fahrzeugen:**
   - Fahrzeuge können auf den verfügbaren Parkplätzen geparkt werden.
   - Fahrzeuge können auf spezifische Typen (Auto, Motorrad, Fahrrad) beschränkt sein.

2. **Entfernen von Fahrzeugen:**
   - Fahrzeuge können aus dem Parkhaus entfernt werden.
   - Die Parkplätze werden nach dem Entfernen eines Fahrzeugs wieder frei.

3. **Gebührenberechnung:**
   - Die Gebühren werden basierend auf Fahrzeugtyp und Parkdauer berechnet.
   - Der Tageshöchstpreis wird korrekt angewendet.

4. **Anzeige der freien Parkplätze:**
   - Die Anzahl der freien Parkplätze für Autos, Motorräder und Fahrräder wird angezeigt.
   - Die Einnahmen aus dem Parken werden angezeigt.

5. **Ampelsteuerung:**
   - Die Ampel zeigt an, ob das Parkhaus frei oder belegt ist (Grün oder Rot).

##### 2.2 Nicht-funktionale Anforderungen

1. **Benutzerfreundlichkeit:**
   - Die Anwendung soll über die Konsole bedienbar sein.
   - Die Informationen sollen klar und verständlich angezeigt werden.

2. **Performance:**
   - Die Anwendung soll bei normalen Nutzungsszenarien schnelle Reaktionszeiten bieten.

3. **Fehlertoleranz:**
   - Die Anwendung soll Fehler bei ungültigen Eingaben oder Berechnungen angemessen behandeln.

#### 3. Systemarchitektur

##### 3.1 Architekturüberblick

Das System besteht aus folgenden Komponenten:
- **Parkhaus:** Verwaltet die Parkplätze und Fahrzeuge.
- **Parkplatz:** Repräsentiert einen einzelnen Parkplatz.
- **Fahrzeug:** Repräsentiert ein Fahrzeug, das im Parkhaus geparkt wird.
- **Anzeige:** Zeigt die freien Parkplätze und Einnahmen an.
- **Ampel:** Steuert den Zugang zum Parkhaus.
- **Parkgebühren:** Berechnet die Parkgebühren für Fahrzeuge.

##### 3.2 Datenmodell

Die Daten werden in folgenden Klassen verwaltet:
- **Parkhaus**: Listet und verwaltet alle Parkplätze.
- **Parkplatz**: Beinhaltet Informationen über den Status eines einzelnen Parkplatzes.
- **Fahrzeug**: Beinhaltet Informationen über Fahrzeuge, die im Parkhaus geparkt werden.
- **Anzeige**: Verfolgt und zeigt die Anzahl der freien Parkplätze und Einnahmen.
- **Ampel**: Zeigt den aktuellen Status der Ampel an.
- **Parkgebühren**: Berechnet die Gebühren basierend auf den Fahrzeugdaten.

#### 4. Projektmanagement

##### 4.1 Zeitplan

- **Projektplanung:** 1 Woche
- **Entwicklung:** 4 Wochen
- **Testphase:** 2 Wochen
- **Dokumentation und Abschluss:** 1 Woche

##### 4.2 Ressourcen

- **Entwicklungsumgebung:** Visual Studio Community 2022
- **Programmiersprache:** C#

##### 4.3 Risiken

- **Technische Herausforderungen:** Probleme bei der Berechnung oder Anzeige von Informationen.
- **Zeitmanagement:** Verzögerungen bei der Entwicklung oder Testphase.
