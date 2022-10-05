class Person{
    public string FirstName { get; set; }="Jan";
    public string LastName { get; set; }="Nowak";
    public DateTime BirthDate { get; set; }=DateTime.Now;

    private int secret = 56;
    protected int getSecret(){
        return secret;
    }
    public int GetAge(){
        return DateTime.Now.Year-BirthDate.Year;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} {GetAge()}";
    }
    public Person(){
        Console.WriteLine("Konstruktor domyślny Person");
    }
    public Person(string firstName,string lastName,DateTime birth){
        Console.WriteLine($"Konstruktor Person z parametrami {firstName} {lastName} {birth}");
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birth;
    }
}