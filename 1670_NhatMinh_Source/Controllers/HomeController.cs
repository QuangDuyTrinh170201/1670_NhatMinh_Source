using System.Diagnostics;
using _1670_NhatMinh_Source.Data;
using _1670_NhatMinh_Source.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _1670_NhatMinh_Source.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Checkout()
    {
        return View();
    }
    public IActionResult ShoppingCart()
    {
        return View();
    }
    public IActionResult ShopDetails()
    {
        return View();
    }
    public async Task<IActionResult> Library()
    {
        var applicationDbContext = _context.Book.Include(b => b.Category);
        return View(await applicationDbContext.ToListAsync());
    }
    public IActionResult Blog()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

