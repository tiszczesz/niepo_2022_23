class Person{
    public string FirstName { get; set; }="Jan";
    public string LastName { get; set; }="Nowak";
    public DateTime BirthDate { get; set; }=DateTime.Now;

    public int GetAge(){
        return DateTime.Now.Year-BirthDate.Year;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} {GetAge()}";
    }
}