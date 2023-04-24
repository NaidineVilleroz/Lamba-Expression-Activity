using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person> {
            new Person { Name = "Naidine", Age = 25 },
            new Person { Name = "Brian", Age = 30 },
            new Person { Name = "Shereece", Age = 20 },
            new Person { Name = "Anna", Age = 35 },
            new Person { Name = "Reignan", Age = 28 }
        };

        var filteredPeople = people.Where(p => p.Age > 25);

  
        foreach (var person in filteredPeople)
        {
            Console.WriteLine(person.Name + " is older than 25");

            if (person.Name.StartsWith("A"))
            {
                Console.WriteLine("Their name starts with 'A'");
            }
            else if (person.Name.StartsWith("B"))
            {
                Console.WriteLine("Their name starts with 'B'");
            }
            else
            {
                Console.WriteLine("Their name does not start with 'A' or 'B'");
            }
        }
    }
}