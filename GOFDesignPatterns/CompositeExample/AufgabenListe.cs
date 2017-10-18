using System;
using System.Collections.Generic;
using System.Linq;

namespace CompositeExample
{
    internal class AufgabenListe : Aufgabe
    {
        public AufgabenListe(string beschreibung) : base(beschreibung)
        { }

        private readonly List<Aufgabe> aufgaben = new List<Aufgabe>();

        public override bool IstErledigt => aufgaben.All(a => a.IstErledigt);

        public override void Erledigen()
        {
            if(!IstErledigt)
            {
                Console.WriteLine($"{Beschreibung} wird erledgit.");

                aufgaben.ForEach(a => a.Erledigen());
            }
        }

        public void Hinzufügen(Aufgabe aufgabe) => aufgaben.Add(aufgabe);
    }
}
