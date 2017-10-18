namespace CompositeExample
{
    internal abstract class Aufgabe
    {
        public Aufgabe(string beschreibung) => Beschreibung = beschreibung;

        public string Beschreibung { get; }
        public abstract bool IstErledigt { get; }
        public abstract void Erledigen();
    }
}
