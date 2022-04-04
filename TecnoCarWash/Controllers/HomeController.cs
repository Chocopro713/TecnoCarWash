using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TecnoCarWash.Models;

namespace TecnoCarWash.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var empleado = new Empleado()
        {
            Id = 1,
            Edad = 52,
            Nombre = "Choco Poderoso"
        };
        return View(empleado);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

