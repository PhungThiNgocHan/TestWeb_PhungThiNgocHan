using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestWeb_PhungThiNgocHan.Models;

namespace TestWeb_PhungThiNgocHan.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _db;
        private readonly ILogger<BookController> _logger;

        public BookController(AppDbContext db, ILogger<BookController> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var bookList = _db.Products.ToList();
            return View(bookList);
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
}

