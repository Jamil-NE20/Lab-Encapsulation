using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Line Number: ");
            var lines = int.Parse(Console.ReadLine());
            Console.WriteLine("\n//Enter the Person information//");
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Write("\n\nEnter the bonus:");
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));


            Console.Write("Any key to quit!");
            Console.ReadLine();
        }
    }
}
