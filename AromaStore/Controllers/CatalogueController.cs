using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AromaStore.Models;


namespace AromaStore.Controllers
{
    public class CatalogueController : Controller
    {
        private IStoreRepository repository;
        public CatalogueController(IStoreRepository repo)
        {
            repository = repo;
        }
        [Route("Catalogue")]
        [Route("Catalogue/{category}")]
        public IActionResult Index(string category = null)
        {
            ViewBag.pageName = "Catalogue";
            return View(repository.Products
                .Where(p => category == null || p.Category == category));
        }

        [Route("Product/{productId}")]
        public IActionResult ProductDetails(int productId)
        {    
            Product product = repository.Products
            .FirstOrDefault(p => p.ProductID == productId);
            ViewBag.product = product;
            return View(product);
        }
    }
}
