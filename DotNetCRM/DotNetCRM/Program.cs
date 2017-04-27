using Database.Context;
using DataModels.Entities;
using Restful;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace DotNetCRM
{
    class Program
    {
        private static WebServiceHost _host;

        static void Main(string[] args)
        {
            //Console.WriteLine("Read Database:");
            //ReadDatabase();
            //ReadKey();

            //Console.WriteLine("\nInsert Employee");
            //InsertEmployee();
            //ReadKey();

            StartRestful();

            ReadKey();
            _host.Close();
        }

        private static void StartRestful()
        {
            _host = new WebServiceHost(typeof(PcrmService));
            try
            {
                _host.Open();
                Console.WriteLine($"{_host.Description.ServiceType} is up and running with these endpoints:");
                foreach (ServiceEndpoint se in _host.Description.Endpoints)
                    Console.WriteLine(se.Address);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                _host.Abort();
            }
        }

        private static void InsertEmployee()
        {
            Employee emp = new Employee
            {
                Firstname = "Ordos",
                Lastname = "Feuermensch",
                Department = "Zeitlose Insel",
                Salary = 80
            };

            using (var context = new PcrmContext())
            {
                var project = context.Projects.Find(1);
                emp.Projects.Add(project);
                if (context.Employees.Where(e => e.Firstname.Equals(emp.Firstname)).Any())
                {
                    context.Employees.Add(emp);
                    context.SaveChanges();
                }
            }
        }

        static void ReadDatabase()
        {
            using (var context = new PcrmContext())
            {
                Console.WriteLine("Employees:");
                foreach (var e in context.Employees.ToList())
                {
                    Console.WriteLine($"  Employee #{e.Id}: {e.Firstname} {e.Lastname}");
                    foreach (var pro in e.Projects)
                    {
                        Console.WriteLine($"    -{pro.Name}");
                    }
                }
                Console.WriteLine("Projects:");
                foreach (var p in context.Projects.ToList())
                {
                    Console.WriteLine($"  Project #{p.Id}: {p.Name} - {p.Description}");
                    Console.Write("=> ");
                    foreach (var emp in p.Employees)
                    {
                        Console.Write($"{emp.Firstname} {emp.Lastname}, ");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void ReadKey()
        {
            Console.Write("Press Key...");
            Console.ReadKey();
        }
    }
}
