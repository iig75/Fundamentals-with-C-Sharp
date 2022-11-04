using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i++)
            {
                bool exist = false;

                List<string> input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (teams.Any(t => t.TeamName == input[1]))
                {
                    exist = true;
                    Console.WriteLine($"Team {input[1]} was already created!");
                }

                if (teams.Any(t => t.TeamCreator == input[0]))
                {
                    exist = true;
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }

                if (!exist)
                {
                    Team team = new Team(input[1], input[0]);
                    teams.Add(team);
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
            }



            while (true)
            {
                List<string> command = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (command[0] == "end of assignment")
                    break;

                bool exist = false;

                if (!teams.Any(t => t.TeamName == command[1]))
                {
                    exist = true;
                    Console.WriteLine($"Team {command[1]} does not exist!");
                }

                if (teams.Any(t => t.TeamMembers.Contains(command[0])))
                {
                    exist = true;
                    Console.WriteLine($"Member {command[0]} cannot join team {command[1]}!");
                }

                if (teams.Any(t => t.TeamCreator == command[0]))
                {
                    exist = true;
                    Console.WriteLine($"Member {command[0]} cannot join team {command[1]}!");
                }

                if (!exist)
                {
                    Team teamToJoin = teams.First(t => t.TeamName == command[1]);
                    teamToJoin.addMember(command[0]);
                }
            }

            List<Team> teamsWithMembers = teams
                .Where(t => t.TeamMembers.Count > 0)
                .OrderByDescending(t=>t.TeamMembers.Count)
                .ThenBy(t=>t.TeamName)
                .ToList();            

            foreach (var val in teamsWithMembers)
            {
                Console.WriteLine($"{val.TeamName}");
                Console.WriteLine($"- {val.TeamCreator}");

                val.TeamMembers.Sort();

                foreach (var mem in val.TeamMembers)
                {
                    Console.WriteLine($"-- {mem}");
                }
                    
            }

            List<Team> teamsWithoutMembers = teams
                .Where(t => t.TeamMembers.Count == 0)
                .OrderBy(t=>t.TeamName)
                .ToList();

            Console.WriteLine($"Teams to disband:");
            
            foreach (var val in teamsWithoutMembers)
            {                
                Console.WriteLine($"{val.TeamName}");                    
            }

        }
    }



    class Team
    {
        public List<string> members;

        public Team(string teamName, string teamCreator)
        {
            TeamName = teamName;
            TeamCreator = teamCreator;

            this.members = new List<string>();
        }

        public string TeamName { get; set; }

        public string TeamCreator { get; set; }

        public List<string> TeamMembers
            => this.members;

        public void addMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}
