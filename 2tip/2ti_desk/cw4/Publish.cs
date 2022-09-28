class Publish
{
    public string Name { get; set; } //auto property
    public List<Book> Books { get; set; }
    public Publish()
    {
        Name = "Noname";
        Books = new List<Book>();
    }
    public Publish(string name, List<Book> books = null)
    {
        Name = name;
        Books = books != null ? books : new List<Book>();
    }
    public void ShowAll()
    {
        if (Books != null && Books.Count > 0)
        {
            Console.WriteLine("Zbior ksiazek wydawnictwa: " + Name);
            foreach (var book in Books)
            {
                Console.WriteLine("\t"+book);
            }
        }
        else
        {
            Console.WriteLine("Zbior ksiazek wydawnictwa: " + Name + " jest pusty!");
        }
    }
    public void AddBook(Book book)
    {
        if (book != null)
        {
            book.MyPublish = this;
            Books.Add(book);
        }
    }
}