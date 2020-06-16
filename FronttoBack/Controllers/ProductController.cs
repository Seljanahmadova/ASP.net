using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FronttoBack.DAL;
using FronttoBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FronttoBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDBContext _db;
        public ProductController(AppDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View(_db.Products.Select(p=> new ProductVM { 
            Id=p.Id,
            Title=p.Title,
            Category=p.Category,
            Price=p.Price,
            Image=p.Image
            }).Take(8));
        }

        public IActionResult Load()
        {
            var model= _db.Products.Select(p => new ProductVM
            {
                Id = p.Id,
                Title = p.Title,
                Category = p.Category,
                Price = p.Price,
                Image = p.Image
            }).Skip(8).Take(8);

            return PartialView("_ProductPartialView", model);

            #region OldVersion
            //return Json(_db.Products.Select(p=> new ProductVM {
            //Id=p.Id,
            //Title=p.Title,
            //Category=p.Category,
            //Price=p.Price,
            //Image=p.Image
            //}).Skip(8).Take(8));
            #endregion

        }
    }
}
