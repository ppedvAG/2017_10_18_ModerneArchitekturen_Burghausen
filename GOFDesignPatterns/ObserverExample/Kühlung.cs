using System;

namespace ObserverExample
{
    internal class Kühlung : ITemperaturGeändert
    {
        private bool _istEingeschalten;

        public void NeueTemperatur(int temperatur)
        {
            if (!_istEingeschalten && temperatur > 35)
            {
                Console.WriteLine("Kühlung einschalten");
                _istEingeschalten = true;
            }
            else if (_istEingeschalten && temperatur < 27)
            {
                Console.WriteLine("Kühlung ausschalten");
                _istEingeschalten = false;
            }
        }
    }
}