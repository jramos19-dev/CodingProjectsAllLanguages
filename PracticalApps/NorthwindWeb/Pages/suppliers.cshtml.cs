using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using Packt.Shared;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace NorthwindWeb.Pages
{
    public class SuppliersModel : PageModel
    {

        //bind property is added so that we can easily connect HTML elements on the web page to properties in the supplier class
        [BindProperty]
        public Supplier Supplier { get; set; }


        //checks that all property values conform to validation rules and then adds the supplier to the exisitng table.generates the sql insert statement. 
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                db.Suppliers.Add(Supplier);
                db.SaveChanges();
                return RedirectToPage("/suppliers");
            }
            return Page();
        }

        private Northwind db;

        public SuppliersModel(Northwind injectedContext)
        {
            db = injectedContext;
        }

        public IEnumerable<string> Suppliers { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Northwind Web Sit- Suppliers";

            Suppliers = db.Suppliers.Select(s => s.CompanyName);
        }
    }
}
