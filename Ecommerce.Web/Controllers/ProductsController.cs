using Ecommerce.Web.Core;
using Ecommerce.Web.Data;
using Ecommerce.Web.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository repository;
        //public ProductsController():this(new ProductsRepository())
        //{

        //}
        public ProductsController(IProductRepository repository)
        {
            this.repository = repository;
        }
        // GET: ProuctsController
        public ActionResult Index()
        {
            var products = repository.GetAll();

            return View(products);
        }

        // GET: ProuctsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProuctsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProuctsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                repository.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProuctsController/Edit/5
        public ActionResult Edit(int id)
        {
            Product product = repository.GetOne(id);
            return View(product);
        }

        // POST: ProuctsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                repository.UpdateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(product);
            }
        }

        // GET: ProuctsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProuctsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
