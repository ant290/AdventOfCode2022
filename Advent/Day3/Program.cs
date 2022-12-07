// See https://aka.ms/new-console-template for more information

using Day3;

Console.WriteLine("Hello, World!");

var lines = File.ReadLines(@"data.txt");

var processor = new BackpackProcessor();
processor.ProcessBackpackData(lines);

Console.WriteLine(processor.GetValueOfMissplacedItems());