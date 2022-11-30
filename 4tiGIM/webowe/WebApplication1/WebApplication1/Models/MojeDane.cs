namespace WebApplication1.Models
{
    public class MojeDane
    {
        public static List<Kurs> NazwyKursow() {
            return new List<Kurs> {
                new Kurs{Id = 1,Name = "Kurs pierwszy", Data = new DateTime(2022,12,20)},
                new Kurs{Id = 2,Name = "Kurs drugi", Data = new DateTime(2022,11,20)},
                new Kurs{Id = 3,Name = "Kurs trzeci", Data = new DateTime(2022,12,26)},
                new Kurs{Id = 4,Name = "Kurs czwarty", Data = new DateTime(2023,12,20)},
            };
        }
    }

    public class Kurs {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Data { get; set; }
    }
}
