// See https://aka.ms/new-console-template for more information

using Day2;

Console.WriteLine("Hello, World!");

var lines = File.ReadLines(@"data.txt");

var counter = new PlayCounter(lines);
Console.WriteLine(counter.MakePlays());