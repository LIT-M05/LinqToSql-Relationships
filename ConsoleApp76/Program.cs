using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace ConsoleApp76
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PeopleCarsDataContext())
            {
                context.Log = Console.Out;

                //var loadOptions = new DataLoadOptions();
                //loadOptions.LoadWith<Person>(p => p.Cars);
                //context.LoadOptions = loadOptions;

                //foreach (Person person in context.Persons)
                //{
                //    Console.WriteLine($"{person.FirstName} {person.LastName}");
                //    foreach (Car car in person.Cars)
                //    {
                //        Console.WriteLine($"\t{car.Make} {car.Model}");
                //    }
                //}

                //Car car = context.Cars.FirstOrDefault(c => c.Id == 4);
                //Console.WriteLine(car.Person.FirstName + " " + car.Person.LastName);

                //Person person = context.Persons.FirstOrDefault(p => p.Id == 1028);
                //Car car = new Car
                //{
                //    Make = "Porsche",
                //    Model = "911",
                //    Year = 2017
                //};
                //person.Cars.Add(car);
                //context.SubmitChanges();
                //Console.WriteLine(car.PersonId);
                //Car car = new Car
                //{
                //    Make = "Nissan",
                //    Model = "GTR",
                //    Year = 2018,
                //    PersonId = 1029
                //};
                //context.Cars.InsertOnSubmit(car);
                //context.SubmitChanges();
            }

            Console.ReadKey(true);
        }
    }
}
