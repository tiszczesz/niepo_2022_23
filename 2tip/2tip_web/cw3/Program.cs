
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[] document = System.IO.File.ReadAllLines("dane.txt");
Console.WriteLine(document.Length);

void ShowAll(string[] dane){
    foreach(string item in dane){
        Console.WriteLine(item);
    }    
}
void ShowOnyStartWith(string[] dane,char c){
     foreach(string  item in dane){  
        if(item.StartsWith(c)) Console.WriteLine(item);
    }
}
void HelloAll(string[] dane,int deley=500){
    foreach(string  item in dane){    
        Thread.Sleep(deley);   
        Console.WriteLine($"Witaj: {item} dzisiaj mamy: {DateTime.Now}");
    }
}
void ShowOnly(string[] dane,int length){
    foreach(string  item in dane){  
        if(item.Length>length) Console.WriteLine(item);
    }
}
ShowAll(document);
HelloAll(document,500);
ShowOnly(document,7);
ShowOnyStartWith(document,'R');
