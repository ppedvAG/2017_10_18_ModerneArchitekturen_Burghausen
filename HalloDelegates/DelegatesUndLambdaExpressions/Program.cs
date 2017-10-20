using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegatesUndLambdaExpressions
{
    internal delegate bool MyDelegate(Employee e);
    // Action       -> void
    // Predicate    -> bool
    // Func

    class Program
    {
        static void Main(string[] args)
        {
            var employees = GetEmployees();

            //MyDelegate del = new MyDelegate(Bedingung);
            //Func<Employee, bool> del = new Func<Employee, bool>(Bedingung);
            //var del = new Func<Employee, bool>(Bedingung);
            //Func<Employee, bool> del = Bedingung;
            //var query = Abfrage(employees, del);

            //var query = Abfrage(employees, Bedingung);

            //var query = Abfrage(employees, delegate (Employee e)
            //{
            //    return e.Name.StartsWith("L");
            //});

            //var query = Abfrage(employees, (Employee e) =>
            //{
            //    return e.Name.StartsWith("L");
            //});

            //var query = Abfrage(employees, (e) =>
            //{
            //    return e.Name.StartsWith("L");
            //});

            //var query = Abfrage(employees, (e) => e.Name.StartsWith("L"));
            var experience = 5;
            var query = Abfrage(employees, (e) => e.Expreience > experience);
            var linq = employees.Where(e => e.Expreience > 5);

            foreach (var e in query)
                Console.WriteLine($"Id: {e.Id, -2} | {e.Name, 10} | {e.Expreience}");
            Console.ReadKey();
        }

        private static bool Bedingung(Employee e)
        {
            return e.Name.StartsWith("L");
        }

        private static IEnumerable<Employee> Abfrage(
            IEnumerable<Employee> employees, 
            Func<Employee, bool> predicate)
        {
            foreach (var e in employees)
                if (predicate(e))
                    yield return e;
        }

        private static IEnumerable<Employee> GetEmployees() => new[]
        {
            new Employee { Id = 1, Name = "Peter", Expreience = 5 },
            new Employee { Id = 2, Name = "Lisa", Expreience = 8 },
            new Employee { Id = 3, Name = "Hannes", Expreience = 2 },
            new Employee { Id = 4, Name = "Darian", Expreience = 10 },
            new Employee { Id = 5, Name = "Luis", Expreience = 3 },
            new Employee { Id = 6, Name = "Maria", Expreience = 7 },
            new Employee { Id = 7, Name = "Karin", Expreience = 2 }
        };
    }
}
