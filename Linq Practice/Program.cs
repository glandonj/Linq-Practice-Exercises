//#1a
Console.WriteLine();
List<decimal> values = new List<decimal>() { 2.99m, 1.00m, -3.00m, 1.50m, 13.25m, -7.99m, 6.00m, 9.99m };

List<decimal> result = values.Where(v => v >5).ToList();
foreach (decimal v in result)
{
    Console.WriteLine(v);
}

Console.WriteLine();

//#1b
List<decimal> result2 = values.Where(v => v > 0).ToList();
foreach (decimal v in result2)
{
    Console.WriteLine(v);
}

Console.WriteLine();

//#1c
List<decimal> result3 = values.Where(v => v <= 0).ToList();
foreach (decimal v in result3)
{
    Console.WriteLine(v);
}

Console.WriteLine();

//#1d
List<decimal> result4 = values.Where(v => v % 1 ==0).ToList();
foreach (decimal v in result4)
{
    Console.WriteLine(v);
}

Console.WriteLine();
//#2a

List<string> usernames = new List<string>() { "GrantChirpus123", "catFan_x", "cSharpRules", "JSDrolls", "gc", "Shrek", "cat01" };

List<string> shortnames = usernames.Where(u => u.Count()<=5).ToList();

Console.WriteLine();
foreach (string u in shortnames)
{
    Console.WriteLine(u);
}

//#2b
List<string> catnames = usernames.Where(u => u.StartsWith("cat")).ToList();

Console.WriteLine();
foreach (string u in catnames)
{
    Console.WriteLine(u);
}

Console.ReadLine();