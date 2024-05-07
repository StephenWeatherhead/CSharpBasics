namespace TheThirdEye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
            Console.WriteLine();
            Console.WriteLine("Press enter to take the test...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("When you press enter, you will be shown 7 numbers.");
            Console.WriteLine("You will have 5 seconds to remember them. And after an undisclosed");
            Console.WriteLine("amount of time, you will be asked to enter them.");
            Console.WriteLine("This is level 1.");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
        private static void Intro()
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
        }
    }
}
