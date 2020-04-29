using CodeFirst.DataModel;
using System;

namespace CodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            var john = new Person
            {
                Id = Guid.NewGuid(),
                Name = "John",
                Address = new Address
                {
                    Id = Guid.NewGuid(),
                    City = "Utrecht",
                    Zipcode = "3533ar"
                }
            };

            using (var dbContext = new MyDbContext())
            {
                dbContext.Add(john);
                dbContext.SaveChanges();
            }

            Console.WriteLine("Check out the records in your database!");
        }

    }
}
