using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new ShoppingListDbContext())
            {
                var products = db.Products.ToList();
                return View(products);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            using (var db = new ShoppingListDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();

                return this.Redirect("/");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            using (var db = new ShoppingListDbContext())
            {
                Product currentProduct = db.Products.Find(id);

                return View(currentProduct);

            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            using (var db = new ShoppingListDbContext())
            {
                Product currentProduct = db.Products.Find(id);

                currentProduct.Priority = productModel.Priority;
                currentProduct.Name = productModel.Name;
                currentProduct.Quantity = productModel.Quantity;
                currentProduct.Status = productModel.Status;

                db.SaveChanges();

                return Redirect("/");
            }
        }
    }
}