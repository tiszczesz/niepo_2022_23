
using Microsoft.AspNetCore.Mvc;

public class FirstController : Controller {
    public string Index(){
        return "Hello world fffff";
    }
    public IActionResult Index2(){
        List<User> users = new List<User>(){
            new User{Login="Adam",Email = "gg@hh.pl",IsAccepted=true},
            new User{Login="Adam2",Email = "gg2@hh.pl",IsAccepted=false},
            new User{Login="Adam3",Email = "gg3@hh.pl",IsAccepted=false},
            new User{Login="Adam4",Email = "gg4@hh.pl",IsAccepted=true},
        };
        return View(users);
    }
}

public class User{
    public string Login { get; set; }
    public string Email { get; set; }
    public bool IsAccepted { get; set; }
}