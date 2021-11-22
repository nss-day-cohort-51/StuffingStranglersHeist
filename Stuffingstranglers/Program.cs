using System;
using System.Collections.Generic;

namespace Stuffingstranglers
{
    class Program
    {
        class TeamMember
        {
            public string Name { get; set; }
            public int Skill { get; set; }
            public double Courage { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("---------------");

            Console.WriteLine("Enter Team Member's Name");
            string TeamMemberName = Console.ReadLine();

            Console.WriteLine("Enter Team Member's Skill Level");
            string TeamMemberSkill = Console.ReadLine();

            Console.WriteLine("Enter Team Member's Courage Level");
            string TeamMemberCourage = Console.ReadLine();

            Console.WriteLine($"Your Team Member's Name is {TeamMemberName}, their Skill Level is {TeamMemberSkill}, and their Courage Level is {TeamMemberCourage}");
        }
    }
}
