namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of items:");
            int numberOfItems = int.Parse(Console.ReadLine());
            ShoppingListItem[] shoppingList = new ShoppingListItem[numberOfItems];
            for(int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine($"# Item {i + 1}");
                ShoppingListItem newItem = new ShoppingListItem();
                Console.WriteLine("Enter item name:");
                newItem.Name = Console.ReadLine();
                Console.WriteLine("Enter item cost: ");
                newItem.Cost = double.Parse(Console.ReadLine());
                shoppingList[i] = newItem;
            }
            Console.Clear();
            Console.WriteLine("# Shopping List");
            foreach(ShoppingListItem listItem in shoppingList)
            {
                Console.WriteLine($"{listItem.Name}\t{listItem.Cost:C}");
            }
            double totalCost = shoppingList.Sum(item => item.Cost);
            Console.WriteLine($"Total Cost\t{totalCost:C}");
        }
    }

    public class ShoppingListItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
