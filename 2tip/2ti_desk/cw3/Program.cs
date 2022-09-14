// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void Hello(string user)
{
    Console.WriteLine("Hello " + user);
}
void ShowColors(string[] colors){
    foreach(string c in colors){
        Console.WriteLine("Fajny kolor: "+c);
    }
}
string[] users = { "user1", "antoni", "fgfgfgf", "jjjjjj", "monika", "rybka23" };
string[] colors = {"biały","zolty","czerwony","zielony","rozowy"};
Hello(users[0]);
Hello(users[users.Length - 1]);
Console.WriteLine("\t\tZwykla petla for()");
for (int i = 0; i < users.Length; i++) {
    Hello(users[i]);
}
Console.WriteLine("\t\tpetla foreach()");
foreach(string u in users){
    Hello(u);
}
Console.WriteLine(" ---------------------------------------------------- ");
ShowColors(colors);
