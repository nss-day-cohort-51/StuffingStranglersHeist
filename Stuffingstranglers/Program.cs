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

           
            List<TeamMember> allTeamMembers = new List<TeamMember>() {
                     
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
                TeamMember newTeamMembers= new TeamMember(TeamMemberName, TeamMemberSkill, TeamMemberCourage);
                allTeamMembers.Add(newTeamMembers);

        //          foreach(TeamMember newTeamMember in allTeamMembers){
                     
        //        Console.WriteLine($"Your Team Member's Name is {TeamMemberName}, their Skill Level is {TeamMemberSkill}, and their Courage Level is {TeamMemberCourage}");
              
        //    }
            Console.WriteLine($"Your Team Member's Name is {TeamMemberName}, their Skill Level is {TeamMemberSkill}, and their Courage Level is {TeamMemberCourage}");
            Console.WriteLine($"You have {allTeamMembers.Count} team members");
            };


        }
    }
}

