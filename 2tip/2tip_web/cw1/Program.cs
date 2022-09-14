// See https://aka.ms/new-console-template for more information
Console.Write("Podaj swoje imie: ");
string? firstName = Console.ReadLine();
Console.WriteLine("Witaj: "+firstName+" dzisiaj mamy: "
        +DateTime.Now.ToLongDateString());

