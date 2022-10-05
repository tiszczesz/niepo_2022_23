class Student : Person{
    public List<string> Topics { get; set; }
    public void ShowSecret(){
        Console.WriteLine("Moj sekret: "+ /*secret*/ +getSecret());
    }
    public Student(){
        Console.WriteLine("Konstruktor domyślny Student");
        Topics = new List<string>();
    }
    public Student(string firstName,string lastName,DateTime birth,List<string> topics=null)
          
    {
        Console.WriteLine($"Konstruktor Student z parametrami {firstName} {lastName} {birth}");
    }
}