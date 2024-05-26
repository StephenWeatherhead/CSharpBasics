namespace MegaExtremeGamerAwesomenessNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! and welcome to THE MEGA EXTREME GAMER AWESOMENESS NETWORK!");
            Console.WriteLine("Or MEGAN for short.");
            // constructor type implied from left side
            Gamer jemma = new ("Jemma", DateTime.Now);
            jemma.MakeAKill();
            jemma.Died();
            jemma.MakeAKill(3);
            jemma.Died();
            jemma.MakeAKill(7);
            jemma.PrintGamerDeets();
            double kd = jemma.CalculateKD();
            Console.WriteLine($"Jemma's KD is {kd}");
            Console.ReadLine();
        }
    }
}
