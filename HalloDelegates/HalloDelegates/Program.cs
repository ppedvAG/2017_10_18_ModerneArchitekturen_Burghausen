using System;

namespace HalloDelegates
{
    internal delegate string MyDelegate(int zahl, double wert);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(MeineMethode);

            var result = del.Invoke(5, 9);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static string MeineMethode(int i, double d)
        {
            return (i + d).ToString();
        }
    }
}
