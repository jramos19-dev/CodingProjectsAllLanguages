using System.Collections.Generic;
using Packt.Shared;

namespace NorthwindMvc.Models
{
    public class HomeIndexViewModel
    {
        // view models can follow the convention to use {controller}{action}viewModel in these classes
        public int VisitorCount;
        public IList<Category> Categories { get; set; }
        public IList<Product> Products { get; set; }
    }
}

