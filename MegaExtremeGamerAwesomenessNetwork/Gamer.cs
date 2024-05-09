using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaExtremeGamerAwesomenessNetwork
{
    internal class Gamer
    {
        public Guid megId;
        public string gamerTag;

        public int kills;
        public int deaths;

        public DateTime cakeDay;

        public void Kill()
        {
            Kill(1);
        }

        public void Kill(int numberOfKills)
        {
            kills += numberOfKills;
            Console.WriteLine($"{gamerTag} made {numberOfKills} kill(s)!");
        }

        public double CalculateKD()
        {
            double ratio = (double)kills / (double)(deaths + 1);
            Console.WriteLine($"{gamerTag} has a K/D ratio of {ratio}");
            return ratio;
        }

        public void PrintGamerDeets()
        {
            Console.WriteLine($"MegId: {megId} Tag: {gamerTag}");
            Console.WriteLine($"Kills: {kills} Deaths: {deaths}");
            Console.WriteLine($"Cake Day: {cakeDay.ToShortDateString()}");
        }
    }
}
