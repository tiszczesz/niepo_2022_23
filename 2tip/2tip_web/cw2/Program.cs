// See https://aka.ms/new-console-template for more information
Console.Write("Podaj a: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 1) Console.WriteLine($"{a} nie jest liczba pierwsza");
else
{
    bool isPrimal = true;
    for (int i = 2; i*i <= a; i++)
    {
        Console.WriteLine($"Sprawdzamy liczbe {a} dla {i}");
        if (a % i == 0)
        {
            Console.WriteLine($"{a} nie jest liczba pierwsza");
            isPrimal = false;
            break;
        }
    }
    if (isPrimal) Console.WriteLine($"{a} jest liczba pierwsza");
}
//definicja funkcji
void Witaj(){
    Console.WriteLine("witaj bolek");
}
Witaj();//wywolanie funkcji



