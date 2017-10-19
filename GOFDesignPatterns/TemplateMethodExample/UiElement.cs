using System;
using System.Collections.Generic;

namespace TemplateMethodExample
{
    internal abstract class UiElement
    {
        public ICollection<UiElement> Children { get; } = new List<UiElement>();

        // Template Method
        public void Zeichnen()
        {
            // 1.
            ZeichneRahmen();
            // 2.
            ZeichneInhalt();
            // 3.
            ZeichneUnterelemente();
        }

        // Möglichkeit 1: kann bei Bedarf überschrieben werden.
        protected virtual void ZeichneRahmen() => Console.WriteLine("Zeichne default Rahmen.");

        // Möglichkeit 2: muss immer überschrieben werden.
        protected abstract void ZeichneInhalt();

        // Möglichkeit 3: kann nicht überschrieben werden.
        private void ZeichneUnterelemente()
        {
            foreach (var c in Children)
                c.Zeichnen();
        }
    }
}
