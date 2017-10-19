using System;

namespace ObserverExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var heizung = new Heizung();
            var kühlung = new Kühlung();

            var sensor = new Sensor();
            sensor.TemperaturGeändert += heizung.NeueTemperatur;
            sensor.TemperaturGeändert += kühlung.NeueTemperatur;
            sensor.TemperaturGeändert += t => Console.WriteLine($"\n{t} Grad Celsius");
            //sensor.Anmelden(heizung.NeueTemperatur);
            //sensor.Anmelden(kühlung.NeueTemperatur);

            sensor.Messe(10);

            sensor.Messe(40);
            sensor.TemperaturGeändert -= kühlung.NeueTemperatur;
            //sensor.Abmelden(kühlung.NeueTemperatur);

            sensor.Messe(23);

            Console.ReadKey();
        }
    }
}
