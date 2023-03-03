
using Microsoft.AspNetCore.Mvc;

public class SecondController : Controller {
    public IActionResult Index(){
        List<string> users = new List<string>{
            "User1","User2","User3","User4"
        };
        return View(users);
    }
    public IActionResult Index2(){
        ViewBag.actionName = this.ControllerContext.RouteData.Values["action"]?.ToString();
        ViewBag.controllerName = this.ControllerContext.RouteData
                                .Values["controller"]?.ToString();
        return View();
    }
}