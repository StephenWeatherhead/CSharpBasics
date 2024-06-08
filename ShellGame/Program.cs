namespace ShellGame
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello weary traveller! Care to make a wager? See this ball here?");
            Console.WriteLine("See if you can follow it...");
            Console.WriteLine();
            Table table = new Table();
            table.Position1 = CupState.BallInCup;
            table.PrintTable();
            Console.WriteLine();
            Console.WriteLine("Press enter to shuffle...");
            Console.ReadLine();

            Console.Clear();
            table.PrintTable();
            await Task.Delay(1000);
            Console.Clear();
            Table.PrintCupsDown();
            await Task.Delay(1000);

            for(int i = 0; i < 10; i++)
            {
                Console.Clear();
                table.Shuffle();
                await Task.Delay(500);
                Console.Clear();
                Table.PrintCupsDown();
                await Task.Delay(250);
            }
            Console.Clear();
            Table.PrintCupsDown();
            await Task.Delay(2000);
            Console.WriteLine("Where do you think the ball is? Press enter to find out...");
            Console.ReadLine();
            Console.Clear();
            table.PrintTable();
            Console.ReadLine();
        }
    }

    public enum CupState
    {
        NoBallInCup,
        BallInCup
    }

    public struct Table
    {
        public CupState Position1;
        public CupState Position2;
        public CupState Position3;

        public string GetBallString(CupState cupState)
        {
            if (cupState == CupState.BallInCup)
                return "O";
            return " ";
        }

        public void PrintTable()
        {
            Console.WriteLine("|Z| |Z| |Z|");
            Console.WriteLine($" {GetBallString(Position1)}   {GetBallString(Position2)}   {GetBallString(Position3)} ");
        }

        public static void PrintCupsDown()
        {
            Console.WriteLine("           ");
            Console.WriteLine("|Z| |Z| |Z|");
        }

        public void Shuffle()
        {
            int move = Random.Shared.Next(3);
            switch (move)
            {
                case 0:
                    Console.WriteLine(" *   *     ");
                    Console.WriteLine("|Z| |Z| |Z|");
                    CupState temp1 = Position1;
                    Position1 = Position2;
                    Position2 = temp1;
                    break;
                case 1:
                    Console.WriteLine(" *       * ");
                    Console.WriteLine("|Z| |Z| |Z|");
                    CupState temp2 = Position1;
                    Position1 = Position3;
                    Position3 = temp2;
                    break;
                case 2:
                    Console.WriteLine("     *   * ");
                    Console.WriteLine("|Z| |Z| |Z|");
                    CupState temp3 = Position2;
                    Position2 = Position3;
                    Position3 = temp3;
                    break;
            }
        }
    }
}
