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
        return View();
    }

    public List<Historial> ObtenerHistorial()
    {
        return new List<Historial>()
        {
            new Historial()
            {
                Empleado = new Empleado()
                {
                    Id=1,
                    Edad = 20,
                    Nombre = "Fulano"
                },
                Dia = DateTime.Now,
                Hora = DateTime.Now,
                Valor = 10000,
                Vehiculo = "Maxda"
            },
            new Historial()
            {
                Empleado = new Empleado()
                {
                    Id=1,
                    Edad = 20,
                    Nombre = "Fulano"
                },
                Dia = DateTime.Now,
                Hora = DateTime.Now,
                Valor = 10000,
                Vehiculo = "Maxda"
            },
            new Historial()
            {
                Empleado = new Empleado()
                {
                    Id=1,
                    Edad = 20,
                    Nombre = "Fulano"
                },
                Dia = DateTime.Now,
                Hora = DateTime.Now,
                Valor = 10000,
                Vehiculo = "Maxda"
            }
        };
    }
    public IActionResult Historial()
    {
        var modelo = new HomeHistorialViewModel()
        {
            Historials = this.ObtenerHistorial()
        };
        return View(modelo);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

