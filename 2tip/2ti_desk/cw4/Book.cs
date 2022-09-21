class Book{
    //pola klasy
    private string? title = "Wlasny tytul";
    public string? Title {
        get{ return title.ToUpper();}
    }
    private decimal price = 33.89M;
    public decimal Price{
        get {return price;}
        set {price = value<0 ? -value : value;}
    }
    private string? author = "Roman Boman";
    public string? Author{
        get{return author;}
    }

    //metody klasy
}