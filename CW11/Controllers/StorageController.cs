using CW11.DataAccessLayer;
using CW11.Models;
using CW11.Models.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CW11.Controllers
{
    public class StorageController : Controller
    {
        ProductService _productService = new ProductService();

        public IActionResult Index()
        {
            var result = _productService.ReadAll();
            return View(result);
        }

        public IActionResult Update(int id)
        {
            //var categories = new List<Category>();
            //ViewBag.Categories = categories.Select(c => new SelectListItem{Text = }
            var product = _productService.Read(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Update(ProductModel product)
        {
            _productService.Update(product);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int id)
        {
            _productService.Delete(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
