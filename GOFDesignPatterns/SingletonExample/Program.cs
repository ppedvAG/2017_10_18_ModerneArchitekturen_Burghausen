using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Configuration.Instance)
            {

            }
        }
    }
}
