// See https://aka.ms/new-console-template for more information
Console.WriteLine("Witam z konsoli c#");
// int noname;
// noname = 123;
// int a = 16;
// int b = 0;
Console.Write("podaj a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("podaj a: ");
int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("noname = " + noname);
int wynik = a + b;
Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
if (b != 0)
    Console.WriteLine($"{a} / {b} = {(double)a / b}");
else 
    Console.WriteLine($"{a} / {b} = NIE DZIELIMY PRZEZ ZERO!!!");
//Console.WriteLine(a + " + " + b + " = " + wynik);

