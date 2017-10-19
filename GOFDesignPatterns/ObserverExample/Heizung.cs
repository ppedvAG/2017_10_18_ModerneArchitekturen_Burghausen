using System;

namespace ObserverExample
{
    internal class Heizung : ITemperaturGeändert
    {
        private bool _istEingeschalten;

        public void NeueTemperatur(int temperatur)
        {
            if(!_istEingeschalten && temperatur < 15)
            {
                Console.WriteLine("Heizung einschalten");
                _istEingeschalten = true;
            }
            else if(_istEingeschalten && temperatur > 22)
            {
                Console.WriteLine("Heizung ausschalten");
                _istEingeschalten = false;
            }
        }
    }
}