using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NEWSOFT.Data;
using NEWSOFT.Models;
using NEWSOFT.ViewModels;

namespace NEWSOFT.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

   

    private readonly  AppDbContext _Context;
    

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _Context = context;
    }

    public IActionResult Index()
    {
        var about = _Context.Abouts.ToList();
        var slider = _Context.Sliders.ToList();
        var who = _Context.Whos.OrderBy(x=>x.Id).Last();
        var feat = _Context.Features.ToList();
        HomeVM homeVm = new()
        {
            Abouts = about,
            Sliders = slider,
            Who = who,
            Features = feat
        };
        return View(homeVm);
    }

    [HttpPost]
    public IActionResult Index(Contact contact)
    {   
        _Context.Contacts.Add(contact);
        _Context.SaveChanges();
        return RedirectToAction(nameof(Index));
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