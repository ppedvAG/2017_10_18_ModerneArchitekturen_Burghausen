using System;

namespace TemplateMethodExample
{
    internal class Window : UiElement
    {
        protected override void ZeichneInhalt() => Console.WriteLine("Zeichne Window Inhalt.");

        // optional
        protected override void ZeichneRahmen() => Console.WriteLine("Zeichne Window Rahmen.");
    }
}
