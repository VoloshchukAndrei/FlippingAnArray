var name1 = new string[] { "Viktoriia", "Danila", "Nikita", "Andrei" };

Array.Reverse(name1);

foreach (var name2 in name1)
{
    Console.Write($"{name2} ");
}