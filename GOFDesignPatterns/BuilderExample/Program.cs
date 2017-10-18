using System;

namespace BuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultSchrank = new Schrank.Builder(5).Build();

            var customSchrank = new Schrank.Builder(3)
                .MitOberfläche(Oberfläche.Unbehandelt)
                .MitBöden(3)
                .MitKleiderstange()
                .MitMetallschienen()
                .Build();

            var webSchrankBuilder = new Schrank.Builder(Schrank.MinTüren);

            // nächste Seite
            // es vergeht viel Zeit

            webSchrankBuilder.MitOberfläche(Oberfläche.Lackiert);

            // nächste Seite
            // es vergeht viel Zeit

            webSchrankBuilder.InFarbe(Farbe.Blau);


            webSchrankBuilder.MitBöden(Schrank.MinBöden);

            // nächste Seite
            // es vergeht viel Zeit
            // es wurde bezahlt

            var schrank = webSchrankBuilder.Build();

            Console.WriteLine($"Anzahl Böden nach dem Bezahlen: {schrank.AnzahlBöden}");


            webSchrankBuilder.MitBöden(Schrank.MaxBöden);
            Console.WriteLine($"Anzahl Böden nach Hacken Bezahlen: {schrank.AnzahlBöden}");
        }
    }
}
