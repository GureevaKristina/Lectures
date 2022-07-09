using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lecture3
{
    //[AgeValidationAttribute(18)]
    public class Person
    {
        [Column ("person_id")]
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public Gender Gender { get; set; }
        public ICollection<Work> Works{ get; set; }
        public Person()
        {

        }
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }


    }

    public class Gender
    {
        public int Id { get; set; }
        public string  Name { get; set; }
    }
    public class Work
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class PurchaserBuyer
    {
        public int PurchaserId { get; set; }
        public int BuyerId { get; set; }
    }
}
