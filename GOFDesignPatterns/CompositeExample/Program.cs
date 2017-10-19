using System;

namespace CompositeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var aufgaben = new AufgabenListe("Alles mögliche");
            aufgaben.Hinzufügen(new Einzelaufgabe("Welt retten"));
            aufgaben.Hinzufügen(new Einzelaufgabe("Design Patterns lernen"));

            var urlaub = new AufgabenListe("Urlaubsvorbereitung");

            var kofferPacken = new AufgabenListe("Koffer Packen");
            kofferPacken.Hinzufügen(new Einzelaufgabe("Badehose"));
            kofferPacken.Hinzufügen(new Einzelaufgabe("Handtuch"));
            kofferPacken.Hinzufügen(new Einzelaufgabe("Sonnencreme"));

            urlaub.Hinzufügen(new Einzelaufgabe("Reispass beantragen"));
            urlaub.Hinzufügen(kofferPacken);
            aufgaben.Hinzufügen(urlaub);

            aufgaben.Erledigen();

            Console.WriteLine("\n\n\n");
            foreach (var a in aufgaben)
            {
                Console.WriteLine(a.Beschreibung);
            }

            var aufgabenEnumerator = aufgaben.GetEnumerator();
            aufgabenEnumerator.Reset();
            while(aufgabenEnumerator.MoveNext())
            {
                var a = aufgabenEnumerator.Current;
                Console.WriteLine(a.Beschreibung);
            }
            aufgabenEnumerator.Reset();


            Console.ReadLine();
        }
    }
}
