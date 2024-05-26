using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaExtremeGamerAwesomenessNetwork
{
    // primary constructor - creates and sets private fields
    internal class Gamer(string gamerTag, DateTime cakeDay)
    {
        private int kills;
        private int deaths;

        public void Died()
        {
            deaths++;
            Console.WriteLine($"{gamerTag} died!");
        }

        public void MakeAKill()
        {
            MakeAKill(1);
        }

        public void MakeAKill(int numberOfKills)
        {
            kills += numberOfKills;
            Console.WriteLine($"{gamerTag} made {numberOfKills} kill(s)!");
        }

        public double CalculateKD()
        {
            double ratio = (double)kills / (double)(deaths == 0 ? 1 : deaths);
            Console.WriteLine($"{gamerTag} has a K/D ratio of {ratio}");
            return ratio;
        }

        public void PrintGamerDeets()
        {
            Console.WriteLine($"Tag: {gamerTag}");
            Console.WriteLine($"Kills: {kills} Deaths: {deaths}");
            Console.WriteLine($"Cake Day: {cakeDay.ToShortDateString()}");
        }
    }
}
