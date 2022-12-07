// See https://aka.ms/new-console-template for more information

using Day4;

Console.WriteLine("Hello, World!");

var lines = File.ReadLines(@"data.txt");

var processor = new AssignmentProcessor(lines);
Console.WriteLine(processor.CountContainedAssignments());
Console.WriteLine(processor.CountPartiallyContainedAssignments());
