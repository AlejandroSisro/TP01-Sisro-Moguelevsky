using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01_Sisro_Moguelevsky.Models;

namespace TP01_Sisro_Moguelevsky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Grupo grupo = new Grupo();
        ViewBag.integrantes = grupo.DevolverIntegrantes();
        return View();
    }
    public IActionResult infoIntegrante(int dni)
    {
        Grupo grupo = new Grupo();
        ViewBag.integrantes[dni] = grupo.GetIntegrantes();
        return infoIntegrante();
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
