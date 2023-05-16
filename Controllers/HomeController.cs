using Microsoft.AspNetCore.Mvc;

namespace TP04_BIS.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaPaises = Info.ListarPaises();

        return View();
    }

    public IActionResult DetallePais(string pais)
    {
        ViewBag.Pais= Info.DetallePais(pais);
        return View();
    }
    
}
