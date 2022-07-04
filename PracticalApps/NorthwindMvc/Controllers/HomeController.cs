using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NorthwindMvc.Models;
using Packt.Shared;
// we add microsoft.entityframework core so that we can include related entities ;
using Microsoft.EntityFrameworkCore;

namespace NorthwindMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //adding a reference to northwind instance and initializing it
        private Northwind db;

        // adding a parameter to the homecontroller constructor method that sends in value of type Northwind with name injectedContext and then setting the variable db set to the passed in parameter
        public HomeController(ILogger<HomeController> logger, Northwind injectedContext)
        {

            //using constructor parameter injection. to pass an instance of the northwind database context
            _logger = logger;
            db = injectedContext;

        }

        public IActionResult Index()
        {
            //creates a model simulating a visitor count and using northwind database to get list of categories and products. 
            var model = new HomeIndexViewModel
            {
                VisitorCount = (new Random()).Next(1, 100),
                Categories = db.Categories.ToList(),
                Products = db.Products.ToList()

            };

            return View(model); // pass model to the view
        }
        //when the view() method is called in a controller's action method , .net core looks in views folder for a subfolder with the same name as the current controller , that is Home and a file with 
        // the same name as the current action Index.cshtml

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ProductDetail(int? id)
        {
            if (!id.HasValue)
            {
                return NotFound("you must pass a product id in the route, for example, home/productdetail/21");
            }
            //this feature is called model binding because it passes in an id  in the route and it compares it the the products and returns the one that has the id. 

            var model = db.Products.SingleOrDefault(p => p.ProductID == id);

            if (model == null)
            {
                return NotFound($"Product with Id of {id} not found");
            }
            return View(model); //pass model to view and then return result
        }

        // shows the page with a form 
        public IActionResult ModelBinding()
        {
            return View();// the page with a form to submit
        }

        // shows the page with the parameter using the model that was created. 
        // both of the modelbinding methods are the same and this is ambiguous . we can 
        // add an http attribute to mark one to be used for posts 
        [HttpPost]
        public IActionResult ModelBinding(Thing thing)
        {
            // return View(thing); // show the model bound thing 

            //pass an instance of the view model, validate the model and store an array of error messages then pass the model to the view 
            var model = new HomeModelBindingViewModel
            {
                Thing = thing,
                HasErrors = !ModelState.IsValid,
                ValidationErrors = ModelState.Values
                .SelectMany(state => state.Errors)
                .Select(error => error.ErrorMessage)
            };

            return View(model);

        }

        public IActionResult ProductsThatCostMoreThan(decimal? price)
        {
            if (!price.HasValue)
            {
                return NotFound("You must pass a product price in the query string, for example /home/productsThatCostMorethan?price=50");

            }
            IEnumerable<Product> model = db.Products
                .Include(p => p.Category)
                .Include(p => p.Supplier)
                .AsEnumerable() //switch to client-side
                .Where(p => p.UnitPrice > price);
            if (model.Count() == 0)
            {
                return NotFound($"No Producs cost more than {price:C}");
            }
            ViewData["MaxPrice"] = price.Value.ToString("C");
            return View(model); // pass model to view 
        }


    }
}
