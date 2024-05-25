using Microsoft.AspNetCore.Mvc;
using RepasoMVC_v2.Models;

namespace RepasoMVC_v2.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {

        }

        public IActionResult Inventory()
        {
            ProductModel product1 = new ProductModel();
            product1.Nombre = "Sabritas";
            product1.Marca = "Barcel";
            product1.Cantidad = 3;
            product1.Precio = 100;

            ProductModel product2 = new ProductModel();
            product2.Nombre = "Sabritones";
            product2.Marca = "Aurrera";
            product2.Cantidad = 6;
            product2.Precio = 50;

            ProductModel product3 = new ProductModel();
            product3.Nombre = "Sabritones";
            product3.Marca = "Aurrera";
            product3.Cantidad = 6;
            product3.Precio = 50;

            List<ProductModel> products = new List<ProductModel>();
            products.Add(product1);
            products.Add(product2);
            products.Add(product2);
            products.Add(product2);

            return View(products);
        }

        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProductAdd(ProductModel product)
        {
            return Redirect("Inventory");
        }

    }
}