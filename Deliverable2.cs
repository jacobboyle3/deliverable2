// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi! Welcome to our buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");

string People = (Console.ReadLine());
int NumberOfPeople;
bool success = int.TryParse(People, out NumberOfPeople);
bool valid = success && NumberOfPeople < 7;
decimal buffet = 9.99m;
decimal coffee = 2.00m;
decimal water = 0.00m;
int totalwater = 0;
int totalcoffee = 0;

decimal result1 = buffet + coffee;
decimal result2 = buffet + water;

while (!valid)
{
    Console.WriteLine(" Sorry, we only accept parties of 6 or fewer ");
    Environment.Exit(0);
}

Console.WriteLine("A table for " + NumberOfPeople + "! Please follow me and take a seat. " +
    "Let's get everyone started with some drinks." +
    " we have water or coffee. ");


for (int i = 0; i < NumberOfPeople; i++)

{
    string userInput;
    Console.WriteLine("person " + i + ", what would you like to drink? ");
    userInput = Console.ReadLine();

    if (userInput != "water" && userInput != "coffee")
    { Console.WriteLine(userInput + " we don't have that. No drink for you!!! "); }
    else if (userInput == "water")
    {
        Console.WriteLine("Water, ok!");
        totalwater++;
    }
    else
    {
        Console.WriteLine("Coffee, ok!");
        totalcoffee++;
    }



}

Console.WriteLine("Okay, so that is " + totalwater + " water(s) and " + totalcoffee + " coffee(s).");
decimal totalBill = (decimal)NumberOfPeople * 9.99M + (decimal)totalwater * 0 + (decimal)totalcoffee * 2;
Console.WriteLine($"Heres you check the total came out to be:  ${totalBill}");



