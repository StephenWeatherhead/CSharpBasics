using System.Text;

namespace TheThirdEye
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            WriteIntro();
            Console.ReadLine();
            Console.Clear();
            await Level1();
            Console.ReadLine();
        }

        private static async Task Level1()
        {
            Console.WriteLine("When you press enter, you will be shown 7 integers.");
            Console.WriteLine("You will have 5 seconds to remember them. And after an undisclosed");
            Console.WriteLine("amount of time, you will be asked to enter them.");
            Console.WriteLine("This is level 1.");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.Clear();
            Console.WriteLine("The numbers are below. You have 5 seconds to remember them:");
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < 7; i++)
            {
                if(i != 0)
                {
                    sb.Append("-");
                }
                sb.Append(Random.Shared.Next(100));
            }
            string numberString = sb.ToString();
            Console.WriteLine(numberString);
            await Task.Delay(5000);
            Console.Clear();
            Console.WriteLine("Now we wait...");
            await Task.Delay(10000);
            Console.Clear();
            Console.WriteLine("Please enter the numbers with a dash between them.");
            string? response = Console.ReadLine();
            if(response == numberString)
            {
                Console.WriteLine("You completed Level 1!");
            }
            else
            {
                Console.WriteLine($"You failed level 1. The answer was: {numberString}");
            }
        }

        private static void WriteIntro()
        {
            Console.WriteLine("The third eye is said to provide perception beyond ordinary sight.");
            Console.WriteLine("To access inner realms and spaces of higher consciousness.");
            Console.WriteLine("To see through the fabric of reality.");
            Console.WriteLine();
            Console.WriteLine("Chosen ones are said to have extraordinary mental abilities.");
            Console.WriteLine("Honed over hours of dedicated practice.");
            Console.WriteLine("Indeed the chosen were not born chosen. They chose to be chosen.");
            Console.WriteLine("And embarked on a journey of self-mastery.");
            Console.WriteLine();
            Console.WriteLine("The full extent of their feats are lost to the sands of time. ");
            Console.WriteLine("However, we know the chosen have extraodinary memory.");
            Console.WriteLine("This test cannot confirm you are chosen. It can only confirm");
            Console.WriteLine("you are not chosen (if you fail).");
            Console.WriteLine();
            Console.WriteLine("Press enter to take the test...");
        }
    }
}
