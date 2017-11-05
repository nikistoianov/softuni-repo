using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballStandings
{
    class Program
    {
        static void Main()
        {
            var teams = new SortedDictionary<string, Team>();
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "final")
            {
                string[] arr = input.Split();
                string teamA = DecriptTeam(arr[0], key).ToUpper(), teamB = DecriptTeam(arr[1], key).ToUpper();
                int[] score = arr[2].Split(':').Select(int.Parse).ToArray();

                AddTeam(teams, teamA, CalcPoints(score[0], score[1]), score[0]);
                AddTeam(teams, teamB, CalcPoints(score[1], score[0]), score[1]);

                input = Console.ReadLine();
            }

            int place = 0;
            Console.WriteLine("League standings:");
            foreach (var team in teams.OrderByDescending(x => x.Value.Points))
            {
                place++;
                Console.WriteLine($"{place}. {team.Key} {team.Value.Points}");
            }

            int count = 0;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teams.OrderByDescending(x => x.Value.Goals))
            {
                count++;
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
                if (count == 3)
                {
                    break;
                }
            }
        }

        private static void AddTeam(SortedDictionary<string, Team> teams, string team, int points, int goals)
        {
            if (teams.ContainsKey(team))
            {
                teams[team].Points += points;
                teams[team].Goals += goals;
            }
            else
            {
                teams[team] = new Team { Name = team, Points = points, Goals = goals};
            }
        }

        public static int CalcPoints(int goalsScored, int goalsResieved)
        {
            if (goalsScored > goalsResieved)
            {
                return 3;
            }
            else if (goalsScored < goalsResieved)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private static string DecriptTeam(string encriptedText, string key)
        {
            key = RegexEscaping(key);
            string pattern = key + "(.+)" + key;
            string team = Regex.Match(encriptedText, pattern).Groups[1].Value;
            string reversed = string.Join("", team.Reverse().ToArray());
            
            return reversed;
        }

        private static string RegexEscaping(string input)
        {
            string[] charToEscape = { @"\", ".", "^", "$", "*", "+", "-", "?", "(", ")", "[", "]", "{", "}", "|" };
            foreach (var ch in charToEscape)
            {
                input = input.Replace(ch, @"\" + ch);
            }
            return input;
        }
    }

    public class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
    }
}
