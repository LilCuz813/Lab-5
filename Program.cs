using System.Linq;

Console.WriteLine("Welcome to the Shopping List");
Dictionary<string, decimal> groceries = new Dictionary<string, decimal>();
List<string> items = new List<string>();
List<decimal> price = new List<decimal>();
groceries.Add("bread", 3.99m);
groceries.Add("cheese", 4.99m);
groceries.Add("milk", 3.59m);
groceries.Add("strawberries", 2.99m);
groceries.Add("lemonade", 4.29m);
groceries.Add("batteries", 7.99m);
groceries.Add("soap", 2.69m);
groceries.Add("toothpaste", 3.39m);
groceries.Add("bleach", 5.99m);
groceries.Add("ground turkey", 10.99m);

foreach (KeyValuePair<string, decimal> kvp in groceries)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

bool goRestart = true;
while (true)
{
    Console.WriteLine("Enter a item on the list: ");
    string item = Console.ReadLine();
    decimal prices = groceries[item];
    Console.WriteLine($"{item} is ${prices}");
    if (groceries.ContainsKey(item))
    {
        items.Add(item);
        price.Add(groceries[item]);
        Console.WriteLine($"The {item} has been added for ${groceries[item]}.");
        Console.WriteLine("Would you like to add another item? y/n");
        string choice = Console.ReadLine();
        if (choice == "y")
        {
            goRestart = true;
        }
        else if(choice == "n")
        {
            goRestart = false;
            break;
            
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
            
        }
    }
}
foreach(string i in items)
{
    Console.WriteLine($"{i} \t${groceries[i]}");
}
decimal total = price.Sum();
Console.WriteLine($"Your total is: ${total}");
Console.ReadLine();