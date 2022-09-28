// Book b1 = new Book();
// b1.Price = -34.90M;
// Book b2 = new Book("ABC czegos tam","Xawery Bebery",399.00M);
// Console.WriteLine(b1);
// Console.WriteLine(b2);
// Test t1 = new Test();
// Console.WriteLine(t1);
List<Publish> publishes = Library.GetAllPublish();
publishes[0].ShowAll();