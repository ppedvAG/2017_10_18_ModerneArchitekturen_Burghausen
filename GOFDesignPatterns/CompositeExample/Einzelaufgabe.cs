using System;

namespace CompositeExample
{
    internal class Einzelaufgabe : Aufgabe
    {
        public Einzelaufgabe(string beschreibung) : base(beschreibung)
        { }

        private bool _istErledigt;
        public override bool IstErledigt => _istErledigt;

        public override void Erledigen()
        {
            if(!IstErledigt)
            {
                Console.WriteLine($"\t{Beschreibung} wird erledigt.");
                _istErledigt = true;
            }
        }
    }
}
