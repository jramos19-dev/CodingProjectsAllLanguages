using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using Packt.Shared;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace NorthwindWeb.Pages
{
    public class CustomerModel : PageModel
    {

        //bind property is added so that we can easily connect HTML elements on the web page to properties in the supplier class
        [BindProperty]
        public Customer Customer { get; set; }


        //checks that all property values conform to validation rules and then adds the supplier to the exisitng table.generates the sql insert statement. 
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(Customer);
                db.SaveChanges();
                return RedirectToPage("/customers");
            }
            return Page();
        }

        private Northwind db;

        public CustomerModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public IEnumerable<string> Customers { get; set; }
        public IEnumerable<string> Orders { get; set; }


        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Sit- Customers";

            Customers = db.Customers.G

        }
    }
}
