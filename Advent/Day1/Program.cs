// See https://aka.ms/new-console-template for more information

using Day1;

Console.WriteLine("Calorie Counter!");

var lines = File.ReadLines(@"data.txt");

var processor = new BackpackProcessor();
processor.ProcessBackpackData(lines);
Console.WriteLine(processor.GetFattestPack()?.TotalCalories);

var packsList = processor.GetPacksBySize();
if (packsList != null)
{
    var total = 0;
    foreach (Backpack backpack in packsList.Take(3))
    {
        total += backpack.TotalCalories;
    }
    Console.WriteLine(total);
}