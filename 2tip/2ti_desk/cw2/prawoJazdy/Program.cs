// See https://aka.ms/new-console-template for more information

Console.WriteLine(" ------ Zapisy na prawo jazdy --------- \n");
Console.Write("\tPodaj imie: ");
string? firstname = Console.ReadLine();
Console.Write("\tPodaj nazwisko: ");
string? lastname = Console.ReadLine();
Console.Write("\tPodaj wiek: ");
int age = Convert.ToInt32(Console.ReadLine());
if(age >= 18){
    Console.WriteLine($"Zapisano {firstname} {lastname} na kurs prawa jazdy");
}else{
    Console.WriteLine($"Nie zapisano {firstname} {lastname} na kurs prawa jazdy `ZA MLODY`");
}
