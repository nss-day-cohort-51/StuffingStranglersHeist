using System;
using System.Collections.Generic;
using System.Linq;

namespace Stuffingstranglers
{
    class Program
    {
        class TeamMember
        {
            public string Name { get; set; }
            public int Skill { get; set; }
            public double Courage { get; set; }
            public TeamMember(string name, int skill, double courage)
            {
                Name = name;
                Skill = skill;
                Courage = courage;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist");
            Console.WriteLine("---------------");

            int bankDifficultyLevel = 100;
            List<Skill> allSkill = new List<Skill>()
            {

            };
            List<TeamMember> allTeamMembers = new List<TeamMember>()
            {

            };


            while (true)
            {
                Console.WriteLine("Enter Team Member's Name");
                string TeamMemberName = Console.ReadLine();
                if (String.IsNullOrEmpty(TeamMemberName))
                {
                    break;
                }

                Console.WriteLine("Enter Team Member's Skill Level");
                int TeamMemberSkill = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Team Member's Courage Level");
                double TeamMemberCourage = double.Parse(Console.ReadLine());
                TeamMember newTeamMembers = new TeamMember(TeamMemberName, TeamMemberSkill, TeamMemberCourage);
                allTeamMembers.Add(newTeamMembers);

                // foreach (TeamMember teamMember in allTeamMembers)
                // {

                //     Console.WriteLine($"Your Team Member's Name is {teamMember.Name}, their Skill Level is {teamMember.Skill}, and their Courage Level is {teamMember.Courage}");

                // }

                Console.WriteLine($"You have {allTeamMembers.Count} team members");
            };
            int skillSum = .Skill.Sum();

        }
    }
}

