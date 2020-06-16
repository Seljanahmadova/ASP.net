using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FronttoBack.DAL;
using FronttoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FronttoBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _db;

        public HomeController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Sliders = _db.Sliders,
                Content = _db.Contents.FirstOrDefault(),
                Categories = _db.Categories,
                Products = _db.Products.OrderByDescending(p => p.Id).Take(29)
            };
            return View(model);
        }
    }
}