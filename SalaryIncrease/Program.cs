using System;
using System.Collections.Generic;



namespace SalaryIncrease
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
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            Console.Write("Enter the bonus:");
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

            Console.Write("Any key to quit!");
            Console.ReadLine();
        }


    }
}
