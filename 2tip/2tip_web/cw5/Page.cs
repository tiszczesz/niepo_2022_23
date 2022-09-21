class Page
{
    //fields
    string title;
    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    string content;
    public string Content{
        get{ return content;}
        set{content = value;}
    }
    //methods
    public Page(string title,string content){
        Title = title;
        Content = content;
        Console.WriteLine($"Tworzenie obiektu strony z parametrami title: {Title} content: {Content}");
    }
    //konstruktor domyslny
    public Page(){
        Title = "noname";
        Content = "noname";
        Console.WriteLine($"Tworzenie obiektu DOMYSLNY strony z parametrami title: {Title} content: {Content}");
    }
}