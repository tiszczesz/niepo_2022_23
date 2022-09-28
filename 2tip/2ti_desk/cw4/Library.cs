class Library{
    public static List<Publish> GetAllPublish(){
        List<Publish> publishes = new List<Publish>();
        Publish p1 = new Publish("wydawnictwo 1");
        p1.AddBook(new Book(){Title="Alicja w krainie czarow",Author="Ktos Tom",Price=23.99M});
        p1.AddBook(new Book(){Title="Programowanie w C#",Author="Grazyna Balecka",Price=123.99M});
        p1.AddBook(new Book(){Title="Gory polskie",Author="Roman Wojak",Price=66.00M});


Publish p2 = new Publish("Wydawnictwo OKO PRESS");
        p2.AddBook(new Book(){Title="Drzewa Afryki",Author="Ktos Tom",Price=23.99M});
        p2.AddBook(new Book(){Title="Sniegi Alaski",Author="Grazyna Balecka",Price=123.99M});
        p2.AddBook(new Book(){Title="W Afryce jest goraco",Author="Roman Wojak",Price=66.00M});
        publishes.Add(p1);
        publishes.Add(p2);
        return publishes;
    }
}