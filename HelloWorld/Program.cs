using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var projectTeam = "Happy Team";
            Console.WriteLine("Hello everyone!");
            Console.WriteLine($"My project team is {projectTeam}");
            Console.WriteLine($"These are my team members:");
            var memberNames = new List<string> { "Desmond", "Felipe",
"Emillia", "Alan" };
            foreach (var member in memberNames)
            {
                Console.WriteLine(member);
            }
        }
    }
}