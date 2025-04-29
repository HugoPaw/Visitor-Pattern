// 1. Interface für alle Fahrzeuge
interface IFahrzeug
{
    void Akzeptiere(IVisitor visitor);
}

// 2. Konkret: Auto
class Auto : IFahrzeug
{
    public void Akzeptiere(IVisitor visitor)
    {
        visitor.BesucheAuto(this);
    }
}

// 3. Konkret: Fahrrad
class Fahrrad : IFahrzeug
{
    public void Akzeptiere(IVisitor visitor)
    {
        visitor.BesucheFahrrad(this);
    }
}

// 4. Visitor-Interface
interface IVisitor
{
    void BesucheAuto(Auto auto);
    void BesucheFahrrad(Fahrrad fahrrad);
}

// 5. Konkreter Visitor: Wartung
class WartungsVisitor : IVisitor
{
    public void BesucheAuto(Auto auto)
    {
        Console.WriteLine("Auto wird gewartet.");
    }

    public void BesucheFahrrad(Fahrrad fahrrad)
    {
        Console.WriteLine("Fahrrad wird geölt.");
    }
}

// 6. Anwendung
class Program
{
    static void Main()
    {
        var fahrzeuge = new List<IFahrzeug> { new Auto(), new Fahrrad() };
        var wartung = new WartungsVisitor();

        foreach (var f in fahrzeuge)
        {
            f.Akzeptiere(wartung);
        }
    }
}
