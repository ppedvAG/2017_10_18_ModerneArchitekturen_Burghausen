using System;

namespace TemplateMethodExample
{
    internal class Button : UiElement
    {
        protected override void ZeichneInhalt() => Console.WriteLine("Zeichne Button Inhalt.");
    }
}
