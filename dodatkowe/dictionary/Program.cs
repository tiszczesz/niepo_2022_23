// See https://aka.ms/new-console-template for more information
using dictionary;

Console.WriteLine("Hello, World!");

FileOperation fileOperation = new FileOperation("dane.txt");
foreach(var line in fileOperation.Content){
    Console.WriteLine(line);
}
foreach(var entry in fileOperation.GetStatistics()){
    Console.WriteLine($"slowo: {entry.Key} ilosc wystapien: {entry.Value}");
}
