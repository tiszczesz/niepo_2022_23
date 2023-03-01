
using Microsoft.AspNetCore.Mvc;

public class FirstController : Controller {
    public string Index(){
        return "Hello world fffff";
    }
    public IActionResult Index2(){
        return View();
    }
}