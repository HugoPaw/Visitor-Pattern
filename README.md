# Visitor Pattern in C#

**Visitor** ist ein Entwurfsmuster in C#, das dir erlaubt, **neue Operationen auf bestehenden Klassen hinzuzufügen, ohne deren Code zu verändern**.  
Statt Methoden in die Klassen zu schreiben übernimmt ein **Visitor** diese Aufgaben.

---

## Mini-Erklärung

- Du hast eine Sammlung von Objekten (z.B. `Auto`, `Fahrrad`).
- Du willst verschiedene Aktionen auf ihnen ausführen (z.B. `Wartung`, `Versicherung prüfen`).
- Statt jede Klasse dafür anzupassen **erstellt man einen Visitor** der diese Aktionen kennt.

---

## Beispiel

In der Datei `Visitor.cs` ist ein einfaches Beispiel enthalten:

- `Auto` und `Fahrrad` sind Klassen, die ein gemeinsames Interface `IFahrzeug` implementieren.
- Ein Visitor (`WartungsVisitor`) besucht jedes Fahrzeug und führt eine passende Wartung durch.
- Neue Operationen können durch weitere Visitor-Klassen hinzugefügt werden – **ohne die Fahrzeugklassen zu verändern**.

---

## Vorteile

- Trennung von Datenstruktur und Logik
- Einfaches Hinzufügen neuer Funktionen
- Keine Änderung an bestehenden Klassen notwendig

---

> Siehe `Visitor.cs` für eine vollständige Implementierung in C#.
