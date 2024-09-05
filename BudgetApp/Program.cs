namespace BudgetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Budget myBudget = new Budget("Oreo Budget", 100, 
                DateOnly.FromDateTime(DateTime.Today),
                DateOnly.FromDateTime(DateTime.Today.AddDays(30)));

            Console.WriteLine($"# {myBudget.Name}");
            Console.WriteLine($"Total Budget: {myBudget.Amount:C}");
            Console.WriteLine($"Daily Spend: {myBudget.CalculateDailySpend():C}");
            Console.WriteLine($"Weekly Spend: {myBudget.CalculateWeeklySpend():C}");
        }
    }
    public class Budget(string name, double amount, DateOnly startDate, DateOnly endDate)
    {
        public string Name { get => name; private set { name = value; } }
        public double Amount { get => amount; private set { amount = value; } }
        public DateOnly StartDate { get => startDate; set => startDate = value; }
        public DateOnly EndDate { get => endDate; set => endDate = value; }

        public double CalculateDailySpend()
        {
            DateTime startTime = startDate.ToDateTime(TimeOnly.MinValue);
            DateTime endTime = endDate.ToDateTime(TimeOnly.MinValue).AddDays(1);
            TimeSpan time = endTime - startTime;
            double totalDays = time.TotalDays;
            return amount / totalDays;
        }
        public double CalculateWeeklySpend()
        {
            return CalculateDailySpend() * 7;
        }
    }
}
