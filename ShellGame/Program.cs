namespace ShellGame
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello weary traveller! Care to make a wager? See this ball here?");
            Console.WriteLine("See if you can follow it...");
            Console.WriteLine();
            
            // assign all fields in table
            Table table;
            table.Position1 = CupState.BallInCup;
            table.Position2 = CupState.NoBallInCup;
            table.Position3 = CupState.NoBallInCup;

            Table.PrintTable(table);
            Console.WriteLine();
            Console.WriteLine("Press enter to shuffle...");
            Console.ReadLine();

            Console.Clear();
            Table.PrintTable(table);
            await Task.Delay(1000);
            Console.Clear();
            Table.PrintCupsDown();
            await Task.Delay(1000);

            for(int i = 0; i < 10; i++)
            {
                Console.Clear();
                Table.Shuffle(ref table);
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
            Table.PrintTable(table);
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

        public static string GetBallString(CupState cupState)
        {
            if (cupState == CupState.BallInCup)
                return "O";
            return " ";
        }

        public static void PrintTable(Table table)
        {
            Console.WriteLine("|Z| |Z| |Z|");
            Console.WriteLine($" {GetBallString(table.Position1)}   {GetBallString(table.Position2)}   {GetBallString(table.Position3)} ");
        }

        public static void PrintCupsDown()
        {
            Console.WriteLine("           ");
            Console.WriteLine("|Z| |Z| |Z|");
        }

        public static void Shuffle(ref Table table)
        {
            int move = Random.Shared.Next(3);
            switch (move)
            {
                case 0:
                    Console.WriteLine(" *   *     ");
                    Console.WriteLine("|Z| |Z| |Z|");
                    CupState temp1 = table.Position1;
                    table.Position1 = table.Position2;
                    table.Position2 = temp1;
                    break;
                case 1:
                    Console.WriteLine(" *       * ");
                    Console.WriteLine("|Z| |Z| |Z|");
                    CupState temp2 = table.Position1;
                    table.Position1 = table.Position3;
                    table.Position3 = temp2;
                    break;
                case 2:
                    Console.WriteLine("     *   * ");
                    Console.WriteLine("|Z| |Z| |Z|");
                    CupState temp3 = table.Position2;
                    table.Position2 = table.Position3;
                    table.Position3 = temp3;
                    break;
            }
        }
    }
}
