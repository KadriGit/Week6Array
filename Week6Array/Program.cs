
string[] fruitbasket = { "apples", "bananas", "Oranges" };

Console.WriteLine($"There are {fruitbasket.Length} fruit in the basket.");

//Console.WriteLine(fruitbasket[0]);
//Console.WriteLine(fruitbasket[1]);
//Console.WriteLine(fruitbasket[2]);

fruitbasket[0] = "pine-apple";
fruitbasket[1] = "peaches";

//Console.WriteLine(fruitbasket[0]);
//Console.WriteLine(fruitbasket[1]);
//Console.WriteLine(fruitbasket[2]);

for (int i = 0; i < fruitbasket.Length; i++)
{
    Console.WriteLine(fruitbasket[i]);
}