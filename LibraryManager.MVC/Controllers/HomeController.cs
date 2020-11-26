using LibraryManager.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace LibraryManager.MVC.Controllers
{
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Busca()
        {
            return View(new List<Livro>() { new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), new Livro(1, "1234567890123", "Machado de Assis", "La casa de marmitas", 39.9m, new System.DateTime(2010, 1, 2)), });
        }

        public IActionResult Edit(int id)
        {


            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
