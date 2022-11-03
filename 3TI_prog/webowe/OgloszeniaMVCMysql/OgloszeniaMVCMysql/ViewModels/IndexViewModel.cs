using OgloszeniaMVCMysql.Models;

namespace OgloszeniaMVCMysql.ViewModels; 

public class IndexViewModel {
    public List<Kategorie> Kategories { get; set; }
    
    public List<Uzytkownicy> Uzytkownicies { get; set; }
}