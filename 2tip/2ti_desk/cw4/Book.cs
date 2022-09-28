class Book{
    //pola klasy
    private string? title = "Wlasny tytul";
    public string? Title {
        get{ return title.ToUpper();}
        set{ title = value;}
    }
    public Publish MyPublish { get; set; }
    private decimal price = 33.89M;
    public decimal Price{
        get {return price;}
        set {price = value<0 ? -value : value;}
    }
    private string? author = "Roman Boman";
    public string? Author{
        get{return author;}
        set{ author = value;}
    }

    //metody klasy
    public Book()
    {
        Title = "noname";
        Author = "noname";
        Price = 0;
    }
      public Book(string title,string author,decimal price=10.99M)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    public override string ToString(){
        var publish = MyPublish!=null?MyPublish.Name:"";
        return $"Ksiazka: {Title} napisana przez: {Author} w cenie: {Price} PLN w wydawnictwie: {publish}";
    }
    
}
class Test{
    public override string ToString()
    {
        return " cos wlasnego do metody toString";
    }
}