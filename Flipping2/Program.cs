var name1 = new string[] { "Viktoriia", "Danila", "Nikita", "Andrei" };

Array.Reverse(name1, 1, 2);

foreach (var name2 in name1)
{
    Console.Write($"{name2} ");
}