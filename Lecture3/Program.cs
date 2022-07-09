using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lecture3
{
    class Program
    {
        static async Task Main(string[] args)
        {
           
            //Create
            using (ProgramContext db = new ProgramContext())
            {
                var per = new Person() { Age = 54, Name = "C" };
                var per2 = new Person() { Age = 16, Name = "D"};
                db.Persons.Add(per);
                db.Persons.Add(per2);
                db.SaveChanges();
            }
            //Get IQuerible IEnumerable
            using (ProgramContext db = new ProgramContext())
            {
                var persons = db.Persons.ToList();
                foreach(var t in persons)
                {
                    Console.WriteLine($"{t.Id}.{t.Name} - {t.Age}");
                }
            }
            //Update
            using (ProgramContext db = new ProgramContext())
            {
                var per = db.Persons.Where(x => x.Age == 23).FirstOrDefault();
                if(per != null)
                {
                    per.Name = "Changed Name 1";
                    db.SaveChanges();
                }
                var persons = db.Persons.ToList();
                foreach (var t in persons)
                {
                    Console.WriteLine($"{t.Id}.{t.Name} - {t.Age}");
                }
            }
            using (ProgramContext db = new ProgramContext())
            {
                var per = db.Persons.Where(x => x.Age > 50).FirstOrDefault();
                if (per != null)
                {
                    db.Persons.Remove(per);
                    db.SaveChanges();
                }
                var persons = db.Persons.ToList();
                foreach (var t in persons)
                {
                    Console.WriteLine($"{t.Id}.{t.Name} - {t.Age}");
                }
            }
            //using (ProgramContext db = new ProgramContext())
            //{
            //    var per = new Person() { Age = 13, Name = "A", Id = 1 };
            //    var per2 = new Person() { Age = 23, Name = "B", Id = 2 };

            //    db.Persons.Add(per);
            //    db.Persons.Add(per2);
            //    db.SaveChanges();

            //    Console.WriteLine("Objects saved");

            //    var persons = db.Persons;

            //    Console.WriteLine("Persons:");

            //    foreach(var t in persons)
            //    {
            //        Console.WriteLine($"{t.Id}.{t.Name} - {t.Age}");
            //    }
            //}
            //var Jhon = new Person("Jhon", 45);
            //var Masha = new Person("Masha", 15);

            //var JhonIsValid = Validate(Jhon);

            //var MashaIsValid = Validate(Masha);
            //Console.WriteLine($"JhonIsValid: {JhonIsValid}");
            //Console.WriteLine($"MashaIsValid: {MashaIsValid}");
        }

        static bool Validate(Person person)
        {
            Type type = typeof(Person);
            var attributes = type.GetCustomAttributes(false);
            foreach(var att in attributes)
            {
                if (att is AgeValidationAttribute ageatt)
                    return person.Age >= ageatt.Age;
            }
            return true;
        }
    }

    public class Task1
    {

        public void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello!");
        }

        public void PrintName(string name)
        {
            Thread.Sleep(3000);
            Console.WriteLine(name);
        }
        public async Task PrintNameAsync(string name)
        {
            await Task.Delay(100);
            Console.WriteLine(name);
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class AgeValidationAttribute : Attribute
    {
        public int Age { get; }
        public AgeValidationAttribute() { }
        public AgeValidationAttribute(int age) => Age = age;
    }
}
