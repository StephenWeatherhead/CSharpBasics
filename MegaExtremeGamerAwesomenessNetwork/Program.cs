namespace MegaExtremeGamerAwesomenessNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! and welcome to THE MEGA EXTREME GAMER AWESOMENESS NETWORK!");
            Console.WriteLine("Or MEGAN for short.");
            Gamer jemma = new Gamer();
            jemma.Kill();
            jemma.Kill(12);
            jemma.PrintGamerDeets();
            jemma.CalculateKD();
            Console.ReadLine();
        }
    }
}
