using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using School_Project.DataAccesLayer;
using School_Project.Entity;

namespace School_Project.Controllers
{
    public class ProductsController : Controller
    {
        //private readonly Context _productDal;
        private IProductDal _productDal;
        public ProductsController(IProductDal productDal)
        {
            _productDal = productDal;
        }


        [HttpGet]
        public IActionResult Index()
        {
            var productlist = _productDal.GetList();
            return View(productlist);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var product = _productDal.Get(id);
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
     
    

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productDal.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productDal.Get(id);
            return View(product);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                _productDal.Update(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            var product = _productDal.Get(id);
            _productDal.Remove(product);
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _productDal.Get(id) != null;
        }
    }
}
