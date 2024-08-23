namespace NutritionInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("# Bran Flakes 100g");
            NutritionInfo branFlakes = new NutritionInfo
            {
                Name = "Bran Flakes",
                PortionGrams = 100,
                EnergykJ = 1513,
                EnergykCal = 359,
                FatGrams = 2.5,
                SaturatesGrams = 0.5,
                SugarsGrams = 11,
                SaltGrams = 0.28
            };
            branFlakes.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("# Bran Flakes 30g");
            NutritionInfo branFlakes30g = branFlakes.GetInfoForPortionSize(30);
            branFlakes30g.PrintInfo();
            Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class NutritionInfo
    {
        public string Name { get; set; }
        public double PortionGrams { get; set; }
        public double EnergykJ { get; set; }
        public double EnergykCal { get; set; }
        public double FatGrams { get; set; }
        public double SaturatesGrams { get; set; }
        public double SugarsGrams { get; set; }
        public double SaltGrams { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Portion: {PortionGrams} g");
            Console.WriteLine($"Energy: {EnergykJ} kJ");
            Console.WriteLine($"Energy: {EnergykCal} kCal");
            Console.WriteLine($"Fat: {FatGrams} g");
            Console.WriteLine($"Saturates: {SaturatesGrams} g");
            Console.WriteLine($"Sugars: {SugarsGrams} g");
            Console.WriteLine($"Salt: {SaltGrams} g");
        }
        public NutritionInfo GetInfoForPortionSize(double portionSize)
        {
            return new NutritionInfo
            {
                Name = Name,
                PortionGrams = portionSize,
                EnergykJ = (EnergykJ/PortionGrams) * portionSize,
                EnergykCal = (EnergykCal / PortionGrams) * portionSize,
                FatGrams = (FatGrams / PortionGrams) * portionSize,
                SaturatesGrams = (SaturatesGrams / PortionGrams) * portionSize,
                SugarsGrams = (SugarsGrams / PortionGrams) * portionSize,
                SaltGrams = (SaltGrams / PortionGrams) * portionSize,
            };
        }
    }
}
