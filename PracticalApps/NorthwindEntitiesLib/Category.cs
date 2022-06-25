using System.Collections.Generic;
using System.Runtime.Serialization;
using NorthwindEntitiesLib;

namespace Packt.Shared
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //related entities
        public ICollection<Product> Products { get; set; }
    }
}