using System;
using System.Collections.Generic;

namespace ObserverExample
{
    public class Sensor
    {
        //private List<ITemperaturGeändert> _geräte = new List<ITemperaturGeändert>();        
        //private List<Action<int>> _geräte = new List<Action<int>>();

        public event Action<int> TemperaturGeändert;

        public void Messe(int temperatur)
        {
            // misst tempertur

            TemperaturGeändert?.Invoke(temperatur);

            //foreach (var g in _geräte)
            //    g?.Invoke(temperatur);
        }

        //internal void Anmelden(ITemperaturGeändert gerät) => _geräte.Add(gerät);
        //internal void Anmelden(Action<int> gerät) => _geräte.Add(gerät);

        //internal void Abmelden(ITemperaturGeändert gerät) => _geräte.Remove(gerät);
        //internal void Abmelden(Action<int> gerät) => _geräte.Remove(gerät);
    }
}
