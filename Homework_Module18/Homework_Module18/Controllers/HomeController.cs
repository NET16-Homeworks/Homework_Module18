using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Homework_Module18.Models;
using Homework_Module18.Filters;

namespace Homework_Module18.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [RequestLogFilter]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}