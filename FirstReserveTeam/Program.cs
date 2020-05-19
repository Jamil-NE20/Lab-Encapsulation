using System;
using System.Collections.Generic;


namespace FirstReserveTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Line Number: ");
            var lines = int.Parse(Console.ReadLine());
            Console.WriteLine("\n//Enter the Lexicon Team member's information//");
            //var persons = new List<Person>();
            var team = new Team("Lexicon");
            
            for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0],
                                            cmdArgs[1],
                                            int.Parse(cmdArgs[2]),
                                            decimal.Parse(cmdArgs[3]));

                    

                    team.AddPlayer(person);
                
                
                }
            Console.WriteLine("\n\nLexicon Team:\n");
            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            Console.WriteLine("\nAny key to quit!");
            Console.ReadLine();
        }
    }
}
