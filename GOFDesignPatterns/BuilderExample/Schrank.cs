using System;

namespace BuilderExample
{
    internal class Schrank
    {
        public const byte MinTüren = 2;
        public const byte MaxTüren = 6;
        public const byte MinBöden = 0;
        public const byte MaxBöden = 7;

        private Schrank(byte anzahlTüren) => AnzahlTüren = anzahlTüren;

        public byte AnzahlTüren { get; }
        public Oberfläche Oberfläche { get; private set; }
        public Farbe Farbe { get; private set; }
        public byte AnzahlBöden { get; private set; }
        public bool Metalschienen { get; private set; }
        public bool Kleiderstange { get; private set; }

        public class Builder
        {
            private readonly Schrank schrank;

            public Builder(byte anzahlTüren)
            {
                if (anzahlTüren < MinTüren || anzahlTüren > MaxTüren)
                    throw new ArgumentException(nameof(anzahlTüren), $"Anzahl der Türen muss zwischen {MinTüren} und {MaxTüren} liegen.");

                schrank = new Schrank(anzahlTüren)
                {
                    Oberfläche = Oberfläche.Lackiert,
                    Farbe = Farbe.Weiß,
                    AnzahlBöden = 3,
                    Metalschienen = false,
                    Kleiderstange = false
                };
            }

            public Builder MitOberfläche(Oberfläche oberfläche)
            {
                if (oberfläche != Oberfläche.Lackiert && schrank.Farbe != Farbe.KeineFarbe)
                    schrank.Farbe = Farbe.KeineFarbe;

                schrank.Oberfläche = oberfläche;

                return this;
            }

            public Builder InFarbe(Farbe farbe)
            {
                if (farbe != Farbe.KeineFarbe && schrank.Oberfläche != Oberfläche.Lackiert)
                    throw new ArgumentException("Eine Farbe kann nur bei Oberfläche Lackiert gesetzt werden.");

                schrank.Farbe = farbe;

                return this;
            }

            public Builder MitBöden(byte anzahl)
            {
                if (anzahl < MinBöden || anzahl > MaxBöden)
                    throw new ArgumentException($"Anzahl der Böden muss zwischen {MinBöden} und {MaxBöden} liegen.");

                schrank.AnzahlBöden = anzahl;

                return this;
            }

            public Builder MitMetallschienen()
            {
                schrank.Metalschienen = true;
                return this;
            }

            public Builder MitKleiderstange()
            {
                schrank.Kleiderstange = true;
                return this;
            }

            public Schrank Build() => (Schrank)schrank.MemberwiseClone();
        }
    }
}
